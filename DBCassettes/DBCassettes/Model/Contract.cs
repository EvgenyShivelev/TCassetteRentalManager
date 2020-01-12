using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Model
{
    public class Contract
    {
        private int _contractID;
        [Key]
        public int ContractID { get => _contractID; set {} }

        public virtual Customer _customerID { get; set; }

        [ForeignKey("_customerID")]
        public int CustomerID
        { 
            get; set;
            //get => _customerID.CustomerID;
            //set { CustomerID = _customerID.CustomerID; }
        }

        public virtual Branch _branchID { get; set; }

        [ForeignKey("_branchID")]
        public int BranchID
        {
            get; set;
        }

        public DateTime DataOfContractConclusion { get; set; }
    }
}
