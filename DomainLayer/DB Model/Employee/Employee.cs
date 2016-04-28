using System;
using System.Collections.Generic;
using System.ComponentModel;
using DomainLayer.DB_Model.Authentication;
using DomainLayer.DB_Model.General;
using Type = DomainLayer.DB_Model.General.Type;

namespace DomainLayer.DB_Model.Employee
{
    

    public class Employee:ShareField
    {
        

        #region Relation

        public virtual ApplicationUser AppUser { get; set; }
        public virtual ICollection<EmployeeChart.EmployeeChart> Charts { get; set; }

        public Type Type { get; set; }

        #endregion Relation

        #region Feild

        public Guid AppUserId { get; set; }

        public string NationalId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

      


        public string FatherName { get; set; }

        public string BirthDay { get; set; }


     
        public byte[] Picture { get; set; }



        #endregion Feild

        [DisplayName("نام و نام خانوادگی")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}