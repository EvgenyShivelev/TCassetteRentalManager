using API;
using DataBase.Model;
using DBCassettes.API;
using DBCassettes.ViewModel;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using static ENUM.Enum;

namespace ViewModel
{
    class AddCassetteDialogViewModel: BaseDialogPage
    {
        public AddCassetteDialogViewModel(Window rootWindow) : base(rootWindow)
        {
            unitOfWork = new UnitOfWork();
            AddCassetteToDataBaseCommand = new Command(AddCassetteToDataBaseAction);
            RefreshFilmsCollectionAction(null);
        }

        #region FilmCollection And Genre
        private ObservableCollection<Film> _films;
        public ObservableCollection<Film> Films
        {
            get { return _films; }
            private set
            {
                _films = value;
                OnPropertyChanged("Films");
            }
        }

        #endregion

        #region Изображение фильма
        private BitmapImage _previewImage;
        public BitmapImage PreviewImage
        {
            get => _previewImage;
            set
            {
                _previewImage = value;
                OnPropertyChanged("PreviewImage");
            }
        }
        #endregion 

        #region Commands
        public ICommand AddCassetteToDataBaseCommand { get; private set; }
        public ICommand RefreshFilmsCollectionCommand { get; private set; }
        #endregion

        #region Фильм будущей кассеты
        private Film _film;
        public Film Film
        {
            get => _film;
            set
            {
                if (value == _film)
                    return;
                _film = value;
                PreviewImage = _film.FilmImage != null ? BMI.GetImageFromDataBase(Film.FilmImage) : null;
                OnPropertyChanged("Film");
            }
        }
        #endregion

        #region Состояние будущей кассеты

        private CasseteCondition _condition;
        public CasseteCondition Condition
        {
            get => _condition;
            set
            {
                if (value == _condition)
                    return;
                _condition = value;
                OnPropertyChanged("Condition");
            }
        }
        #endregion

        #region Actions
        async void RefreshFilmsCollectionAction(object obj)
        {
            await Task.Run(() => 
            {
                Films = new ObservableCollection<Film>(unitOfWork.Repository<Film>().Get());

            });
        }
        void AddCassetteToDataBaseAction(object obj)
        {
            if (_film != null)
            {
                Cassette cassette = new Cassette
                {
                    FilmOnCassetteID = _film.FilmID,
                    CassetteCondition = _condition
                };
                unitOfWork.Repository<Cassette>().Create(cassette);
                CloseDialogWindowAction(null);
            }


        }
        #endregion
    }
}
