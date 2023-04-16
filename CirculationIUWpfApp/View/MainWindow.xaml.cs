using System.Windows;
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
            _viewModel.GroupOneOptionOne=true;
            _viewModel.GroupOneOptionTwo=false;
            _viewModel.GroupOneOptionThree=false;

            _viewModel.Update();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            _viewModel.GroupOneOptionOne=false;
            _viewModel.GroupOneOptionTwo = true;
            _viewModel.GroupOneOptionThree=false;

            _viewModel.Update();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            _viewModel.GroupOneOptionOne=false;
            _viewModel.GroupOneOptionTwo=false;
            _viewModel.GroupOneOptionThree = true;

            _viewModel.Update();
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            _viewModel.GroupTwoOptionOne = true;
            _viewModel.GroupTwoOptionTwo = false;

            _viewModel.Update();
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            _viewModel.GroupTwoOptionOne = false;
            _viewModel.GroupTwoOptionTwo = true;

            _viewModel.Update();
        }
    }
}
