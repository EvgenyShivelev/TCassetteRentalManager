using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBase.Model
{
    public class Address
    {
        [StringLength(2)]
        private string state;
        [StringLength(16)]
        private string street;
        [StringLength(16)]
        private string city;

        private int addressIndex;
        [Key]
        public int AddressIndex {
            get => addressIndex;
            set {}
        }

        private string State
        {
            get => state;
            set
            {
                if (value == state) return;
                state = value;
            }
        }

        private string Street
        {
            get => street;
            set
            {
                street = value.Substring(0, 1).ToUpper() + value.ToLower().Substring(1);
            }
        }

    }
}
