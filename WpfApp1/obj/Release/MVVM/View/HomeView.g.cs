﻿#pragma checksum "..\..\..\..\MVVM\View\HomeView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6218E831C23B09C5B4D829B4BB6CFB1F7D5E1AF3E5A60F7141134FDB26FBE882"
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
using WpfApp1.MVVM.View;


namespace WpfApp1.MVVM.View {
    
    
    /// <summary>
    /// HomeView
    /// </summary>
    public partial class HomeView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\MVVM\View\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Temperature;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\MVVM\View\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Hyderabad;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\MVVM\View\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Bangalore;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\MVVM\View\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Taguig;
        
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
            System.Uri resourceLocater = new System.Uri("/Weather;component/mvvm/view/homeview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\HomeView.xaml"
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
            this.Temperature = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Hyderabad = ((System.Windows.Controls.Border)(target));
            
            #line 97 "..\..\..\..\MVVM\View\HomeView.xaml"
            this.Hyderabad.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GetWeather);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Bangalore = ((System.Windows.Controls.Border)(target));
            
            #line 113 "..\..\..\..\MVVM\View\HomeView.xaml"
            this.Bangalore.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GetWeather);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Taguig = ((System.Windows.Controls.Border)(target));
            
            #line 129 "..\..\..\..\MVVM\View\HomeView.xaml"
            this.Taguig.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GetWeather);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

