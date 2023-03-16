using System.Globalization;

namespace ReflectionLib
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int BirthOfYear { get; set; }

        public int Age {
            get
            {
                return DateTime.Now.Year - BirthOfYear;
            }
        }

        public Person(string name, int birthOfYear) {
            
            Name= name;
            BirthOfYear= birthOfYear;
            _ = Age;

        }


       
    }





}