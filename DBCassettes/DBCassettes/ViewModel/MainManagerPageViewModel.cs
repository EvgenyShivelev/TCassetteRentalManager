using API;
using DataBase.Model;
using DBCassettes.View.Pages;
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

namespace ViewModel
{
    class MainManagerPageViewModel: BaseViewModel
    {
        public enum TypeOfAction
        {
            ADDGENRE,
            ADDFILM,
            ADDCASSETTE,
        }

        public MainManagerPageViewModel(Window rootWindow) : base(rootWindow)
        {
            unitOfWork = new UnitOfWork();
            AddGenreCommand = new Command(AddGenreAction);
            AddFilmCommand = new Command(AddFilmAction);
            AddCassetteCommand = new Command(AddCassetteAction);
            DeleteCassetteCommand = new Command(DeleteCassetteFromDataBaseAction, IsCassetteSelected);
            //DeleteCassetteCommand = new Command(DeleteCassetteFromDataBaseAction, IsCassetteSelected);
            LoadDataFromDataBase();
        }

        public ICommand AddGenreCommand { get; private set; }
        public ICommand AddFilmCommand { get; private set; }
        public ICommand AddCassetteCommand { get; private set; }
        public ICommand DeleteCassetteCommand { get; private set; }

        private ObservableCollection<Cassette> _cassettes;
        private ObservableCollection<Genre> _genres;
        private ObservableCollection<Film> _films;

        public ObservableCollection<Cassette> Cassettes
        {
            get { return _cassettes; }
            private set
            {
                _cassettes = value;
                OnPropertyChanged("Cassettes");
            }
        }
        public ObservableCollection<Film> Films
        {
            get { return _films; }
            private set
            {
                _films = value;
                OnPropertyChanged("Films");
            }
        }
        public ObservableCollection<Genre> Genres
        {
            get { return _genres; }
            private set
            {
                _genres = value;
                OnPropertyChanged("Genres");
            }
        }

        private Cassette _selectedCassette;
        public Cassette SelectedCassette
        {
            get => _selectedCassette;
            set
            {
                _selectedCassette = value;
                OnPropertyChanged("SelectedCassette");
            }
        }

        private Cassette _selectedFilm;
        public Cassette SelectedFilm
        {
            get => _selectedFilm;
            set
            {
                _selectedFilm = value;
                OnPropertyChanged("SelectedFilm");
            }
        }
        private Cassette _selectedGenre;
        public Cassette SelectedGenre
        {
            get => _selectedGenre;
            set
            {
                _selectedGenre = value;
                OnPropertyChanged("SelectedGenre");
            }
        }

        bool IsCassetteSelected(object obj) => (obj as Cassette) != null ;

        bool IsFilmSelected(object obj) => (obj as Film) != null;
        void LoadDataFromDataBase()
        {
            //_cassettes = new ObservableCollection<Cassette>();
            Cassettes = new ObservableCollection<Cassette>(unitOfWork.Repository<Cassette>().Get());
            Films = new ObservableCollection<Film>(unitOfWork.Repository<Film>().Get());
            Genres = new ObservableCollection<Genre>(unitOfWork.Repository<Genre>().Get());
            //foreach (var c in new EDBContext().Cassettes)
            //{
            //    rootWindow.Dispatcher.Invoke(() =>
            //       {
            //           _cassettes.Add(c);
            //       }
            //    );
            //}
        }

        void AddGenreAction(object obj)
        {
            Dialog _dialog = new Dialog();
            _dialog.SetDataContextToDialogWindow(new AddGenreDialogViewModel(_dialog));
            if (_dialog.ShowDialog() == true)
                return;
        }
        void AddFilmAction(object obj)
        {
            Dialog _dialog = new Dialog();
            _dialog.SetDataContextToDialogWindow(new AddFilmDialogViewModel(_dialog));
            if (_dialog.ShowDialog() == true)
                return;
        }
        void AddCassetteAction(object obj)
        {
            Dialog _dialog = new Dialog();
            _dialog.SetDataContextToDialogWindow(new AddCassetteDialogViewModel(_dialog));
            if (_dialog.ShowDialog() == true)
                return;
        }
        void DeleteCassetteFromDataBaseAction(object obj)
        {
        }

    }
}
