using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataGenerator
{
    class FakeUserAccountGenerator
    {
        public string GetRandomFirstName()
        {
            Random rnd = new Random();
            int maxNames = FakeUserAccountSeedData.FirstName.Length;
            int index = rnd.Next(maxNames);
            return (FakeUserAccountSeedData.FirstName[index]);
        }
        public string GetRandomLastName()
        {
            Random rnd = new Random();
            int maxNames = FakeUserAccountSeedData.LastName.Length;
            int index = rnd.Next(maxNames);
            return (FakeUserAccountSeedData.LastName[index]);
        }
    }
}
