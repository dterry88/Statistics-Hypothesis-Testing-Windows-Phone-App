﻿#pragma checksum "C:\Users\Dterryable\Documents\Visual Studio 2013\Projects\StatsHypoyhesis\StatsHypoyhesis\ChiTestVariance.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3DA51EFE24846987C6032A5DFAADE868"
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
    
    
    public partial class ChiTestVariance : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtN;
        
        internal System.Windows.Controls.TextBox txtS;
        
        internal System.Windows.Controls.TextBox txtA;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/StatsHypoyhesis;component/ChiTestVariance.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtN = ((System.Windows.Controls.TextBox)(this.FindName("txtN")));
            this.txtS = ((System.Windows.Controls.TextBox)(this.FindName("txtS")));
            this.txtA = ((System.Windows.Controls.TextBox)(this.FindName("txtA")));
            this.tbResult = ((System.Windows.Controls.TextBlock)(this.FindName("tbResult")));
        }
    }
}

