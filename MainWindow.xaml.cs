using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _20241015
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> drinks = new Dictionary<string, int>
        {
            { "R大杯", 60 },
            { "R小杯", 40 },
            { "G大杯", 50 },
            { "G小杯", 30 },
            { "C大杯", 50 },
            { "C小杯", 30 },
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var targetSlider = sender as Slider;
            int amount = (int)targetSlider.Value;
            var targetStackPanel = targetSlider.Parent as StackPanel;
            var targetLabel = targetStackPanel.Children[0] as Label;
            var drinkName = targetLabel.Content.ToString();
            MessageBox.Show(drinkName + " " + amount + "杯，共" + drinks[drinkName] * amount + "元");
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}