using System;

namespace LegacyApp
{
    public class User
    {
        public object Client { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public string EmailAddress { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public bool HasCreditLimit { get; internal set; }
        public int CreditLimit { get; internal set; }

        public static bool CheckCorrectnessOfBasicData(string firstName, string lastName, string email)
        {
            bool result = true;
            
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                result = false;
            }

            if (!email.Contains("@") && !email.Contains("."))
            {
                result = false;
            }

            return result;
        }

        public static bool ValidateAge(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

            return age >= 21;
        }
        
        
        
    }
}