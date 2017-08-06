using System.Collections.Generic;

namespace bdd.Core.RepositoryInterfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
    }
}
