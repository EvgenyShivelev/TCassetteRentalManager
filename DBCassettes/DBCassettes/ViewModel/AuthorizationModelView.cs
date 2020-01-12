using API;
using DataBase.Model;
using DBCassettes.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ViewModel;

namespace DBCassettes.ModelView
{
    class AuthorizationModelView : BaseViewModel
    {

        public AuthorizationModelView(Window rootWindow) : base(rootWindow)
        {
            unitOfWork = new UnitOfWork();
            AuthorizationAction = new Command(Authorization);
        }
        public ICommand AuthorizationAction { get; private set; }
        public ICommand CloseAction { get; set; }
        private string _login;
        private string _password;
        public string LoginString
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged("LoginString");
            }
        }
        public string PasswordString
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged("PasswordString");
            }
        }
        private void Authorization()
        {
            var c = unitOfWork.Repository<Login>().GetOneEntity(t => t.PersonLogin == LoginString && t.PersonPassword == PasswordString);
            if (c != null)
            {
                rootWindow.Close();
            }
        }
        void Authorization(object obj)
        {
            var c = unitOfWork.Repository<Login>().GetOneEntity(t => t.PersonLogin == LoginString && t.PersonPassword == PasswordString);
            if (c != null)
            {
                ManagerWindow MW = new ManagerWindow();
                MW.Show();
                rootWindow.Close();
            }
        }
    }
}
