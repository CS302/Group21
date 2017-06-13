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
using WorkersLibrary;

namespace WorkersEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Worker> Workers { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Workers = new List<Worker>();
            Workers.Add(new Driver("John", 29, 123456, "BMW", 128));
            Workers.Add(new Manager("Bob", 39, 789456, 10));
            Workers.Add(new Manager("Hulk", 59, 321789, 7));
            Workers.Add(new Driver("Henry", 32, 654123, "Audi", 256));
            Workers.Add(new Manager("Sara", 35, 987321, 5));

            DataContext = this;
        }
    }
}
