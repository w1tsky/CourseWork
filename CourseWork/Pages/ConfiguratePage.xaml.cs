using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для ConfiguratePage.xaml
    /// </summary>
    public partial class ConfiguratePage : Page
    {
        public  ObservableCollection<Config> Configs { get; set; }
        public ConfiguratePage()
        {  

            InitializeComponent();

            CpuContext dbCpu;
            dbCpu = new CpuContext();
            dbCpu.CPUs.Load(); 
            cpusGrid.ItemsSource = dbCpu.CPUs.Local.ToBindingList();

            GpuContext dbGpu;
            dbGpu = new GpuContext();
            dbGpu.GPUs.Load();
            gpusGrid.ItemsSource = dbGpu.GPUs.Local.ToBindingList();

            MotherboardContext dbMotherboard;
            dbMotherboard = new MotherboardContext();
            dbMotherboard.Motherboards.Load(); // загружаем данные
            motherboardsGrid.ItemsSource = dbMotherboard.Motherboards.Local.ToBindingList();

            RamContext dbRam;
            dbRam = new RamContext();
            dbRam.Rams.Load(); // загружаем данные
            motherboardsGrid.ItemsSource = dbRam.Rams.Local.ToBindingList();
        }


    

       

        private void Save_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void CPU_Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void GPU_Button_Click(object sender, RoutedEventArgs e)
        {
          
        }
        
        private void Motherboard_Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Memory_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
