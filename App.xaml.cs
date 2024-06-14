using System.Windows;
using Visualization_I4_test.View;

namespace Visualization_I4_test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow();
            window.Show();

            // Navigate to the UserPage
            window.MainFrame.Navigate(new PieChart());
        }
    }



}
