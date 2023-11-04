using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ContactManager contactManager = new ContactManager(new EfContactDal());
            var values = contactManager.TGetList();
            return View(values);  
        }
    }
}
