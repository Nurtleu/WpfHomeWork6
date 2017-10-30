using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWpf6
{
    public class DivisionCollection : INotifyPropertyChanged
    {
        private long divisionId { get; set; }
        private string divisionName { get; set; }
        private string divisionPassword { get; set; }

        public long DivisionId
        {
            get { return divisionId; }
            set
            {
                divisionId = value;
                OnPropertyChanged("Id");
            }
        }

        public string DivisionName
        {
            get { return divisionName; }
            set
            {
                divisionName = value;
                OnPropertyChanged("Name");
            }
        }  

        public string DivisionPassword
        {
            get { return divisionPassword; }
            set
            {
                divisionPassword = value;
                OnPropertyChanged("Company");
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
