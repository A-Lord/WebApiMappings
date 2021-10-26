using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMappings.Managers;

namespace WebApiMappings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        [HttpGet("{personId}")]
        public Person GetPerson(int personId)
        {
            var getPList = PersonManager.Instance;
            var Persons = getPList.List();
            for (int i = 0; i < Persons.Count; i++)
            {
                if (Persons[i].Id == personId)
                {
                    return Persons[i];
                    
                }
            }
            return null;
        }
        [HttpGet]
        public List<Person> ListPerson()
        {
            var personManage = PersonManager.Instance;
            return personManage.List();

            
        }
        [HttpPost]
        public bool CreatePerson([FromBody] Person test)
        {
            Persons.Add(test);
            return true;
        }

            

        
    }
}
