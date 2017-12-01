﻿using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace SnapCatch.Logic.Drawing
{
    /// <summary>
    /// Interaction logic for DrawingLayer.xaml
    /// </summary>
    public partial class DrawingLayer : UserControl
    {
        public DrawingLayer()
        {
            InitializeComponent();
        }

        public void AddItem(MovingThumb canvasItem)
        {
            CanvasDisplay.Children.Add(canvasItem);

        }

    }
}