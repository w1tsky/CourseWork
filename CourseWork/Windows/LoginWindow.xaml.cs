using CourseWork.Models;
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
using System.Windows.Shapes;
using System.Data.Entity;
using System.Collections.ObjectModel;


namespace CourseWork.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {     
        public ObservableCollection<User> CPUs { get; set; }


        public LoginWindow()
        {
            InitializeComponent();
                           
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                var users = db.Users;

                if (users.Count() < 2)
                {
                    User ua = new User();
                    ua.Username = "admin";
                    ua.IsAdmin = true;
                    ua.Password = "admin";
                   
                
                    User uu = new User();
                    uu.Username = "user";
                    uu.IsAdmin = false;
                    uu.Password = "user";

                    db.Users.Add(ua);
                    db.Users.Add(uu);
                    db.SaveChanges();


                }

                User user = db.Users.Where(u => u.Username == LoginBox.Text).FirstOrDefault();
                if (user != null && user.Password == PasswordBox.Password)
                {
                    MainWindow mw = new MainWindow(user.IsAdmin);
                    mw.Show();
                    this.Close();
                }
                else
                {
                  
                }
            }
        }
    }
}
