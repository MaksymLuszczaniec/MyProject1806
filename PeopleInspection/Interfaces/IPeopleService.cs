using PeopleInspection.Models;
using System.Collections.Generic;

namespace PeopleInspection.Interfaces
{
    public interface IPeopleService
    {
        IEnumerable<Person> GetAllPeople();
        IEnumerable<Person> SearchPeople(string searchString);
        Person GetPersonById(int id);
        void AddPerson(Person person);
        void DeletePerson(int id);
    }
}


