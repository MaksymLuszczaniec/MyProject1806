using PeopleInspection.Models;
using System.Collections.Generic;

namespace PeopleInspection.ViewModels
{
    public class SearchViewModel
    {
        public string SearchString { get; set; } = string.Empty;
        public List<Person> People { get; set; } = new List<Person>();
    }
}
