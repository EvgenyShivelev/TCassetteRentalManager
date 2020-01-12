using API;
using DataBase.Model;
using DBCassettes.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ViewModel
{
    public class AddGenreDialogViewModel: BaseDialogPage
    {

        #region Репозиторий
        private Repository<Genre> _genreRepository;
        #endregion

        public AddGenreDialogViewModel(Window rootWindow) : base(rootWindow)
        {
            _genreRepository = new Repository<Genre>(new EDBContext());
            AddGenreToDataBaseCommand = new Command(AddGenreToDataBaseAction);
        }

        #region Commands
        public ICommand AddGenreToDataBaseCommand { get; private set; }
        #endregion

        #region Наименование будущего жанра
        private string _genreName;
        public string GenreName 
        {
            get => _genreName;
            set
            {
                if(value == _genreName)
                    return;
                _genreName = value;
                OnPropertyChanged("GenreName");
            }
        }
        #endregion

        #region Описание будущего жанра
        private string _genreDescription;
        public string GenreDescripton
        {
            get => _genreDescription;
            set
            {
                if (value == _genreDescription)
                    return;
                _genreDescription = value;
                OnPropertyChanged("GenreDescription");
            }
        }
        #endregion

        #region Actions
        public void AddGenreToDataBaseAction(object obj) 
        {
            if(_genreName != "" && _genreDescription != "")
            {
                Genre _genre = new Genre {GenreName = _genreName,GenreDescription=_genreDescription};
                _genreRepository.Create(_genre);
                CloseDialogWindowAction(null);
            }
        }
        #endregion

    }
}
