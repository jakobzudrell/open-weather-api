﻿using System.Windows;

namespace OpenWeatherAPI.Playground.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Bind to the mainviewmodel
            DataContext = new MainViewModel();
        }
    }
}
