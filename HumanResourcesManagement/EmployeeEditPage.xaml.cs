using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для EmployeeEditPage.xaml
    /// </summary>
    public partial class EmployeeEditPage : Page
    {
        private Employee _employee;
        public EmployeeEditPage(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            NameEmployee.DataContext = _employee;
            PositionEmployee.DataContext = _employee;
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _employee.Name = NameEmployee.Text;
            _employee.Position = PositionEmployee.Text;

            NavigationService.GoBack();
        }
    }
}
