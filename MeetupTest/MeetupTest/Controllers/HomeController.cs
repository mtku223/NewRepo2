using MeetupTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetupTest.Controllers
{
    public class HomeController : Controller
    {
        static ContactRepository _contactRepository = new ContactRepository();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            _contactRepository.AddContact(contact);
            return View("ContactList", _contactRepository.Contacts);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }

    public class ContactRepository
    {
        private List<Contact> _contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }
    }
}