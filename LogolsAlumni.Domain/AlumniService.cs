using System;
using System.Collections.Generic;
using System.Text;
using LogolsAlumni.DAL;
using LogolsAlumni.Entities;

namespace LogolsAlumni.Domain
{
    public class AlumniService
    {
        private AlumniRepository _repository;

        public AlumniService()
        {
            _repository = new AlumniRepository();
        }

        public int Insert(Alumni alumni)
        {
            return _repository.Insert(alumni);
        }

       

        public IEnumerable<Alumni> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
