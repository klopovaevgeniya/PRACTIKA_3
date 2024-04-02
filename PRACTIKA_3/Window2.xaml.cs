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
using System.Windows.Shapes;

namespace PRACTIKA_3
{
    public partial class Window2 : Window
    {
        private teremok1Entities1 zakazik = new teremok1Entities1 ();
        public Window2()
        {
            InitializeComponent();
            ZakazGrid.ItemsSource = zakazik.zakaz.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
