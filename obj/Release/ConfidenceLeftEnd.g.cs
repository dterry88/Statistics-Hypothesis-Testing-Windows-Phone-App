﻿#pragma checksum "C:\Users\Dterryable\Documents\Visual Studio 2013\Projects\StatsHypoyhesis\StatsHypoyhesis\ConfidenceLeftEnd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C84B860E8DA7A8932DBF6350452F4009"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace StatsHypoyhesis {
    
    
    public partial class ConfidenceLeftEnd : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtS;
        
        internal System.Windows.Controls.TextBox txtLeftEnd;
        
        internal System.Windows.Controls.TextBox txtValue;
        
        internal System.Windows.Controls.Button btnConLeft;
        
        internal System.Windows.Controls.Button btnClear;
        
        internal System.Windows.Controls.TextBlock tbResult;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/StatsHypoyhesis;component/ConfidenceLeftEnd.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtS = ((System.Windows.Controls.TextBox)(this.FindName("txtS")));
            this.txtLeftEnd = ((System.Windows.Controls.TextBox)(this.FindName("txtLeftEnd")));
            this.txtValue = ((System.Windows.Controls.TextBox)(this.FindName("txtValue")));
            this.btnConLeft = ((System.Windows.Controls.Button)(this.FindName("btnConLeft")));
            this.btnClear = ((System.Windows.Controls.Button)(this.FindName("btnClear")));
            this.tbResult = ((System.Windows.Controls.TextBlock)(this.FindName("tbResult")));
        }
    }
}

