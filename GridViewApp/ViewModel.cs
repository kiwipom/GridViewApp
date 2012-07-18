using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GridViewApp
{
    public class ViewModel : INotifyPropertyChanged
    {

        public ViewModel()
        {
            Groups = new ObservableCollection<PersonGroupViewModel>();
            LoadDataAsync();
        }

        public ObservableCollection<PersonGroupViewModel> Groups { get; private set; }

        private async void LoadDataAsync()
        {
            var allPeople = await CreatePeople();
            var personList = allPeople.ToList();
            
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                .ToCharArray()
                .Select(c => c.ToString());
            
            foreach (var letter in alphabet)
            {
                var group = personList
                    .Where(p => p.LastName.StartsWith(letter, StringComparison.CurrentCultureIgnoreCase));

                Groups.Add(new PersonGroupViewModel(letter, group));
            }
        }



        private async Task<IEnumerable<Person>> CreatePeople()
        {
            var result = new[]
                       {
                           new Person {FirstName = "Ian", LastName = "Randall"},
                           new Person {FirstName = "Vicki", LastName = "Randall"},
                           new Person {FirstName = "Lizzy", LastName = "Randall"},
                           new Person {FirstName = "Rosie", LastName = "Randall"},
                           new Person {FirstName = "Harry", LastName = "Randall"},
                           new Person {FirstName = "Ben", LastName = "Gracewood"},
                           new Person {FirstName = "Ally", LastName = "Gracewood"},
                           new Person {FirstName = "Olly", LastName = "Gracewood"},
                           new Person {FirstName = "Amalie", LastName = "Gracewood"},
                           new Person {FirstName = "Jason", LastName = "Masters"},
                           new Person {FirstName = "Lorraine", LastName = "Masters"},
                           new Person {FirstName = "Isobelle", LastName = "Masters"},
                           new Person {FirstName = "Niamh", LastName = "Masters"},
                           new Person {FirstName = "Martin", LastName = "Duckhouse"},
                           new Person {FirstName = "Gerry", LastName = "Duckhouse"},
                           new Person {FirstName = "James", LastName = "Duckhouse"},
                       };

            return await Task.FromResult(result);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}