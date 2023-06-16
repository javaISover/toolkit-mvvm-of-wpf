﻿using MVVM_Toolkit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM_Toolkit.Views
{
    /// <summary>
    /// main.xaml 的交互逻辑
    /// </summary>
    public partial class main : Window
    {
        AddViewModel viewModel;
        public main()
        {
            InitializeComponent();
            viewModel = new AddViewModel();
            this.DataContext= viewModel;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        => viewModel.AddMethodCommand.Execute(this);
    }
}
