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

namespace Name
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Options options = new Options(false, 6);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (lstNames.Items.Count == options.ListAmount)
            {
                lstNames.Items.Clear();
                MessageBox.Show("Too many names in the list! Clearing list now.");
            }
            else if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            
        }
        /// <summary>
        /// Clears the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearList_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Clear();
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            options.Show();

        }

        private void ClearList_ClickList(object sender, MouseButtonEventArgs e)
        {
            if (options.ClickList == true)
            {
                lstNames.Items.Clear();
            }
        }
    }
}
