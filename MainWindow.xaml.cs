using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.SQLite;
using System.IO;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolBox
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string base_config_path = "Config/";
        private Model.MySqlite conn_obj = new Model.MySqlite();

        //记录现在的数据表名称，避免重复多次查询数据库
        string now_table_name = string.Empty;

        private void init_database(string sql_path)
        {
            try
            {
                conn_obj.ConnectSQL(sql_path);
                //记录组名称以及对应的数据表名称
                conn_obj.CommitCommand("create table if not exists GroupName(ID INTEGER PRIMARY KEY Autoincrement, Name TEXT NOT NULL, TableName TEXT);");
            }
            catch (Exception ex)
            {
                Debug_text.AppendText("数据库初始化失败." + ex.Message);
            }
        }

        //刷新组数据
        private void FreshGroup()
        {
            try
            {
                var result = conn_obj.ReadData("SELECT * FROM GroupName;");
                List<Model.GroupBinding> items = new List<Model.GroupBinding>();
                string iconPath = "Image/ico_png.png";
                while (result.Read())
                {
                    items.Add(new Model.GroupBinding() { Icon = iconPath, GroupName = result[1] as string });
                }
                result.Close();
                GroupListBox.ItemsSource = items;
            }
            catch (Exception ex)
            {
                Debug_text.AppendText("错误信息" + ex.Message + "\r");
            }
        }
        /// <summary>
        /// 刷新工具列表
        /// </summary>
        /// <param name="group_name"></param>
        private void FreshToolName(string group_name)
        {
            try
            {
                List<Model.ToolsBinding> tools_items = new List<Model.ToolsBinding>();
                var result = conn_obj.ReadData($"SELECT * FROM {group_name};");
                while (result.Read())
                {
                    string _path = result[2] as string;
                    tools_items.Add(new Model.ToolsBinding() { Icon = Model.ConfigFileCreate.GetIcon(_path), Name = result[1] as string, ToolPath = _path, Time = result[3] as string });
                }
                result.Close();
                ToolsListView.ItemsSource = tools_items;
            }
            catch (Exception ex)
            {
                Debug_text.AppendText("错误信息：" + ex.Message + "\r");
            }
        }
        /// <summary>
        /// 从数据库获取组名称和表名称
        /// </summary>
        /// <returns>组名称， 表名称</returns>
        private string[] GetGroupDataFromTable()
        {
            var get_data = GroupListBox.SelectedItem as Model.GroupBinding;
            var result = conn_obj.ReadData($"select TableName from GroupName where Name = '{get_data.GroupName}';");
            List<string> list = new List<string>();
            while (result.Read())
                list.Add(result[0] as string);
            if (list.Count > 0)
                return new string[] { get_data.GroupName, list[0] };
            else
                return new string[] { get_data.GroupName, list[0] };
        }

        public MainWindow()
        {
            InitializeComponent();
            //创建数据文件夹
            _ = Model.ConfigFileCreate.CreateDir(base_config_path);
            try
            {
                Rect restoreBounds = Properties.Settings.Default.FormSize;
                this.WindowState = Properties.Settings.Default.MainWindowState;
                this.Left = restoreBounds.Left;
                this.Top = restoreBounds.Top;
                this.Width = restoreBounds.Width;
                this.Height = restoreBounds.Height;
            }
            catch { }

            init_database(base_config_path + "config.db");

            FreshGroup();

            Debug_text.AppendText("运行开始\r");
        }

        //退出程序
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //组类型双击
        private void GroupList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (GroupListBox.SelectedIndex > -1)
            {
                string[] get_data = GetGroupDataFromTable();
                if (get_data[1] != null)
                {
                    FreshToolName(get_data[1]);
                    now_table_name = get_data[1];
                }
                else
                    Debug_text.AppendText("工具列表获取失败");
            }
        }

        //数据库创建
        private void Create_SQL_Click(object sender, RoutedEventArgs e)
        {
            string sql_path = base_config_path + "config.db";
            //检查是否存在目标文件，没有则创建
            if (!File.Exists(sql_path))
            {
                SQLiteConnection.CreateFile(sql_path);
            }
            try
            {
                init_database(sql_path);
            }
            catch (Exception ex)
            {
                Debug_text.AppendText("打开数据库：" + sql_path + "的连接失败：" + ex.Message);
            }
            FreshGroup();
        }
        //添加组
        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            Forms.AddNamesForms addNamesForms = new Forms.AddNamesForms
            {
                Text = "添加工具类型"
            };
            if (addNamesForms.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = $"create table if not exists {addNamesForms.TableName.Text}(ID INTEGER PRIMARY KEY Autoincrement, " +
                    $"Name TEXT NOT NULL, Path TEXT NOT NULL, Time TEXT);" +
                    //将表名称和组名称插入到组名称数据表
                    $"insert into GroupName (Name, TableName) values ('{addNamesForms.Name_Dt.Text}', '{addNamesForms.TableName.Text}');";
                conn_obj.CommitCommand(sql);
            }
            addNamesForms.Dispose();
            FreshGroup();
        }
        //刷新组列表
        private void FreshGroup_Click(object sender, RoutedEventArgs e)
        {
            FreshGroup();
        }

        //删除该组
        private void DelGroup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (now_table_name != string.Empty)
                {
                    //命令初始化
                    string sql = $"DROP TABLE {now_table_name}; " +
                        $"DELETE FROM GroupName where TableName = '{now_table_name}';";
                    conn_obj.CommitCommand(sql);
                    ToolsListView.ItemsSource = new List<Model.ToolsBinding>();
                    now_table_name = string.Empty;
                    FreshGroup();
                }
                else
                    Debug_text.AppendText("没有选中数据库");
            }
            catch (Exception ex)
            {
                Debug_text.AppendText("删除出错：" + ex.Message);
            }
        }
        //控制组右键菜单状态
        private void StatusToGroupContextMenu(bool status)
        {
            DelGroupBt.IsEnabled = status;
            ChangeGroupNameBt.IsEnabled = status;
        }

        //类型点击
        private void GroupListBox_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (GroupListBox.SelectedIndex > -1)
                StatusToGroupContextMenu(true);
            else
                StatusToGroupContextMenu(false);
        }
        /// <summary>
        /// 修改组名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeGroupName_Click(object sender, RoutedEventArgs e)
        {
            Model.GroupBinding get_data = GroupListBox.SelectedItem as Model.GroupBinding;
            Forms.AddNamesForms addNamesForms = new Forms.AddNamesForms()
            {
                Text = "修改组名称"
            };
            addNamesForms.Name_Dt.Text = get_data.GroupName;
            addNamesForms.TableName.Text = now_table_name;
            addNamesForms.TableName.ReadOnly = true;
            if (addNamesForms.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = $"update GroupName set Name = '{addNamesForms.Name_Dt.Text}' where TableName = '{now_table_name}';";
                //数据更新
                conn_obj.CommitCommand(sql);
            }
            addNamesForms.Dispose();
            //刷新列表
            FreshGroup();
        }
        //更新当前选中组名称
        private void GroupList_SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if (GroupListBox.SelectedIndex > -1)
            {
                string[] result = GetGroupDataFromTable();
                now_table_name = result[1];
            }
            else
                now_table_name = string.Empty;
            if (now_table_name != string.Empty)
                Debug_text.AppendText(now_table_name + "\r");
            else
                Debug_text.AppendText("没有选中的类\r");
        }

        //==============工具表编辑
        private void StatusToToolsContextMenu(bool status)
        {
            DelToolBt.IsEnabled = status;
            EditToolsBt.IsEnabled = status;
            OpenToolsBt.IsEnabled = status;
            OpenOnFileBt.IsEnabled = status;
        }
        //添加工具
        private void AddTools_Click(object sender, RoutedEventArgs e)
        {
            Forms.AddToolsForm addToolsForm = new Forms.AddToolsForm()
            {
                Text = "添加工具"
            };
            if (addToolsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                conn_obj.CommitCommand($"insert into {now_table_name} (Name, Path) values ('{addToolsForm.ToolsName.Text}', '{addToolsForm.ToolsPath.Text}');");
            }
            addToolsForm.Dispose();
            FreshToolName(now_table_name);
        }
        //刷新
        private void FreshToolsList_Click(object sender, RoutedEventArgs e)
        {
            FreshToolName(now_table_name);
        }
        //删除
        private void DelTools_Click(object sender, RoutedEventArgs e)
        {
            Model.ToolsBinding get_data = ToolsListView.SelectedItem as Model.ToolsBinding;
            if (get_data != null)
                conn_obj.CommitCommand($"DELETE FROM {now_table_name} where Name = '{get_data.Name}';");
            FreshToolName(now_table_name);
        }
        //修改
        private void EditToolsData_Click(object sender, RoutedEventArgs e)
        {
            Model.ToolsBinding get_data = ToolsListView.SelectedItem as Model.ToolsBinding;
            Forms.AddToolsForm addToolsForm1 = new Forms.AddToolsForm()
            {
                Text = "修改数据"
            };
            addToolsForm1.ToolsName.Text = get_data.Name;
            addToolsForm1.ToolsPath.Text = get_data.ToolPath;
            if (addToolsForm1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                conn_obj.CommitCommand($"update {now_table_name} set Name = '{addToolsForm1.ToolsName.Text}', " +
                    $"Path = '{addToolsForm1.ToolsPath.Text}' where Name = '{get_data.Name}';");
            }
            addToolsForm1.Dispose();
            FreshToolName(now_table_name);
        }
        //点击控制
        private void ToolsListView_MouseClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (now_table_name == string.Empty)
            {
                AddToolsBt.IsEnabled = false;
                FreshToolsListBt.IsEnabled = false;
            }
            else
            {
                AddToolsBt.IsEnabled = true;
                FreshToolsListBt.IsEnabled = true;
            }
            if (ToolsListView.SelectedIndex > -1)
                StatusToToolsContextMenu(true);
            else
                StatusToToolsContextMenu(false);
        }
        //=============END++++++++++++
        //debug滚动条，防止内存泄漏
        private void Debug_text_TextChange(object sender, TextChangedEventArgs e)
        {
            Debug_text.ScrollToEnd();
            if (Debug_text.LineCount > 3001)
            {
                Debug_text.Text = Debug_text.Text.Substring(Debug_text.GetLineText(0).Length + 1);
            }
        }

        //============工具运行设置
        //多线程与委托
        //子线程运行游戏
        public void RunTool(object arr)
        {
            string[] arrStr = arr as string[];
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = arrStr[1];
                startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(arrStr[1]);
                Process p = Process.Start(startInfo);
                p.WaitForExit();
            }
            catch { }
        }
        //============================

        //双击打开
        private void ToolsListView_MouseBoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            OpenToolsBt_Click(sender, e);
        }

        //在文件管理器中打开目标路径
        private void OpenOnFileBt_Click(object sender, RoutedEventArgs e)
        {
            if (ToolsListView.SelectedIndex > -1)
            {
                Model.ToolsBinding get_data = ToolsListView.SelectedItem as Model.ToolsBinding;
                //string _path = System.IO.Path.GetDirectoryName(get_data.ToolPath);
                Process.Start("Explorer.exe", "/select," + get_data.ToolPath);
            }
        }
        //右键打开
        private void OpenToolsBt_Click(object sender, RoutedEventArgs e)
        {
            int index = ToolsListView.SelectedIndex;
            if (index > -1)
            {
                Model.ToolsBinding get_data = ToolsListView.SelectedItem as Model.ToolsBinding;
                string[] arr = new string[2] { get_data.Name, get_data.ToolPath };
                Thread t = new Thread(RunTool)
                {
                    IsBackground = true,
                };
                t.Start(arr);
                conn_obj.CommitCommand($"update {now_table_name} set Time = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}' where Name = '{get_data.Name}';");
                FreshToolName(now_table_name);
            }
        }
        //窗口关闭事件
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            conn_obj.CloseSQL();
            Properties.Settings.Default.FormSize = this.RestoreBounds;
            Properties.Settings.Default.MainWindowState = this.WindowState;

            Properties.Settings.Default.Save();
        }
    }

}
