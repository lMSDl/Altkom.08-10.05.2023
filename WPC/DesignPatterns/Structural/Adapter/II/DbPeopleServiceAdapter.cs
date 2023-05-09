using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.II
{
    internal class DbPeopleServiceAdapter : IPeopleService
    {
        private readonly DbPeopleService _peopleService;

        public DbPeopleServiceAdapter(DbPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = _peopleService.Read();

            return people.Select(p => new Person { Name = $"{p.FirstName} {p.LastName}", Age = DateTime.Now.Year - p.BirthDate.Year });
        }
    }
}
