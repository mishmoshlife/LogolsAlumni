using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogolsAlumni.Domain;
using LogolsAlumni.Entities;

namespace LogolsAlumni.web.Controllers
{
    [Route("api/[controller]")]
    public class AlumniController : Controller
    {
        AlumniService _service;

        public AlumniController()
        {
            _service = new AlumniService();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Alumni> Get()
        {
            return _service.GetAll();
        }

      

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Alumni alumni)
        {
            _service.Insert(alumni);
        }

       

        
    }
}

