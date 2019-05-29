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
    /// Логика взаимодействия для ManageMotherboard.xaml
    /// </summary>
    public partial class ManageMotherboard : UserControl
    {
        MotherboardContext db;
        public ManageMotherboard()
        {
            InitializeComponent();

            db = new MotherboardContext();
            db.Motherboards.Load(); // загружаем данные
            motherboardsGrid.ItemsSource = db.Motherboards.Local.ToBindingList(); // устанавливаем привязку к кэшу

        }


        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }


        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (motherboardsGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < motherboardsGrid.SelectedItems.Count; i++)
                {
                    Motherboard motherboard = motherboardsGrid.SelectedItems[i] as Motherboard;
                    if (motherboard != null)
                    {
                        db.Motherboards.Remove(motherboard);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
