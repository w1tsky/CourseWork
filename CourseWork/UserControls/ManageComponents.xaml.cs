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

namespace CourseWork.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ManageComponents.xaml
    /// </summary>
    public partial class ManageComponents : UserControl
    {
        public ManageComponents()
        {
            InitializeComponent();
        }

        private void CPU_Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ManageCpu());
        }

        private void GPU_Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ManageGpu());
        }

        private void Motherboard_Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ManageMotherboard());
        }

        private void Memory_Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ManageRam());
        }
    }
}
