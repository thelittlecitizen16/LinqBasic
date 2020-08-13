using System;
using System.Collections.Generic;
using System.Linq;
using LinqBasic.Abstract;

namespace LinqBasic
{
    class Program
    {
     

        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.PersonGender = Gender.Male;
            p1.Id = 123;

            Person p2 = new Person();
            p2.PersonGender = Gender.Male;
            p2.Id = 254;

            Person p3 = new Person();
            p3.PersonGender = Gender.Female;
            p3.Id = 500;

            List<Person> allPersons = new List<Person>() { p1, p2, p3 };
            ManageIPersonRetriver manageIPersonRetriver = new ManageIPersonRetriver();

            foreach (var malePersonnId in manageIPersonRetriver.GetMalesId(allPersons))
            {
                Console.WriteLine(malePersonnId);
            }

            foreach (var personnIds in manageIPersonRetriver.GetOddIds(allPersons))
            {
                Console.WriteLine(personnIds.Id);
            }

            foreach (var personnIds in manageIPersonRetriver.OrderById(allPersons))
            {
                Console.WriteLine(personnIds.Id);
            }
                   }
    }
}
