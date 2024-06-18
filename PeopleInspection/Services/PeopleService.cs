using PeopleInspection.Interfaces;
using PeopleInspection.Models;
using System.Collections.Generic;
using System.Linq;

namespace PeopleInspection.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepo _peopleRepo;

        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _peopleRepo.GetAllPeople();
        }

        public IEnumerable<Person> SearchPeople(string searchString)
        {
            return _peopleRepo.GetAllPeople()
                .Where(p => p.Name.Contains(searchString) || p.City.Contains(searchString));
        }

        public Person GetPersonById(int id)
        {
            return _peopleRepo.GetPersonById(id);
        }

        public void AddPerson(Person person)
        {
            _peopleRepo.AddPerson(person);
        }

        public void DeletePerson(int id)
        {
            _peopleRepo.DeletePerson(id);
        }
    }
}


