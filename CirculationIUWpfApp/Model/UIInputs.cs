using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWpfApp.Model
{
    /// <summary>
    /// Class used to transport the data
    /// </summary>
    ///

    public class UIInputs
    {
        public string valuesString { get; set; } = string.Empty;

        public bool GroupOneOptionOne { get; set; } = false;
        public bool GroupOneOptionTwo { get; set; } = false;
        public bool GroupOneOptionThree { get; set; } = false;

        public bool GroupTwoOptionOne { get; set; } = false;
        public bool GroupTwoOptionTwo { get; set; } = false;


    }
}
