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

namespace Name
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public bool ClickList { get; set; }
        public int ListAmount { get; set; }

        public Options(bool clickList, int listAmount)
        {
            InitializeComponent();
            ClickList = clickList;
            ListAmount = listAmount;

        }

        private void SaveAndClose_Click(object sender, RoutedEventArgs e)
        {
            int tempNumber;

            if (listClick.IsChecked == true)
            {
                ClickList = true;
            }
            else
            {
                ClickList = false;
            }
            
            bool success = Int32.TryParse(nameAmount.Text, out tempNumber);
            ListAmount = tempNumber;
            if (success)
            {
                Hide();
            }
            else
            {
                MessageBox.Show("Only insert numbers into the field.");
            }
            
            
            
        }
    }
}
