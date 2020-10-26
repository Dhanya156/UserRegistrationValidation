using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
    class Pattern
    {
        /// Starts with cap And have minimun of 3 character
        public static string REGEX_LASTNAME = "^[A-Z]+[a-z]{2,}";
       
        /// Method to find match with user input and regular expression specified
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }

    }
}
