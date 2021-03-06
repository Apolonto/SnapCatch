﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using SnapCatch.Processing;

namespace SnapCatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        // minimize to system tray when applicaiton is minimized
        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
            {
                this.Hide();
            }

            base.OnStateChanged(e);
        }

        // minimize to system tray when applicaiton is closed
        protected override void OnClosing(CancelEventArgs e)
        {
            // setting cancel to true will cancel the close request
            // so the application is not closed
            if (Properties.Settings.Default.HideInTrayOnClose)
            {
                e.Cancel = true;
                Hide();
            }

            base.OnClosing(e);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainCanvasDisplay_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void MainCanvasDisplay_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}

