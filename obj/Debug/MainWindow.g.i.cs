﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DBD2E1CDB31E2FC2ECA76E0500EEA437A6A53FD35A0ABF95C2316784004D7C7B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using ToolBox;


namespace ToolBox {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView GroupListBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ChangeGroupNameBt;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DelGroupBt;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Debug_text;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ToolsListView;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem OpenToolsBt;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AddToolsBt;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem FreshToolsListBt;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditToolsBt;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem OpenOnFileBt;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DelToolBt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ToolBox;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\MainWindow.xaml"
            ((ToolBox.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Create_SQL_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 14 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddGroup_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GroupListBox = ((System.Windows.Controls.ListView)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.GroupListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.GroupList_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.GroupListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GroupList_SelectionChange);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.GroupListBox.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GroupListBox_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 43 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddGroup_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 44 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.FreshGroup_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ChangeGroupNameBt = ((System.Windows.Controls.MenuItem)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.ChangeGroupNameBt.Click += new System.Windows.RoutedEventHandler(this.ChangeGroupName_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DelGroupBt = ((System.Windows.Controls.MenuItem)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.DelGroupBt.Click += new System.Windows.RoutedEventHandler(this.DelGroup_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Debug_text = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\MainWindow.xaml"
            this.Debug_text.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Debug_text_TextChange);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ToolsListView = ((System.Windows.Controls.ListView)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.ToolsListView.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ToolsListView_MouseClick);
            
            #line default
            #line hidden
            
            #line 56 "..\..\MainWindow.xaml"
            this.ToolsListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ToolsListView_MouseBoubleClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.OpenToolsBt = ((System.Windows.Controls.MenuItem)(target));
            
            #line 75 "..\..\MainWindow.xaml"
            this.OpenToolsBt.Click += new System.Windows.RoutedEventHandler(this.OpenToolsBt_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.AddToolsBt = ((System.Windows.Controls.MenuItem)(target));
            
            #line 76 "..\..\MainWindow.xaml"
            this.AddToolsBt.Click += new System.Windows.RoutedEventHandler(this.AddTools_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.FreshToolsListBt = ((System.Windows.Controls.MenuItem)(target));
            
            #line 77 "..\..\MainWindow.xaml"
            this.FreshToolsListBt.Click += new System.Windows.RoutedEventHandler(this.FreshToolsList_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.EditToolsBt = ((System.Windows.Controls.MenuItem)(target));
            
            #line 78 "..\..\MainWindow.xaml"
            this.EditToolsBt.Click += new System.Windows.RoutedEventHandler(this.EditToolsData_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.OpenOnFileBt = ((System.Windows.Controls.MenuItem)(target));
            
            #line 79 "..\..\MainWindow.xaml"
            this.OpenOnFileBt.Click += new System.Windows.RoutedEventHandler(this.OpenOnFileBt_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.DelToolBt = ((System.Windows.Controls.MenuItem)(target));
            
            #line 80 "..\..\MainWindow.xaml"
            this.DelToolBt.Click += new System.Windows.RoutedEventHandler(this.DelTools_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

