﻿using CourseWork.Models;
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
    /// Логика взаимодействия для MotherboardPage.xaml
    /// </summary>
    public partial class MotherboardPage : Page
    {
        public MotherboardPage()
        {
            InitializeComponent();
            MotherboardContext db;
            db = new MotherboardContext();
            db.Motherboards.Load(); // загружаем данные
            motherboardsGrid.ItemsSource = db.Motherboards.Local.ToBindingList();
        }
    }
}
