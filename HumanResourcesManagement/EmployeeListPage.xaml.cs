using System;
using System.Collections.Generic;
using System.IO;
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

namespace HumanResourcesManagement
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }

    public partial class EmployeeListPage : Page
    {
        public EmployeeListPage()
        {
            InitializeComponent();
            var employees = new List<Employee>
            {
                new Employee { ID = 1, Name = "Иван", Position = "Программист" },
                new Employee { ID = 2, Name = "Сергей", Position = "Менеджер" },
                new Employee { ID = 3, Name = "Петр", Position = "Дизайнер" },
                new Employee { ID = 4, Name = "Богдан", Position = "Программист" },
                new Employee { ID = 5, Name = "Владислав", Position = "Дизайнер" }
            };
            DataGrid.ItemsSource = employees;
        }

        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem is Employee selectedEmployee)
            {
                NavigationService.Navigate(new EmployeeEditPage(selectedEmployee));
            }
        }
    }
}
