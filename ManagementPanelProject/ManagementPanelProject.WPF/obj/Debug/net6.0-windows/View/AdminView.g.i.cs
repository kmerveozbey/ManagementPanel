﻿#pragma checksum "..\..\..\..\View\AdminView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DA705FC640AE282C51504F1FEE9EDF380B5A422C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ManagementPanelProject.WPF.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ManagementPanelProject.WPF.View {
    
    
    /// <summary>
    /// AdminView
    /// </summary>
    public partial class AdminView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtAdm;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btNewAcc;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listGrid;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem addClick;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem modifyClick;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem deleteClick;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\View\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem refreshClick;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ManagementPanelProject.WPF;component/view/adminview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AdminView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\..\View\AdminView.xaml"
            ((ManagementPanelProject.WPF.View.AdminView)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\..\View\AdminView.xaml"
            ((ManagementPanelProject.WPF.View.AdminView)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtAdm = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\View\AdminView.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\..\View\AdminView.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btNewAcc = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\..\..\View\AdminView.xaml"
            this.btNewAcc.Click += new System.Windows.RoutedEventHandler(this.btNewAcc_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.addClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 194 "..\..\..\..\View\AdminView.xaml"
            this.addClick.Click += new System.Windows.RoutedEventHandler(this.add_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.modifyClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 195 "..\..\..\..\View\AdminView.xaml"
            this.modifyClick.Click += new System.Windows.RoutedEventHandler(this.modify_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.deleteClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 196 "..\..\..\..\View\AdminView.xaml"
            this.deleteClick.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.refreshClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 197 "..\..\..\..\View\AdminView.xaml"
            this.refreshClick.Click += new System.Windows.RoutedEventHandler(this.refresh_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

