using bdd.Core.RepositoryInterfaces;
using System.Web.Mvc;

namespace bdd.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        /// <summary>Get Person Index</summary>
        public ActionResult Index()
        {
            var persons = _personRepository.GetPersons();
            return View(persons);
        }
    }
}