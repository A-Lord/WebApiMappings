using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMappings.Managers
{
    public class PersonManager
    {
        private List<Person> _persons = new List<Person>();
        private static PersonManager _instance;
        public static PersonManager Instance { 
            get {
                if (_instance == null)
                {
                    _instance = new PersonManager();
                }
                    return _instance; } }
        private PersonManager()
        {

        }
        public List<Person> List()
        {
            return _persons;
        }
    }
}
