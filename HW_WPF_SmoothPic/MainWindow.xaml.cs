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

namespace HW_WPF_SmoothPic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// ;component
    ///  System.Windows.Media.Effects.BlurEffect objBlur = new System.Windows.Media.Effects.BlurEffect();
    ///     objBlur.Radius = 10;
    ///     win.Effect = objBlur;
    public partial class MainWindow : Window
    {
        System.Windows.Media.Effects.BlurEffect objBlur = new System.Windows.Media.Effects.BlurEffect();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeSmooth(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            objBlur.Radius = Smooth.Value;
            Pic.Effect = objBlur;
        }
    }
}