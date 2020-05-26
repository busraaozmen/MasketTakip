using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Business.Concrete
{
    public class PttManager : ISuppleirService
    {
       
        private IApplicantService _applicantService;  //Global alana aatmamız gerek.

        public PttManager(IApplicantService applicantService)  //Constructor ctor new yazıldığında çalışır
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
        }
    }
}
