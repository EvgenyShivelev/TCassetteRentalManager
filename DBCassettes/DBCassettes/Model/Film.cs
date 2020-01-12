using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Model
{
    public class Film
    {
        #region ID-Фильма
        private int _filmID;
        [Key]
        public int FilmID { get => _filmID; set { _filmID = value; } }
        #endregion

        #region Атрибуты сущности Фильм
        [Column(TypeName = "image")]
        public byte[] FilmImage { get; set; }
        private string _filmName;
        public string FilmName 
        { 
            get => _filmName; set {  _filmName = value.Substring(0, 1).ToUpper() + value.ToLower().Substring(1); } 
        }
        public int? FilmGenreID { get; set; }
        [ForeignKey("FilmGenreID")]
        public virtual Genre FilmGenre
        {
            get; set;
        }
        public virtual ICollection<ActorsTeam> ActorsTeams { get; set; }
        public virtual ICollection<DirectorsTeam> DirectorsTeams { get; set; }
        #endregion
    }
}
