﻿#pragma checksum "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6C19162DC754D6939D8E5848E18CC877"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using LifeService;
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
using System.Windows.Interactivity;
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


namespace LifeService.View.AlarmClockView {
    
    
    /// <summary>
    /// AlarmClockAddItemView
    /// </summary>
    public partial class AlarmClockAddItemView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox mainViewbox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid headGrid;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LifeService.RollNum Roll_Format;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LifeService.RollNum Roll_Hours;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LifeService.RollNum Roll_Minutes;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border deleteBorder;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid deleteGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/LifeService;component/view/alarmclockview/alarmclockadditemview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AlarmClockView\AlarmClockAddItemView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.mainViewbox = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 2:
            this.headGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Roll_Format = ((LifeService.RollNum)(target));
            return;
            case 4:
            this.Roll_Hours = ((LifeService.RollNum)(target));
            return;
            case 5:
            this.Roll_Minutes = ((LifeService.RollNum)(target));
            return;
            case 6:
            this.deleteBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.deleteGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

