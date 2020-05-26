using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //interfce / arayüz 

    public interface IApplicantService
    {
        //Bu yönteme methodun imzası denir.
        void ApplyForMask(Person person);

        List<Person> GetList();


        bool CheckPerson(Person person);
       
    }
}
