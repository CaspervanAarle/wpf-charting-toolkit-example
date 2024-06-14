using System.Windows.Controls;

namespace Visualization_I4_test.View
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class GraphChart : Page
    {
        public GraphChart()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
        }
    }
}
