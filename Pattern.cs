using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
    class Pattern
    {
        ///Country code follow by space and 10 digit number
        public static string REGEX_PHONENUMBER = "^\\\\+(?:[0-9] ?){6,14}[0-9]$";

        /// Method to find match with user input and regular expression specified
        public bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, REGEX_PHONENUMBER);
        }

    }
}
