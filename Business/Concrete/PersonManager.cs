﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Boş class kalmasın
    public class PersonManager :IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            return true;
        }
        public bool CheckPerson(Person person)
        {
          
        }

    }
}
