using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_DataBinding
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

    }
}
