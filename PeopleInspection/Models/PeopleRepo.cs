using PeopleInspection.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PeopleInspection.Models
{
    public class PeopleRepo : IPeopleRepo
    {
        private readonly List<Person> _people;

        public PeopleRepo()
        {
            _people = new List<Person>
            {
                new Person { Id = 1, Name = "John Doe", City = "New York" },
                new Person { Id = 2, Name = "Jane Smith", City = "Los Angeles" },
                new Person { Id = 3, Name = "Maksym Lusz", City = "Växjö" },
                new Person { Id = 4, Name = "Adam Wasilewski", City = "Wroclaw" }
            };
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _people;
        }

        public Person GetPersonById(int id)
        {
            return _people.FirstOrDefault(p => p.Id == id)!;
        }

        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        public void DeletePerson(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person != null)
            {
                _people.Remove(person);
            }
        }
    }
}


