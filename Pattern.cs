using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
    class Pattern
    {
        /// Starts with cap And have minimun of 3 character
        public static string REGEX_FIRSTNAME = "^[A-Z]+[a-z]{2,}";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }

    }
}
