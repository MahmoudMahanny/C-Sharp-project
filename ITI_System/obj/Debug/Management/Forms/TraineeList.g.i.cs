<<<<<<< HEAD
﻿#pragma checksum "..\..\..\..\Management\Forms\TraineeList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "30C2C97F5D740E0CBACFED999C49EF9E"
=======
﻿#pragma checksum "..\..\..\..\Management\Forms\TraineeList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3546CC32DF8F1EBB9D412A7BB4D0D1E1"
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

using ITI_System.Management;
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


namespace ITI_System.Management {
    
    
    /// <summary>
    /// TraineeList
    /// </summary>
    public partial class TraineeList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Management\Forms\TraineeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel toolBar;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Management\Forms\TraineeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Management\Forms\TraineeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Management\Forms\TraineeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Management\Forms\TraineeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEixt;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Management\Forms\TraineeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstTrainee;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Management\Forms\TraineeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Management\Forms\TraineeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/ITI_System;component/management/forms/traineelist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Management\Forms\TraineeList.xaml"
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
            this.toolBar = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 2:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Management\Forms\TraineeList.xaml"
            this.btnAdd.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.btnAdd_MouseoubleClick);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\Management\Forms\TraineeList.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Management\Forms\TraineeList.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Management\Forms\TraineeList.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEixt = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Management\Forms\TraineeList.xaml"
            this.btnEixt.Click += new System.Windows.RoutedEventHandler(this.btnEixt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstTrainee = ((System.Windows.Controls.ListBox)(target));
            
            #line 60 "..\..\..\..\Management\Forms\TraineeList.xaml"
            this.lstTrainee.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\Management\Forms\TraineeList.xaml"
            this.lstTrainee.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\..\Management\Forms\TraineeList.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbSearch = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

