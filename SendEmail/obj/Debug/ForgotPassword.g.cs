﻿#pragma checksum "..\..\ForgotPassword.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00E3989C020F4E2A2109C4FA7708404EF3F46EC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace SendEmail {
    
    
    /// <summary>
    /// ForgotPassword
    /// </summary>
    public partial class ForgotPassword : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email_Txt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Check_Btn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox OldPassword_Txt;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox NewPassword_Txt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox RetypePassword_Txt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login_Btn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel_Btn;
        
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
            System.Uri resourceLocater = new System.Uri("/SendEmail;component/forgotpassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ForgotPassword.xaml"
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
            this.Email_Txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Check_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\ForgotPassword.xaml"
            this.Check_Btn.Click += new System.Windows.RoutedEventHandler(this.Check_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OldPassword_Txt = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.NewPassword_Txt = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.RetypePassword_Txt = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.Login_Btn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Cancel_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\ForgotPassword.xaml"
            this.Cancel_Btn.Click += new System.Windows.RoutedEventHandler(this.Cancel_Btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
