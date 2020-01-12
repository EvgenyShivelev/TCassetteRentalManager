using API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DBCassettes.ViewModel
{
    public class BaseDialogPage: BaseViewModel
    {
        public BaseDialogPage(Window rootWindow) : base(rootWindow) 
        {
            CloseDialogWindowCommand = new Command(CloseDialogWindowAction);
        }

        public ICommand CloseDialogWindowCommand { get; private set; }

        protected void CloseDialogWindowAction(object obj) 
        {
            rootWindow.Close();
        }
    }
}
