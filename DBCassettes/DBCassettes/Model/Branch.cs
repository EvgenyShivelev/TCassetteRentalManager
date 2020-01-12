using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBase.Model
{

    public class Branch
    {
        private string _branchName;
        private Address _branchAddress;
        private int branchID;

        [Key]
        public int BranchID
        {
            get => branchID;
            set
            {
                if (value == branchID) return;
                branchID = value;
            }
        }

        public Address BranchAddress
        {
            get => _branchAddress;
            set
            {
                if (value == _branchAddress) return;
                _branchAddress = value;
            }
        }

        public string BranchName
        {
            get => _branchName;
            set
            {
                if (value == _branchName) return;
                _branchName = value;
            }
        }

    }
}
