using CourseWork.Models;
using CourseWork.Pages;
using CourseWork.Windows;
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

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    
        public bool adminCheck;
        
        public MainWindow(bool AdminChek)
        {
            InitializeComponent();
            if(AdminChek == true)
            {
                CurrentUserBlock.Text = "Admin";
            }
            else
            {
                CurrentUserBlock.Text = "User";
            }

            adminCheck = AdminChek;
           
        }    
        private void Configurate_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ConfiguratePage());
        }

      

        private void AdminPanel_Click(object sender, RoutedEventArgs e)
        {
            if(adminCheck == true)
            {
                mainFrame.Navigate(new AdminPage());
            }
            else
            {
                MessageBox.Show("Вы не администратор");
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
            this.Close();
        }
    }
}
