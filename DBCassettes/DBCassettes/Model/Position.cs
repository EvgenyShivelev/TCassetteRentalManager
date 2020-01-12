using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBase.Model
{
    public class Position
    {
        private int _positionID;
        private string _positionName;

        public string PositionName
        {
            get => _positionName;
            set
            {
                if (value == _positionName) return;
                _positionName = value;
            }
        }
        [Key]
        public int PositionID
        {
            get => _positionID;
            set
            {
                if (value == _positionID) return;
                _positionID = value;
            }
        }

    }
}
