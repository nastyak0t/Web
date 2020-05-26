using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class MultyStaged
    {
        public int SignUp_Stage = 0;
        public string Email = null;
        public string Password = null;
        public bool? Remember = null;
        public string FirstName = null;
        public string SecondName = null;
        public string Birthday = null;
        public string Gender = null;

        public int ResetPassword_Stage = 0;

        public MultyStaged()
        {

        }
    }
}
