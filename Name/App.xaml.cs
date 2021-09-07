using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Name
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void Application_Start(object sender, StartupEventArgs args)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

    }
}
