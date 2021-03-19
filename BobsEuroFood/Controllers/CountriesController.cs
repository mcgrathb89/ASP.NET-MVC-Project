using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BobsEuroFood.Models;
using BobsEuroFood.ViewModels;

namespace BobsEuroFood.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        public ActionResult CountriesList()
        {
            var countries = new List<Country>
            {
                new Country() {Name = "Spain"},
                new Country() {Name = "Finland"},
                new Country() {Name = "Greece"},
                new Country() {Name = "Estonia"},
                new Country() {Name = "Georgia"},
                new Country() {Name = "Russia"},
                new Country() {Name = "Ukraine"},
                new Country() {Name = "France"},
                new Country() {Name = "Sweden"},
                new Country() {Name = "Norway"},
                new Country() {Name = "Germany"},
                new Country() {Name = "Poland"},
                new Country() {Name = "Italy"},
                new Country() {Name = "England"},
                new Country() {Name = "Scotland"},
                new Country() {Name = "Wales"},
                new Country() {Name = "Ireland"},
                new Country() {Name = "Northern_Ireland"},
                new Country() {Name = "Romania"},
                new Country() {Name = "Belarus"},
                new Country() {Name = "Kazakhstan"},
                new Country() {Name = "Bulgaria"},
                new Country() {Name = "Iceland"},
                new Country() {Name = "Hungary"},
                new Country() {Name = "Portugal"},
                new Country() {Name = "Austria"},
                new Country() {Name = "Czech_Republic"},
                new Country() {Name = "Serbia"},
                new Country() {Name = "Lithuania"},
                new Country() {Name = "Latvia"},
                new Country() {Name = "Croatia"},
                new Country() {Name = "Bosnia_and_Herzegovina"},
                new Country() {Name = "Albania"},
                new Country() {Name = "Slovakia"},
                new Country() {Name = "Denmark"},
                new Country() {Name = "Switzerland"},
                new Country() {Name = "Netherlands"},
                new Country() {Name = "Moldova"},
                new Country() {Name = "Belgium"},
                new Country() {Name = "Armenia"},
                new Country() {Name = "North_Macedonia"},
                new Country() {Name = "Turkey"},
                new Country() {Name = "Slovenia"},
                new Country() {Name = "Montenegro"},
                new Country() {Name = "Kosovo"},
                new Country() {Name = "Azerbaijan"},
                new Country() {Name = "Cyprus"},
                new Country() {Name = "Luxembourg"},
                new Country() {Name = "Andorra"},
                new Country() {Name = "Malta"},
                new Country() {Name = "Liechtenstein"},
                new Country() {Name = "San_Marino"},
            };

            var sortedCountriesList = countries.OrderBy(country => country.Name).ToList();

            var viewModel = new CountryViewModel()
            {
                Countries = sortedCountriesList
            };

            return View(viewModel);
        }
    }
}