using Microsoft.AspNetCore.Mvc;

namespace Demo01.Controllers
{
    public class ContactsController : Controller
    {
        // /Contacts/ => possible grâce au app.MapControllerRoute("default",....)
        // /Contacts/Index
        public string Index()
        {
            return "Je suis la page pour afficher les contacts";
        }

        // /Contacts/Details/4
        public string Details(int id=0)
        {
            return $"Je suis la page pour afficher le contact n°{id} en détail....";
        }

        // /Contacts/Create
        public string Create()
        {
            return "Je suis la page pour créer un contact";
        }
    }
}
