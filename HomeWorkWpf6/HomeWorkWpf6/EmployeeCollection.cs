using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWpf6
{
    public class EmployeeCollection : INotifyPropertyChanged
    {
        private long id { get; set; }
        private string employeeName { get; set; }
        private DivisionCollection division;

        public DivisionCollection DivisionName
        {
            get { return division; }
            set
            {
                division = value;
                OnPropertyChanged("Name");
            }
        }

        public long Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set
            {
                employeeName = value;
                OnPropertyChanged("Login");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
