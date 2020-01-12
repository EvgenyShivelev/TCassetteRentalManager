using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Model
{
    public class Person
    {
        private string _firstName;
        private string _secondName;
        private string _lastName;
        
        [Key]
        public int PersonID { get; set; }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value.Substring(0, 1).ToUpper() + value.ToLower().Substring(1);
            }
        }
        public string SecondName
        {
            get => _secondName;
            set
            {
                _secondName = value.Substring(0, 1).ToUpper() + value.ToLower().Substring(1);
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value.Substring(0, 1).ToUpper() + value.ToLower().Substring(1);
            }
        }

    }
   
    public class Employee
    {
        [Key]
        [ForeignKey("_person")]
        public int EmployeeID { get; set; }
        public virtual Person _person { get; set; }
        public Position EmployeePost { get; set; }
        public Branch Branch { get; set; } 
    }

    public class Customer
    {
        [Key]
        [ForeignKey("_person")]
        public int CustomerID { get; set; }
        public virtual Person _person { get; set; }
    }
}
