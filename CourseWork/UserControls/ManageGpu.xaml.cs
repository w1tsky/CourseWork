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
    /// Логика взаимодействия для ManageGpu.xaml
    /// </summary>
    public partial class ManageGpu : UserControl
    {
        GpuContext db;
        public ManageGpu()
        {
            InitializeComponent();

            db = new GpuContext();
            db.GPUs.Load(); // загружаем данные
            gpusGrid.ItemsSource = db.GPUs.Local.ToBindingList(); // устанавливаем привязку к кэшу


        }



        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }


        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (gpusGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < gpusGrid.SelectedItems.Count; i++)
                {
                    Gpu gpu = gpusGrid.SelectedItems[i] as Gpu;
                    if (gpu != null)
                    {
                        db.GPUs.Remove(gpu);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
