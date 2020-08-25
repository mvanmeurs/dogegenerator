using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace dogegenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImageBrush brush;
        public MainWindow()
        {
            InitializeComponent();

            brush = new ImageBrush
            {
                Opacity = 0
            };
            canvas.Background = brush;

            CreateComboBox();

            dropdown.SelectionChanged += dropdown_SelectionChanged;

        }

        private void CreateComboBox()
        {
            dropdown.Items.Add("BlanketPuppers");
            dropdown.Items.Add("CouchPotatoe");
            dropdown.Items.Add("LazyWoofer");
            dropdown.Items.Add("SnoozingDoggo");
            dropdown.Items.Add("SnowyDoge");
            dropdown.Items.Add("WinterDoggo");
        }

        private void dropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            brush.ImageSource = new BitmapImage(new Uri("../../Img/" + dropdown.SelectedValue.ToString() + ".jpg", UriKind.Relative));
            brush.Opacity = 100;
        }
    }
}
