using System;
using System.IO;
using System.Windows;
namespace CounterMVVM
{
    public partial class MainWindow : Window
    {
        public CounterViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new CounterViewModel();
        }

        private void WindowClosing(object sender, EventArgs e)
        {
            var viewModel = (CounterViewModel)this.DataContext;
            File.WriteAllText("result.txt", Convert.ToString(viewModel.CounterValue));
        }
    }
}