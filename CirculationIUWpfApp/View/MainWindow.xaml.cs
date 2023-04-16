using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UIWpfApp.Model;
using UIWpfApp.ViewModel;

namespace UIWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            this.DataContext = _viewModel;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _viewModel.OptionOne=true;
            _viewModel.OptionTwo=false;
            _viewModel.OptionThree=false;

            _viewModel.Update();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            _viewModel.OptionOne=false;
            _viewModel.OptionTwo = true;
            _viewModel.OptionThree=false;

            _viewModel.Update();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            _viewModel.OptionOne=false;
            _viewModel.OptionTwo=false;
            _viewModel.OptionThree = true;
            _viewModel.Update();
        }
    }
}
