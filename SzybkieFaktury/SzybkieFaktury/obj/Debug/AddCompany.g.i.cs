﻿#pragma checksum "..\..\AddCompany.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "074FA414D9F5C4FF964B0367F0AEA8ED52608D6AB7C4958E9BAE975B48303D65"
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
    /// AddCompany
    /// </summary>
    public partial class AddCompany : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddNip_TextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddName_TextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddCity_TextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddStreet_TextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddBuilding_TextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddPostcode_TextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AddingCompany_DataGridView;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelCompany_Button;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditCompany_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/SzybkieFaktury;component/addcompany.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddCompany.xaml"
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
            
            #line 10 "..\..\AddCompany.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCompany_Button);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddNip_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AddName_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AddCity_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddStreet_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AddBuilding_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddPostcode_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AddingCompany_DataGridView = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\AddCompany.xaml"
            this.AddingCompany_DataGridView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AddingCompany_DataGridView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DelCompany_Button = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\AddCompany.xaml"
            this.DelCompany_Button.Click += new System.Windows.RoutedEventHandler(this.DelCompany_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EditCompany_Button = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AddCompany.xaml"
            this.EditCompany_Button.Click += new System.Windows.RoutedEventHandler(this.EditCompany_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

