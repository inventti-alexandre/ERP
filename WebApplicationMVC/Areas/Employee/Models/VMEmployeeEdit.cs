using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Areas.Employee.Models
{
    public class VMEmployeeEdit
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FatherName { get; set; }

        public string BirthDay { get; set; }

        public byte[] Image { get; set; }
    }
}