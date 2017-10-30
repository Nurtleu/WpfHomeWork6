using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HomeWorkWpf6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<DivisionCollection> divisionCollection;
        private ObservableCollection<EmployeeCollection> employeeCollection;
        public MainWindow()
        {
            InitializeComponent();
            divisionCollection = new ObservableCollection<DivisionCollection>
            (
            );
            employeeCollection = new ObservableCollection<EmployeeCollection>
            (
                new List<EmployeeCollection>
                {
                    new EmployeeCollection
                    {
                        Id=2,
                        EmployeeName="Almas",
                    },

                    new EmployeeCollection
                    {
                        Id=3,
                        EmployeeName="Vladimir",                       
                    },

                }
            );
            dataGrid.ItemsSource = employeeCollection;
        }
    }
}
