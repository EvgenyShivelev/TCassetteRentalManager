using DataBase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static ENUM.Enum;

namespace Model
{

    public class Cassette
    {
        [Key]
        public int CassetteID { get; set; }
        public decimal Price { get; set; }
        public int? FilmOnCassetteID { get; set; }
        [ForeignKey("FilmOnCassetteID")]
        public virtual Film FilmOnCassette { get; set; }
        public CasseteCondition CassetteCondition { get; set; }
    }
}
