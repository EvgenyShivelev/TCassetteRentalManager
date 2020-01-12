using API;
using DataBase.Model;
using DBCassettes.ModelView;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DBCassettes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (var EDBContext = new EDBContext())
            {
                //Person person = new Person { FirstName = "HI" };
                //EDBContext.Persons.Add(person);
                //EDBContext.Logins.Add(new Login { PersonLogin = "XOR", PersonPassword = "123", _person = person });
                //EDBContext.Genres.Add(new Genre { GenreName = "ХОРРА2Р" });
                //EDBContext.Genres.Add(new Genre { GenreName = "ХОРРА54Р" });
                //EDBContext.SaveChanges();
                //EDBContext.Films.Add(new Film { FilmName = "ХРЯК", FilmGenreID = 1, FilmImage = API.BMI.LoadImageToDataBase(API.BMI.LoadImage(new Uri(@"C:\Users\MellChaos\Documents\ICONS\7.jpg"))) });
                //EDBContext.Films.Add(new Film { FilmName = "лалита", FilmGenreID = 2, FilmImage = API.BMI.LoadImageToDataBase(API.BMI.LoadImage(new Uri(@"C:\Users\MellChaos\Documents\ICONS\2.jpg"))) });
                //EDBContext.Films.Add(new Film { FilmName = "хрок", FilmGenreID = 1, FilmImage = API.BMI.LoadImageToDataBase(API.BMI.LoadImage(new Uri(@"C:\Users\MellChaos\Documents\ICONS\5.jpg"))) });
                //EDBContext.SaveChanges();
                //for (int i = 0; i < 100000; i++)
                //{
                //    if ((i % 250) == 0)
                //        EDBContext.SaveChanges();
                //    EDBContext.Cassettes.Add(new Cassette { CassetteCondition = ENUM.Enum.CasseteCondition.NEW, FilmOnCassetteID = 1 });
                //    EDBContext.Cassettes.Add(new Cassette { CassetteCondition = ENUM.Enum.CasseteCondition.NEW, FilmOnCassetteID = 2 });
                //    EDBContext.Cassettes.Add(new Cassette { CassetteCondition = ENUM.Enum.CasseteCondition.NEW, FilmOnCassetteID = 3 });

                //}
            }
            DataContext = new AuthorizationModelView(this);

        }
    }
}
