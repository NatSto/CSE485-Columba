﻿#pragma checksum "C:\Users\David\Desktop\CapGUIToolkit\CapGUIToolkit\Desktop\CapGUI\CapGUI\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7D252ABFF6BFEEC47A3E9345CB76824B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace CapGUI {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ListBoxDragDropTarget dragDrop;
        
        internal System.Windows.Controls.StackPanel trashPanel;
        
        internal System.Windows.Controls.ListBox blockPalette;
        
        internal System.Windows.Controls.ListBox methodPalette;
        
        internal System.Windows.Controls.ListBox variablePalette;
        
        internal System.Windows.Controls.StackPanel editorPanel;
        
        internal System.Windows.Controls.ListBoxDragDropTarget editorDragDrop;
        
        internal System.Windows.Controls.ListBox editorPalette;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/CapGUI;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.dragDrop = ((System.Windows.Controls.ListBoxDragDropTarget)(this.FindName("dragDrop")));
            this.trashPanel = ((System.Windows.Controls.StackPanel)(this.FindName("trashPanel")));
            this.blockPalette = ((System.Windows.Controls.ListBox)(this.FindName("blockPalette")));
            this.methodPalette = ((System.Windows.Controls.ListBox)(this.FindName("methodPalette")));
            this.variablePalette = ((System.Windows.Controls.ListBox)(this.FindName("variablePalette")));
            this.editorPanel = ((System.Windows.Controls.StackPanel)(this.FindName("editorPanel")));
            this.editorDragDrop = ((System.Windows.Controls.ListBoxDragDropTarget)(this.FindName("editorDragDrop")));
            this.editorPalette = ((System.Windows.Controls.ListBox)(this.FindName("editorPalette")));
        }
    }
}

