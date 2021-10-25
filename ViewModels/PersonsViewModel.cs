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

    public class PersonsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private ObservableCollection<person> _lstperson;

        public ObservableCollection<person> ListPerson
        {
            get { return _lstperson; }
            set
            {
                _lstperson = value;
                OnPropertyChanged(nameof(ListPerson));
            }

        }


        PersonsEntities personEntities;

        public PersonsViewModel()
        {
            personEntities = new PersonsEntities();
            LoadPerson();
            DeleteCommand = new Command((s) => true, Delete);
        }

        private void Delete(object obj)
        {
            var personDel = obj as person;
            personEntities.persons.Remove(personDel);
            personEntities.SaveChanges();
            ListPerson.Remove(personDel);
        }

        private void LoadPerson() =>
            //throw new NotImplementedException();
            ListPerson = new ObservableCollection<person>(personEntities.persons);
        public ICommand DeleteCommand { get; set; }

    }

    public class Command2 : ICommand
    {
        public Command2(Func<object, bool> methodCanExecute, Action<object> methodExecute)
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


