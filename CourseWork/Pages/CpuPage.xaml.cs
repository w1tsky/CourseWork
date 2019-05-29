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
    /// Логика взаимодействия для CpuPage.xaml
    /// </summary>
    public partial class CpuPage : Page
    {       
        public string cpuCompany;
        public CpuPage()
        {
            InitializeComponent();
            CpuContext db;
            db = new CpuContext();
            db.CPUs.Load(); // загружаем данные
            cpusGrid.ItemsSource = db.CPUs.Local.ToBindingList(); // устанавливаем привязку к кэшу
            
        }

        private void CpusGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
      
            Cpu cpu = (Cpu)cpusGrid.SelectedItem;
         
            cpuTextBlock.Text = cpu.Company + " " + cpu.Series + " " + cpu.Model + " " + cpu.Socket ;
            priceTextBlock.Text = cpu.Price.ToString();

        }

        private void AddComponent_Click(object sender, RoutedEventArgs e)
        {         
            Cpu addCpu = (Cpu)cpusGrid.SelectedItem;
            string cpuCompany = addCpu.Company + " " + addCpu.Series + " " + addCpu.Model + " " + addCpu.Socket;
            string gpuCompany = "";
            frame.Navigate(new ConfigPage(cpuCompany,gpuCompany));
        }
    }
}
