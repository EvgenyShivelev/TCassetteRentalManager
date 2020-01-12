using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBase.Model
{
    public class Genre
    {
        [Key]
        public int GenreID
        {
            get => _genreID;
            set
            {
                if (value == _genreID) return;
                _genreID = value;
            }
        }
        private int _genreID;

        #region Атрибуты сущности ЖАНР
        private string _genreName;
        public string GenreName
        {
            get => _genreName;
            set {
                if (value == _genreName)
                    return;
                _genreName = value.Substring(0, 1).ToUpper() + value.ToLower().Substring(1); 
            }
        }

        private string _genreDescription;
        public string GenreDescription
        {
            get => _genreDescription;
            set {
                if (value == _genreDescription)
                    return;
                _genreDescription = value.Substring(0, 1).ToUpper() + value.ToLower().Substring(1);
            }
        }
        #endregion
    }
}
