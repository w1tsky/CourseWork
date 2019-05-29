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
    /// Логика взаимодействия для ManageCpu.xaml
    /// </summary>
    public partial class ManageCpu : UserControl
    {
        CpuContext db;
        public ManageCpu()
        {
            InitializeComponent();

            db = new CpuContext();
            db.CPUs.Load(); // загружаем данные
            cpusGrid.ItemsSource = db.CPUs.Local.ToBindingList(); // устанавливаем привязку к кэшу

          
        }

        

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

       
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (cpusGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < cpusGrid.SelectedItems.Count; i++)
                {
                    Cpu cpu = cpusGrid.SelectedItems[i] as Cpu;
                    if (cpu != null)
                    {
                        db.CPUs.Remove(cpu);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}

