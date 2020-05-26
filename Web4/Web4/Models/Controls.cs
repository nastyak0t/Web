using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Controls
    {
        public string TextBox { get; set; } = null;
        public string TextArea { get; set; } = null;
        public bool? CheckBox { get; set; } = null;
        public string Radio { get; set; } = null;
        public string DropDownList { get; set; } = null;
        public string ListBox { get; set; } = null;
        
        public Controls(string result, int rightAnswers, int answersc)
        {

        }

        public Controls()
        {

        }
    }
}
