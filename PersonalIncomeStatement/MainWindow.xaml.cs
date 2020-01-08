using Microsoft.Extensions.Hosting;
using PersonalIncomeStatement.ViewModels;
using PersonalIncomeStatement.Views;
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
using Microsoft.Extensions.DependencyInjection;

namespace PersonalIncomeStatement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IHost _host;
        public MainWindow(IHost host)
        {
            _host = host;
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = _host.Services.GetService<IncomeAddingView>();
            mainWindow.Show();
        }
    }
}
