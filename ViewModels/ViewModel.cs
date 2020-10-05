using RandomNameGenerator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace HT_5_Comlex_MVVM_DB
{
    class ViewModel
    {
        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();

        public ObservableCollection<string> Colors { get; set; } = new ObservableCollection<string>();

        public Student SelectedStudent { get; set; }

        public ICommand AddCommand { get; set; }

        public ICommand RemoveCommand { get; set; }

        public ICommand ClearCommand { get; set; }

        public ViewModel()
        {
            AddCommand = new RelayCommand(x => 
            {
                Students.Add(new Student
                {
                    Name = RandomNameGenerator.NameGenerator.GenerateFirstName(Gender.Male),
                    Lastname = RandomNameGenerator.NameGenerator.GenerateLastName()
                });
            });
            RemoveCommand = new RelayCommand(x => Students.Remove(SelectedStudent), x => Students.Count > 0);
            ClearCommand = new RelayCommand(x => Students.Clear(), x => Students.Count > 0);
            Colors = new ObservableCollection<string>
            {
                "Red",
                "Green",
                "Grey",
                "Orange",
                "Pink",
                "Brown",
                "Black",
                "Violet"
            };
        }
    }
}
