using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBase.Model
{
    public class CasseteRent
    {
        private DateTime dateOfReceived { get; set; }
        private DateTime dateOfReturn { get; set; }
        private DateTime dateOfNOWRet { get; set; }

        private int penalty;
        public int Penalty { get => penalty; set { penalty = value; } }

        public int CassetteID
        {
            get => Cassete.CassetteID;
            set { return; }
        }
        public int ContractID
        {
            get => Contract.ContractID;
            set { return; }
        }

        private Cassette _cassette;
        private Contract _contract;
        public Cassette Cassete
        {
            get => _cassette;
            set
            {
                if (value == _cassette) return;
                _cassette = value;
            }
        }
        public Contract Contract 
        { 
            get => _contract;
            set {
                    if (value == _contract) return;
                   _contract = value;
                } 
        }
    }
}
