using API;
using DataBase.Model;
using DBCassettes.API;
using DBCassettes.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ViewModel
{
    public class AddFilmDialogViewModel: BaseDialogPage
    {
        public AddFilmDialogViewModel(Window rootWindow): base(rootWindow)
        {
            unitOfWork = new UnitOfWork();
            AddFilmToDataBaseCommand = new Command(AddFilmToDataBaseAction);
            RefreshGenresCollectionCommand = new Command(RefreshGenresCollectionAction);
            LoadImageForFilmCommand = new Command(LoadImageForFilmAction);
            RefreshGenresCollectionAction(null);
        }

        #region GenreCollection
        private ObservableCollection<Genre> _genres;
        public ObservableCollection<Genre> Genres
        {
            get { return _genres; }
            private set
            {
                _genres = value;
                OnPropertyChanged("Genres");

            }
        }
        #endregion

        #region Commands
        public ICommand AddFilmToDataBaseCommand { get; private set; }
        public ICommand RefreshGenresCollectionCommand { get; private set; }
        public ICommand LoadImageForFilmCommand { get; private set; }
        #endregion

        #region Имя будущего фильма
        private string _filmName;
        public string FilmName
        {
            get => _filmName;
            set
            {
                if (value == _filmName)
                    return;
                _filmName = value;
                OnPropertyChanged("FilmName");
            }
        }
        #endregion

        #region Изображение будущего фильма
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

        #region Жанр будущего Фильма
        private Genre _filmGenre;
        public Genre FilmGenre
        {
            get => _filmGenre;
            set
            {
                if (value == _filmGenre)
                    return;
                _filmGenre = value;
                OnPropertyChanged("FilmGenre");
            }
        }
        #endregion

        #region Actions
        async void RefreshGenresCollectionAction(object obj)
        {
            await Task.Run(() => Genres = new ObservableCollection<Genre>(unitOfWork.Repository<Genre>().Get()));
        }
        void LoadImageForFilmAction(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                PreviewImage = BMI.LoadImage(new Uri(openFileDialog.FileName));
            }
        }
        void AddFilmToDataBaseAction(object obj)
        {
            if (_filmName != "" && _filmGenre != null)
            {
                Film film = new Film
                {
                    FilmName = _filmName,
                    FilmGenreID = _filmGenre.GenreID,
                };
                if (_previewImage != null)
                {
                    film.FilmImage = BMI.LoadImageToDataBase(_previewImage);
                }
                else
                {
                    film.FilmImage = BMI.LoadImageToDataBase ( BMI.LoadImage(new Uri("pack://application:,,,/Assets/Oh.png")) );

                }
                unitOfWork.Repository<Film>().Create(film);
                CloseDialogWindowAction(null);
            }

            
        }
        #endregion
    }
}
