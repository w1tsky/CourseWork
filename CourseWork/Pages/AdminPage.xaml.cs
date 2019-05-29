using CourseWork.UserControls;
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

namespace CourseWork.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void Components_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ManageComponents());
        }

        private void ManageUsers_Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ManageUsers());
        }
    }
}
