using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactListAPI_MVC.Services;
using ContactListAPI_MVC.Models;

namespace ContactListAPI_MVC.Controllers
{
    public class ContactController : Controller
    {
        private IContactRepository contactRepository;


        public ContactController(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person newPerson)
        {

            if (newPerson == null)
            {
                return BadRequest();
            }
            newPerson.id = this.contactRepository.GetLast().id + 1;
            this.contactRepository.AddPerson(newPerson);
            return RedirectToAction("Index");
        }
        
        public IActionResult Index()
        {
            return View(contactRepository.GetAll());
        }

        public IActionResult Delete(int id)
        {
            var pers = contactRepository.GetById(id);
            if (pers == null)
            {
                return NotFound();
            }

            return View(pers);
        }

        public IActionResult DeleteConfirmed(int id)
        {
            contactRepository.DeleteById(id);
            return RedirectToAction("Index");
        }
        
        public IActionResult FindByName(string search)
        {
            if (!String.IsNullOrEmpty(search)) {
                return View(this.contactRepository.GetWhereContains(search));
            }
            else
            {
                return View(this.contactRepository.GetAll());
            }                       
        }
    }
}