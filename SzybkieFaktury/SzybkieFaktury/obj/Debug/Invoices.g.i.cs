﻿#pragma checksum "..\..\Invoices.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F86091BB894B6D77B215F2E757A8AA4CC2861FB832EB02216B6A06B9A8E341C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using SzybkieFaktury;


namespace SzybkieFaktury {
    
    
    /// <summary>
    /// Invoices
    /// </summary>
    public partial class Invoices : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Invoices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddInvoice_Button;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Invoices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditInvoice_Button;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Invoices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelInvoice_Button;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Invoices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowInvoice;
        
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
            System.Uri resourceLocater = new System.Uri("/SzybkieFaktury;component/invoices.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Invoices.xaml"
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
            this.AddInvoice_Button = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Invoices.xaml"
            this.AddInvoice_Button.Click += new System.Windows.RoutedEventHandler(this.AddInvoice_Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditInvoice_Button = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Invoices.xaml"
            this.EditInvoice_Button.Click += new System.Windows.RoutedEventHandler(this.EditInvoice_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DelInvoice_Button = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Invoices.xaml"
            this.DelInvoice_Button.Click += new System.Windows.RoutedEventHandler(this.DelInvoice_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShowInvoice = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
