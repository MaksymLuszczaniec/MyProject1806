using PeopleInspection.Models;
using System.Collections.Generic;

namespace PeopleInspection.Interfaces
{
    public interface IPeopleRepo
    {
        IEnumerable<Person> GetAllPeople();
        Person GetPersonById(int id);
        void AddPerson(Person person);
        void DeletePerson(int id);
    }
}

