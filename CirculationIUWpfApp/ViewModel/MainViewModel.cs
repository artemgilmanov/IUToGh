using System;
using UIWpfApp.Model;

namespace UIWpfApp.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        private bool _groupOneOptionOne;
        private bool _groupOneOptionTwo;
        private bool _groupOneOptionThree;

        private bool _groupTwoOptionOne;
        private bool _groupTwoOptionTwo;

        public Action Update;

        public UIInputs UIInputs { get; }

        public MainViewModel()
        {
            UIInputs = new UIInputs();
        }

        public bool GroupOneOptionOne
        {
            get => _groupOneOptionOne;
            set
            {
                _groupOneOptionOne = value;
                OnPropertyChanged("GroupOneOptionOne");
            }
        }
        public bool GroupOneOptionTwo
        {
            get => _groupOneOptionTwo;
            set
            {
                _groupOneOptionTwo = value;
                OnPropertyChanged("GroupOneOptionTwo");
            }
        }
        public bool GroupOneOptionThree
        {
            get => _groupOneOptionThree;
            set
            {
                _groupOneOptionThree = value;
                OnPropertyChanged("GroupOneOptionThree");
            }
        }

        public bool GroupTwoOptionOne
        {
            get => _groupTwoOptionOne;
            set
            {
                _groupTwoOptionOne = value;
                OnPropertyChanged("GroupTwoOptionOne");
            }
        }
        public bool GroupTwoOptionTwo
        {
            get => _groupTwoOptionTwo;
            set
            {
                _groupTwoOptionTwo = value;
                OnPropertyChanged("GroupTwoOptionTwo");
            }
        }

        public void UpdateDefinition(Action a)
        {
            Update = a;
        }

    }
}
