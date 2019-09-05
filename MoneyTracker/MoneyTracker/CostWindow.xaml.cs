using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using DLL.Entities;
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
using System.Windows.Shapes;

namespace MoneyTracker
{
    /// <summary>
    /// Interaction logic for CostWindow.xaml
    /// </summary>
    public partial class CostWindow : Window
    {
        private EFContext context = new EFContext();
        public string categoryName, login, password;
        private readonly IOperationService operationService;
        public CostWindow(string categoryName_, string login_, string password_)
        {
            InitializeComponent();
            categoryName = categoryName_;
            operationService = new OperationService();
            login = login_;
            password = password_;
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Done_Button_Click(object sender, RoutedEventArgs e)
        {
            Operation operation = new Operation();
            try
            {
                foreach (var item in context.Categories)
                {
                    if (categoryName == item.Name)
                    {
                        operation.CategoryId = item.ID;
                    }
                }
                if (CardTabItem.IsSelected)
                {
                    operation.WayOfPayId = 1;
                    operation.Summ = Double.Parse(tbSumm.Text);
                    operation.WayOfPayId = 1;
                    foreach (var item in context.Users)
                    {
                        if (item.Login == login && item.Password == password)
                        {
                            item.CardBalance -= Double.Parse(tbSumm.Text);
                        }
                    }
                }
                else
                {
                    operation.WayOfPayId = 0;
                    operation.Summ = Double.Parse(tbSumm2.Text);
                    operation.WayOfPayId = 2;
                    foreach (var item in context.Users)
                    {
                        if (item.Login == login && item.Password == password)
                        {
                            item.CashBalance -= Double.Parse(tbSumm2.Text);
                        }
                    }
                    int result = operationService.AddOperation(new OperationAddModel()
                    {
                        CategoryId = operation.CategoryId,
                        WayOfPayId = operation.WayOfPayId,
                        Summ = operation.Summ

                        // Покашо не зроблено IsProfit
                    });
                    context.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
