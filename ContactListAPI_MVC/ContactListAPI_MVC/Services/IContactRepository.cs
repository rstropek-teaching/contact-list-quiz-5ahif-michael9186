using ContactListAPI_MVC.Models;
using System.Collections.Generic;

namespace ContactListAPI_MVC.Services
{
    public interface IContactRepository
    {
        void AddPerson(Person p);
        IEnumerable<Person> GetAll();
        bool DeleteById(int id);
        Person GetById(int id);
        IEnumerable<Person> FindByName(string name);
        Person GetLast();
        IEnumerable<Person> GetWhereContains(string search);
    }
}
