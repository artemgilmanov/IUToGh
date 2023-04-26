using System;
using System.Collections.Generic;
using System.Windows.Documents;
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

        private int _valueOne;
        private int _valueTwo;
        private int _valueThree;
        private int _valueFour;
        private int _valueFive;
        private string _valuesString = string.Empty;

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

        public int ValueOne
        {
            get => UIInputs.ValueOne;
            set
            {
                _valueOne = value;
                OnPropertyChanged("ValueOne");
            }
        }
        public int ValueTwo
        {
            get => UIInputs.ValueTwo;
            set
            {
                _valueTwo = value;
                OnPropertyChanged("ValueTwo");
            }
        }
        public int ValueThree
        {
            get => UIInputs.ValueThree;
            set
            {
                _valueThree = value;
                OnPropertyChanged("ValueThree");
            }
        }

        public int ValueFour
        {
            get => UIInputs.ValueFour;
            set
            {
                _valueFour = value;
                OnPropertyChanged("ValueFour");
            }
        }

        public int ValueFive
        {
            get => UIInputs.ValueFive;
            set
            {
                _valueFive = value;
                OnPropertyChanged("ValueFive");
            }
        }

        public string ValuesString
        {
            get => _valuesString;
            set
            {
                _valuesString = value;
                OnPropertyChanged("ValuesString");
            }
        }

        public void GenerateValuesString()
        {
            var valuesList = new List<int> { ValueOne, ValueTwo, ValueThree, ValueFour, ValueFive };
            ValuesString = String.Join("-", valuesList);

        }

        public void UpdateDefinition(Action a)
        {
            Update = a;
        }

    }
}
