using OrganizationStructureService.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OrganizationStructureService.ViewModels
{
    public class RolesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

/*        private role _role;

        public role role
        {
            get { return _role; }
            set 
            { 
                _role = value;
                OnPropertyChanged(nameof(role));
            }
           
        }
*/


        private ObservableCollection <role> _lstrole;

        public ObservableCollection<role> ListRole
        {
            get { return _lstrole; }
            set
            {
                _lstrole = value;
                OnPropertyChanged(nameof(ListRole));
            }

        }

        RolesEntities rolesEntities;


        public RolesViewModel()
        {
            rolesEntities = new RolesEntities();
            LoadRole();
            DeleteCommand = new Command((s) => true, Delete);
        }

        private void Delete(object obj)
        {
            var roleDel = obj as role;
            rolesEntities.roles.Remove(roleDel);
            rolesEntities.SaveChanges();
            ListRole.Remove(roleDel);
        }

        private void LoadRole()
        {
            //throw new NotImplementedException();
            ListRole = new ObservableCollection<role>(rolesEntities.roles);
        }
        public ICommand DeleteCommand { get; set; }

    }

    public class Command :ICommand
    {
        public Command(Func<object, bool> methodCanExecute, Action<object> methodExecute)
        {
            methodCanExecute = CanExecute;
            methodExecute = Execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        
    }
}
