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
using PRACTIKA_3.teremok1DataSetTableAdapters;

namespace PRACTIKA_3
{
    public partial class Window1 : Window
    {
        zakazTableAdapter zakazik = new zakazTableAdapter();

        public Window1()
        {
            InitializeComponent(); 
            ZakazGrid.ItemsSource = zakazik.GetFullInfo1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
