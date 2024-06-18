using Microsoft.AspNetCore.Mvc;
using PeopleInspection.Interfaces;
using PeopleInspection.Models;
using PeopleInspection.ViewModels;

namespace PeopleInspection.Controllers
{
    public class PeopleInspectionController : Controller
    {
        private readonly IPeopleService _peopleService;

        public PeopleInspectionController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public IActionResult Index(string searchString)
        {
            var viewModel = new SearchViewModel
            {
                SearchString = searchString,
                People = string.IsNullOrEmpty(searchString)
                    ? _peopleService.GetAllPeople().ToList()
                    : _peopleService.SearchPeople(searchString).ToList()
            };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var person = _peopleService.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreatePersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                var person = new Person
                {
                    Name = model.Name,
                    City = model.City
                };
                _peopleService.AddPerson(person);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _peopleService.DeletePerson(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
