using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TuikSwe.Data;
using TuikSwe.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TuikSwe.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int? id)
        {
            //filtreleme işlemleri yapılır id nullable olabilir parametre gelmezse filtreleme yapmıcaz

            var tuiks = TuikRepository.Tuiks;
            if (id!=null)
            {
                tuiks = tuiks.Where(i => i.CategoryId == id).ToList();
            }


            return View(tuiks);
        }
        public IActionResult Details(int id)
        {
            //id tek eleman olduğundan taşıyoruz.
            return View(TuikRepository.GetByID(id));
        }
        public IActionResult Contact()
        {

            return View();
        }
    }
}
