﻿#pragma checksum "..\..\..\View\SearchMainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5C3DBB9E07C6DE5011BF2DAC895142E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryUltimate.ViewModel;
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


namespace LibraryWPF2.View {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadFromJSON;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveToJSON;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadFromMsSql;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchAuthorList;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblResultListSearch;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSearchAuthor;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbBook;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSearchBookName;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAuthor;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\View\SearchMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryUltimate;component/view/searchmainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\SearchMainWindow.xaml"
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
            this.btnLoadFromJSON = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.btnSaveToJSON = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btnLoadFromMsSql = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 5:
            this.listView = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnSearchAuthorList = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.lblResultListSearch = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblSearchAuthor = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.tbBook = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.lblSearchBookName = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.tbAuthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
