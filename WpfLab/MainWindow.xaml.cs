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

namespace WpfLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void Border_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("First Button Clicked");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Second Button Clicked");
        }

        #endregion Methods
    }
}