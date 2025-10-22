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

namespace Sport
{
    /// <summary>
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        string _name;
        public DataPage(string name)
        {
            _name = name;
            InitializeComponent();
            LoadPage();
        }

        private void LoadPage()
        {
            NameTextBlock.Text = $"❮ {_name}" ;

            //sql
        }

        private void BackBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
                mainWindow.Frame.Content = null;
        }
    }
}
