<<<<<<< HEAD
﻿#pragma checksum "..\..\..\..\Management\Forms\TrackForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "31568B08171BEC045F9DA09F04D6ED4F"
=======
﻿#pragma checksum "..\..\..\..\Management\Forms\TrackForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BBADC169AF658D6140D52B38901EAAF5"
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
    /// TrackForm
    /// </summary>
    public partial class TrackForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Management\Forms\TrackForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Management\Forms\TrackForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDesc;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Management\Forms\TrackForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtID;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Management\Forms\TrackForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolBar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Management\Forms\TrackForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add_save;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Management\Forms\TrackForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_up_save;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Management\Forms\TrackForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClear;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Management\Forms\TrackForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel BtnClear1;
        
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
            System.Uri resourceLocater = new System.Uri("/ITI_System;component/management/forms/trackform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Management\Forms\TrackForm.xaml"
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
            this.TxtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtDesc = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\..\Management\Forms\TrackForm.xaml"
            this.TxtDesc.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDesc_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtID = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\..\Management\Forms\TrackForm.xaml"
            this.TxtID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDesc_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.toolBar = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 5:
            this.btn_add_save = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Management\Forms\TrackForm.xaml"
            this.btn_add_save.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_up_save = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Management\Forms\TrackForm.xaml"
            this.btn_up_save.Click += new System.Windows.RoutedEventHandler(this.btn_up_save_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnClear = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\Management\Forms\TrackForm.xaml"
            this.BtnClear.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnClear1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            
            #line 67 "..\..\..\..\Management\Forms\TrackForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

