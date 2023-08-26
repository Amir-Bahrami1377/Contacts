using Contacts.Models;
using PagedList;
using Contacts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Routing;
using Contacts.ViewModels.Contacts;
using Contacts.Filters;
using AutoMapper;

namespace Contacts.Controllers
{
    [Authenticate]
    public class ContactsController : Controller
    {
        public ActionResult Index()
        {
            ContactsListVM model = new ContactsListVM();

            TryUpdateModel(model);
            UnitOfWork unitOfWork = new UnitOfWork();

            //ContactRepository contactRepo = new ContactRepository();

            User user = AuthenticationService.LoggedUser;

            Expression<Func<Contact, bool>> filter = null;

            if (!string.IsNullOrEmpty(model.SearchString)) // With Searching
            {
                string[] searchArray = model.SearchString.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                filter = c => (c.UserID == user.ID) && (searchArray.Any(word => c.FirstName.Contains(word))
                                                     || searchArray.Any(word => c.LastName.Contains(word))
                                                     || searchArray.Any(word => c.Email.Contains(word)));
            }

            else // Without Searching
            {
                filter = c => c.UserID == user.ID;
            }

            //model.Entities = contactRepo.GetAll(filter);
            model.Entities = unitOfWork.ContactRepository.GetAllContacts(filter);
            // Paging

            int pageSize = 2;
            int pageNumber = (model.Page ?? 1);

            model.PagedContacts = new PagedList<Contact>(model.Entities, pageNumber, pageSize);

            return View(model);
        }

        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                //ContactRepository contactRepo = new ContactRepository();

                //Contact contact = contactRepo.GetById(id.Value);
                Contact contact = unitOfWork.ContactRepository.GetContactById(id.Value);

                if (contact != null && contact.UserID == AuthenticationService.LoggedUser.ID)
                {
                    var mapper = Mapper.Instance;
                    var model = mapper.Map<ContactCreateEditVM>(contact);
                    //ContactCreateEditVM model = new ContactCreateEditVM()
                    //{
                    //    ID = contact.ID,
                    //    FirstName = contact.FirstName,
                    //    LastName = contact.LastName,
                    //    Email = contact.Email
                    //};
                    return View(model);
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult CreateEdit(int? id)
        {
            if (id == null) // Create
            {
                ContactCreateEditVM model = new ContactCreateEditVM()
                {
                    UserID = AuthenticationService.LoggedUser.ID
                };
                return View(model);
            }

            if (id > 0) // Edit
            {
                //ContactRepository contactRepo = new ContactRepository();

                //Contact contact = contactRepo.GetById(id.Value);
                UnitOfWork unitOfWork = new UnitOfWork();
                Contact contact = unitOfWork.ContactRepository.GetContactById(id.Value);

                if (contact != null && contact.UserID == AuthenticationService.LoggedUser.ID)
                {
                    var mapper = Mapper.Instance;
                    var model = mapper.Map<ContactCreateEditVM>(contact);
                    //ContactCreateEditVM model = new ContactCreateEditVM()
                    //{
                    //    ID = contact.ID,
                    //    UserID = contact.UserID,
                    //    FirstName = contact.FirstName,
                    //    LastName = contact.LastName,
                    //    Email = contact.Email
                    //};
                    return View(model);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEdit(ContactCreateEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Contact contact;

            //ContactRepository contactRepo = new ContactRepository();
            UnitOfWork unitOfWork = new UnitOfWork();

            if (model.ID > 0) // Edit
            {
                //contact = contactRepo.GetById(model.ID);
                contact = unitOfWork.ContactRepository.GetContactById(model.ID);

                if (contact == null || contact.UserID != model.UserID)
                {
                    unitOfWork.Dispose();
                    return HttpNotFound();
                }
            }

            else // Create
            {
                contact = new Contact()
                {
                    UserID = model.UserID,
                };
            }

            if (contact.UserID == AuthenticationService.LoggedUser.ID)
            {
                contact.FirstName = model.FirstName;
                contact.LastName = model.LastName;
                contact.Email = model.Email;

                //contactRepo.Save(contact);
                unitOfWork.ContactRepository.Save(contact);
                unitOfWork.Dispose();

                return RedirectToAction("Index");
            }

            return HttpNotFound();
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                //ContactRepository contactRepo = new ContactRepository();
                //Contact contact = contactRepo.GetById(id.Value);
                UnitOfWork unitOfWork = new UnitOfWork();
                Contact contact = unitOfWork.ContactRepository.GetContactById(id.Value);

                if (contact != null && contact.UserID == AuthenticationService.LoggedUser.ID)
                {
                    var mapper = Mapper.Instance;
                    var model = mapper.Map<ContactCreateEditVM>(contact);
                    //ContactCreateEditVM model = new ContactCreateEditVM()
                    //{
                    //    ID = contact.ID,
                    //    FirstName = contact.FirstName,
                    //    LastName = contact.LastName,
                    //    Email = contact.Email
                    //};
                    return View(model);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id != null)
            {
                //ContactRepository contactRepo = new ContactRepository();
                //Contact contact = contactRepo.GetById(id.Value);
                UnitOfWork unitOfWork = new UnitOfWork();
                Contact contact = unitOfWork.ContactRepository.GetContactById(id.Value);

                if (contact != null && contact.UserID == AuthenticationService.LoggedUser.ID)
                {
                    unitOfWork.ContactRepository.DeleteContact(contact);
                    return RedirectToAction("Index");
                }
            }

            return HttpNotFound();
        }
    }
}
