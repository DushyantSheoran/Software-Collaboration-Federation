﻿#pragma checksum "..\..\RequestCreation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4C64ABB2B68FDD9E2391E6FC76C5A279"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BuildServerFederation;
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


namespace BuildServerFederation {
    
    
    /// <summary>
    /// RequestCreation
    /// </summary>
    public partial class RequestCreation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\RequestCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TestName;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\RequestCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox author;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\RequestCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox toolChain;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\RequestCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox testDriver;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\RequestCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox testCases;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\RequestCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox testAdded;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\RequestCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addtest;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\RequestCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createRequest;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientGUI;component/requestcreation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RequestCreation.xaml"
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
            this.TestName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.author = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.toolChain = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.testDriver = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.testCases = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.testAdded = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.addtest = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\RequestCreation.xaml"
            this.addtest.Click += new System.Windows.RoutedEventHandler(this.addTest_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.createRequest = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\RequestCreation.xaml"
            this.createRequest.Click += new System.Windows.RoutedEventHandler(this.done_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
