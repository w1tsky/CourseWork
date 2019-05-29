using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace CourseWork.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ManageUsers.xaml
    /// </summary>
    public partial class ManageUsers : UserControl
    {
        UserContext db;
        public ManageUsers()
        {
            InitializeComponent();

            db = new UserContext();
            db.Users.Load(); // загружаем данные
            usersGrid.ItemsSource = db.Users.Local.ToBindingList(); // устанавливаем привязку к кэшу
            

        }


        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }


        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (usersGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < usersGrid.SelectedItems.Count; i++)
                {
                    User user = usersGrid.SelectedItems[i] as User;
                    if (user != null)
                    {
                        db.Users.Remove(user);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}

