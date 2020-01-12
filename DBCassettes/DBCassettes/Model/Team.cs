using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBase.Model
{
    public class Team
    {
        private int filmID;
        
        [Key]
        public int FilmID {
            get => filmID;
            set {
                if (value == filmID) return;
                filmID = _FilmID.FilmID;
            }
        }
        public virtual Film _FilmID { get; set; }
    }

    public class ActorsTeam: Team
    {
        public Person Id { get; set; }
    }

    public class DirectorsTeam : Team
    {
        public Person Id { get; set; }
    }

}
