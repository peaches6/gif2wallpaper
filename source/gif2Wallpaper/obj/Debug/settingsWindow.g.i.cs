﻿#pragma checksum "..\..\settingsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E661F236B20A3F22C78088FF08D748DB"
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
using gif2Wallpaper;


namespace gif2Wallpaper {
    
    
    /// <summary>
    /// settingsWindow
    /// </summary>
    public partial class settingsWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\settingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button setCustomFolder;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\settingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox customIntervalCheckbox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\settingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customIntervalInput;
        
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
            System.Uri resourceLocater = new System.Uri("/gif2Wallpaper;component/settingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\settingsWindow.xaml"
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
            this.setCustomFolder = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\settingsWindow.xaml"
            this.setCustomFolder.Click += new System.Windows.RoutedEventHandler(this.setCustomFolder_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.customIntervalCheckbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\settingsWindow.xaml"
            this.customIntervalCheckbox.Click += new System.Windows.RoutedEventHandler(this.customIntervalCheckbox_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.customIntervalInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\settingsWindow.xaml"
            this.customIntervalInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.customIntervalInput_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

