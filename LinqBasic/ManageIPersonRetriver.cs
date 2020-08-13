using LinqBasic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqBasic
{
    class ManageIPersonRetriver : IPersonRetriver
    {
        public IEnumerable<int> GetMalesId(IEnumerable<Person> persons)
        {
            return persons.Where(p => p.PersonGender == Gender.Male)
                .Select(i => i.Id).ToList();
        }


        public IEnumerable<Person> GetOddIds(IEnumerable<Person> persons)
        {
            return persons.OrderByDescending(p => p.Id).ToList();
        }

        public IEnumerable<Person> OrderById(IEnumerable<Person> persons)
        {
            return persons.Where(p => p.Id % 2 == 0).ToList();
        }
    }
}
