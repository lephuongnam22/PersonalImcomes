using PersonalIncomeStatement.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PersonalIncomeStatement.Views
{
    /// <summary>
    /// Interaction logic for PaymentAddingViewModel.xaml
    /// </summary>
    public partial class PaymentAddingView : Window
    {
        public PaymentAddingView(PaymentAddingViewModel paymentAddingViewModel)
        {
            InitializeComponent();
            this.DataContext = paymentAddingViewModel;
        }
    }
}
