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

namespace CourseWork.Pages
{
    /// <summary>
    /// Логика взаимодействия для GpuPage.xaml
    /// </summary>
    public partial class GpuPage : Page
    {
        public GpuPage()
        {
            InitializeComponent();
            GpuContext db;
            db = new GpuContext();
            db.GPUs.Load(); // загружаем данные
            gpusGrid.ItemsSource = db.GPUs.Local.ToBindingList();
        }

        private void CpusGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gpu addGpu = (Gpu)gpusGrid.SelectedItem;
            string gpuCompany = addGpu.Company + " " + addGpu.Series + " " + addGpu.Model + " ";
            string cpuCompany = "";
            frame.Navigate(new ConfigPage(cpuCompany,gpuCompany));
        }
    }
}
