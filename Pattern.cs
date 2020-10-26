using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
    class Pattern
    {
        ///Email has 3 mandatory parts (abc, bl& co) and 2 optional(xyz & in) with precise @ and.positions
        public static string REGEX_EMAIL = "^[a-z]+[0-9]*([-_+.][0-9a-z]+)*@[0-9a-z]+[.][a-z]{2,4}([,]{1})*([.][a-z]{2})*$";

        /// Method to find match with user input and regular expression specified
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }

    }
}
