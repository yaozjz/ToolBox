using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace ToolBox.Model
{
    internal class MySqlite
    {
        public SQLiteConnection Conn;
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="path"></param>
        public void ConnectSQL(string path)
        {
            Conn = new SQLiteConnection("Data Source=" + path + ";Version=3;");
            Connect();
        }
        private void Connect()
        {
            if (Conn.State != System.Data.ConnectionState.Open)
            {
                Conn.Open();
            }
        }
        /// <summary>
        /// 命令发送
        /// </summary>
        /// <param name="command"></param>
        public int CommitCommand(string command)
        {
            SQLiteCommand cmd = new SQLiteCommand(command, Conn);
            var result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SQLiteDataReader ReadData(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, Conn);
            var result = command.ExecuteReader();
            command.Dispose();
            return result;
        }

        //获取数据库最后一行数据
        public SQLiteDataReader GetLastData(string table_name, string data = "*")
        {
            return ReadData($"select {data} from {table_name} order by ID desc limit 1;");
        }
        //获取数据库第一行数据
        public SQLiteDataReader GetFirstData(string table_name, string data = "*")
        {
            return ReadData($"select {data} from {table_name} limit 1;");
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public void CloseSQL()
        {
            if(Conn.State != System.Data.ConnectionState.Closed)
            {
                Conn.Close();
            }
        }
    }
}
