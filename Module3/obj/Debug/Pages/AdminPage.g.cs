﻿#pragma checksum "..\..\..\Pages\AdminPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12CD313D7A49A3AB0BC4D12A88C6CB23CE21B9FBAA1D9E58B0D637B410A86529"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Module3.ModelClasses;
using Module3.Pages;
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


namespace Module3.Pages {
    
    
    /// <summary>
    /// AdminPage
    /// </summary>
    public partial class AdminPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid accountsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn iDColumn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn loginColumn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn passwordColumn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn fullNameColumn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn badLoginTryColumn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn lastDateAuthorizationColumn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn roleIDColumn;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn statusIDColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/Module3;component/pages/adminpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AdminPage.xaml"
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
            
            #line 10 "..\..\..\Pages\AdminPage.xaml"
            ((Module3.Pages.AdminPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.accountsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.iDColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.loginColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.passwordColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.fullNameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.badLoginTryColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.lastDateAuthorizationColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 9:
            this.roleIDColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 10:
            this.statusIDColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            
            #line 61 "..\..\..\Pages\AdminPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 63 "..\..\..\Pages\AdminPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 65 "..\..\..\Pages\AdminPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 68 "..\..\..\Pages\AdminPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

