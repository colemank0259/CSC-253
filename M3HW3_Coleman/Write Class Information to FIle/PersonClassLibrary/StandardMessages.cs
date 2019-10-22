using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassLibrary
{
    public class StandardMessages
    {
        public string PromptInfo
        {
            get
            {
                return "This program wil take user input to make a class, " +
                    "then takes the class info and creates a file named UserInformation.";
            }
        }

        public string PromptFirstName
        {
            get
            {
                return "Enter first name > ";
            }
        }

        public string PromptLastName
        {
            get
            {
                return "Enter last name > ";
            }
        }

        public string PromptAge
        {
            get
            {
                return "Enter age > ";
            }
        }

        public string PromptFileComplete
        {
            get
            {
                return "The information has been written to the file.";
            }
        }
    }
}
