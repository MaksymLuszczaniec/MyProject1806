using PeopleInspection.Models;
using System.Collections.Generic;

namespace PeopleInspection.ViewModels
{
    public class SearchViewModel
    {
        public string SearchString { get; set; }
        public List<Person> People { get; set; }
    }
}
