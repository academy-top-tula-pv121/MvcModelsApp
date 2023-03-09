using Microsoft.AspNetCore.Mvc;
using MvcModelsApp.Models;
using MvcModelsApp.Models.ViewModels;
using System.Diagnostics;

namespace MvcModelsApp.Controllers
{
    public class HomeController : Controller
    {
        List<User> users = new()
        {
            new(1, "Bob", 27),
            new(2, "Joe", 31),
            new(3, "Leo", 19),
            new(4, "Jim", 24),
            new(5, "Sam", 36),
        };

        List<Company> companies = new List<Company>();
        List<Employe> employes;

        public HomeController()
        {
            companies.Add(new Company() { Id = 1, Title = "Yandex", Country = "Russia" });
            companies.Add(new Company() { Id = 2, Title = "Ozon", Country = "Russia" });
            companies.Add(new Company() { Id = 3, Title = "Mail Group", Country = "Russia" });

            employes = new List<Employe>()
            {
                new Employe(){ Id = 1, Name = "Bob", Age = 23, Company = companies[0]},
                new Employe(){ Id = 2, Name = "Joe", Age = 43, Company = companies[1]},
                new Employe(){ Id = 3, Name = "Leo", Age = 28, Company = companies[2]},
                new Employe(){ Id = 4, Name = "Bill", Age = 32, Company = companies[0]},
                new Employe(){ Id = 5, Name = "Tom", Age = 27, Company = companies[1]},
                new Employe(){ Id = 6, Name = "Jim", Age = 21, Company = companies[2]},
                new Employe(){ Id = 7, Name = "Tim", Age = 41, Company = companies[1]},
                new Employe(){ Id = 8, Name = "Sam", Age = 29, Company = companies[2]},
                new Employe(){ Id = 9, Name = "Ken", Age = 37, Company = companies[2]},
            };
        }

        public IActionResult Index()
        {
            return View(users);
        }

        public IActionResult Employes(int? companyId)
        {
            List<CompanyModel> companyModels = companies.Select(
                c => new CompanyModel() { Id = c.Id, Title = c.Title })
                                                        .ToList();
            companyModels.Insert(0, new CompanyModel() 
                                { Id = 0, Title = "All Companies" });

            ComplexModel complexModel = new() { Companies = companyModels, Employes = employes };

            if(companyId is not null && companyId > 0)
                complexModel.Employes = employes.Where(e => e.Company?.Id == companyId).ToList();

            return View(complexModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}