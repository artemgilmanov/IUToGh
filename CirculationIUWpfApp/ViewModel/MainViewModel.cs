using System;
using UIWpfApp.Model;

namespace UIWpfApp.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        private bool _optionOne;
        private bool _optionTwo;
        private bool _optionThree;

        public Action Update;

        public UIInputs UIInputs { get; }

        public MainViewModel()
        {
            UIInputs = new UIInputs();
        }

        public bool OptionOne
        {
            get => _optionOne;
            set
            {
                _optionOne = value;
                OnPropertyChanged("OptionOne");
            }
        }

        public bool OptionTwo
        {
            get => _optionTwo;
            set
            {
                _optionTwo = value;
                OnPropertyChanged("OptionTwo");
            }
        }

        public bool OptionThree
        {
            get => _optionThree;
            set
            {
                _optionThree = value;
                OnPropertyChanged("OptionThree");
            }
        }

        public void UpdateDefinition(Action a)
        {
            Update = a;
        }

    }
}
