using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataGenerator
{
    public class FakeUserAccount
    {
        public string FirstName { get; set; }
        public string FirstMiddle { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PasswordHashed { get; set; }
        public DateTime AccountCreationDT { get; set; }
        public DateTime LastPasswordChangeDT { get; set; }
        public string[] PreviousPasswords { get; set; }
        public string[] PreviousPasswordsHashed { get; set; }
    }
}
