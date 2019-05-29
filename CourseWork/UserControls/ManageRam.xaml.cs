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
    /// Логика взаимодействия для ManageRam.xaml
    /// </summary>
    public partial class ManageRam : UserControl
    {
        RamContext db;
        public ManageRam()
        {
            InitializeComponent();

            db = new RamContext();
            db.Rams.Load(); // загружаем данные
            ramsGrid.ItemsSource = db.Rams.Local.ToBindingList(); // устанавливаем привязку к кэшу

        }


        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }


        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ramsGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ramsGrid.SelectedItems.Count; i++)
                {
                    Ram ram = ramsGrid.SelectedItems[i] as Ram;
                    if (ram != null)
                    {
                        db.Rams.Remove(ram);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}

