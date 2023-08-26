using Contacts.Models;
using Contacts.ViewModels.Phones;
using Contacts.Services;
using Contacts.Filters;
using System.Web.Mvc;
using AutoMapper;
using Contacts.ViewModels.Contacts;

namespace Contacts.Controllers
{
    [Authenticate]
    public class PhonesController : Controller
    {
        // Gets contact by id if contact's user is logged in
        private Contact GetUserContact(int contactId)
        {
            //ContactRepository contactRepo = new ContactRepository();
            //Contact contact = contactRepo.GetById(contactId);
            UnitOfWork unitOfWork = new UnitOfWork();
            Contact contact = unitOfWork.ContactRepository.GetContactById(contactId);

            return contact == null || contact.UserID != AuthenticationService.LoggedUser.ID ? null : contact;
        }

        // Check if contact's user is logged in
        private bool CheckIfContactsUserIsLogged(Phone phone)
        {
            Contact contact = GetUserContact(phone.ContactID);

            return contact != null;
        }

        // INDEX

        public ActionResult Index(int? id) //contactID
        {
            if (id != null)
            {
                Contact contact = GetUserContact(id.Value);

                if (contact != null)
                {
                    PhonesListVM model = new PhonesListVM()
                    {
                        Contact = contact
                    };

                    model.Entities = model.Contact.Phones;

                    return View(model);
                }
            }

            return HttpNotFound();
        }

        public ActionResult CreateEdit(int? id, int? contactId)
        {
            if (id == null && contactId != null) // Create
            {
                Contact contact = GetUserContact(contactId.Value);

                if (contact != null)
                {
                    return View(new PhoneCreateEditVM()
                    {
                        Contact = contact
                    });
                }
            }

            if (id > 0) // Edit
            {
                //PhoneRepository phoneRepo = new PhoneRepository();
                //Phone phone = phoneRepo.GetById(id.Value);
                UnitOfWork unitOfWork = new UnitOfWork();
                Phone phone = unitOfWork.PhoneRepository.GetPhoneById(id.Value);

                if (phone != null && CheckIfContactsUserIsLogged(phone))
                {
                    var mapper = Mapper.Instance;
                    var p = mapper.Map<PhoneCreateEditVM>(phone);
                    //PhoneCreateEditVM p = new PhoneCreateEditVM()
                    //{
                    //    ID = phone.ID,
                    //    Contact = phone.Contact,
                    //    ContactID = phone.ContactID,
                    //    PhoneNumber = phone.PhoneNumber
                    //};

                    return View(p);
                }
            }

            return HttpNotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEdit(PhoneCreateEditVM model)
        {
            Contact contact = GetUserContact(model.ContactID);

            if (contact == null)
            {
                return HttpNotFound();
            }

            model.Contact = contact;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Phone phone;

            //PhoneRepository phoneRepo = new PhoneRepository();
            UnitOfWork unitOfWork = new UnitOfWork();

            if (model.ID > 0) // Edit
            {
                //phone = phoneRepo.GetById(model.ID);
                phone = unitOfWork.PhoneRepository.GetPhoneById(model.ID);

                if (phone == null || phone.ContactID != model.ContactID)
                {
                    return HttpNotFound();
                }
            }

            else // Create
            {
                phone = new Phone()
                {
                    ContactID = model.ContactID
                };
            }

            phone.PhoneNumber = model.PhoneNumber;

            //phoneRepo.Save(phone);
            unitOfWork.PhoneRepository.Save(phone);

            return RedirectToAction("Index", new { id = phone.ContactID });
        }

        public ActionResult Delete(int? id) // phoneID
        {
            if (id != null)
            {
                //PhoneRepository phoneRepo = new PhoneRepository();
                //Phone phone = phoneRepo.GetById(id.Value);
                UnitOfWork unitOfWork = new UnitOfWork();
                Phone phone = unitOfWork.PhoneRepository.GetPhoneById(id.Value);

                if (phone != null && CheckIfContactsUserIsLogged(phone))
                {
                    var mapper = Mapper.Instance;
                    var p = mapper.Map<PhoneCreateEditVM>(phone);
                    //PhoneCreateEditVM p = new PhoneCreateEditVM()
                    //{
                    //    ID = phone.ID,
                    //    Contact = phone.Contact,
                    //    PhoneNumber = phone.PhoneNumber
                    //};

                    return View(p);
                }
            }

            return HttpNotFound();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id) // phoneID
        {
            if (id != null)
            {
                //PhoneRepository phoneRepo = new PhoneRepository();
                //Phone phone = phoneRepo.GetById(id.Value);
                UnitOfWork unitOfWork = new UnitOfWork();
                Phone phone = unitOfWork.PhoneRepository.GetPhoneById(id.Value);

                if (phone != null && CheckIfContactsUserIsLogged(phone))
                {
                    //phoneRepo.Delete(phone);
                    unitOfWork.PhoneRepository.DeletePhone(phone);

                    return RedirectToAction("Index", new { id = phone.ContactID });
                }
            }

            return HttpNotFound();
        }
    }
}