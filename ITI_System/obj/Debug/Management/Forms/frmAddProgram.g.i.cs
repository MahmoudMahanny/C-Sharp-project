<<<<<<< HEAD
﻿#pragma checksum "..\..\..\..\Management\Forms\frmAddProgram.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "79EA60280DBCFA811779F59724C8BC1F"
=======
﻿#pragma checksum "..\..\..\..\Management\Forms\frmAddProgram.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "54D9F52AC61B6F4F2995687C7CCF8333"
>>>>>>> 12b0b0bf55736931e370abd75430159edfcd9e03
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ITI_System;
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


namespace ITI_System {
    
    
    /// <summary>
    /// frmAddProgram
    /// </summary>
    public partial class frmAddProgram : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolBar;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnsave;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnclear;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnexit;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDesc;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtID;
        
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
            System.Uri resourceLocater = new System.Uri("/ITI_System;component/management/forms/frmaddprogram.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
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
            this.toolBar = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 2:
            this.btnsave = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
            this.btnsave.Click += new System.Windows.RoutedEventHandler(this.Button_Save);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnclear = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
            this.btnclear.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnexit = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Management\Forms\frmAddProgram.xaml"
            this.btnexit.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxtDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxtID = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

