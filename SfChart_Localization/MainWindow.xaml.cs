using System.Collections.ObjectModel;
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

namespace SfChart_Localization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
        }
    }

    public class StockPrice
    {
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<StockPrice> StockPriceDetails { get; set; }

        public ViewModel()
        {
            StockPriceDetails = new ObservableCollection<StockPrice>
        {
            new StockPrice { Date = new DateTime(2024, 11, 1), High = 500, Low = 450, Open = 470, Close = 490 },
            new StockPrice { Date = new DateTime(2024, 11, 2), High = 520, Low = 460, Open = 480, Close = 510 },
            new StockPrice { Date = new DateTime(2024, 11, 3), High = 540, Low = 470, Open = 490, Close = 530 },
            new StockPrice { Date = new DateTime(2024, 11, 4), High = 560, Low = 490, Open = 520, Close = 550 }
        };
        }
    }
}