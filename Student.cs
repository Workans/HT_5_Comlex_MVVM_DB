using Binding_DataContext.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_5_Comlex_MVVM_DB
{
    class Student : BaseNotifyPropertyChanged
    {
        private string color = "Red";
        private string name;
        private string lastname;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                Notify();
            }
        }
        public string Lastname
        {
            get => lastname;
            set
            {
                lastname = value;
                Notify();
            }
        }
        public string Color 
        {
            get => color;
            set
            {
                color = value;
                Notify();
            }
        }
        public override string ToString()
        {
            return $"{Name} {Lastname}";
        }
    }
}
