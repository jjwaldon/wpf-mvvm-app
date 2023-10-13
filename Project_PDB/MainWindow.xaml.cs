using Project_PDB.Views;
using System.Windows;


namespace Project_PDB

{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void BtnClick1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Filtering();
        }
        private void BtnClick2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Modifying();
        }

        private void BtnClick3(object sender, RoutedEventArgs e)
        {
            Main.Content = new Modify_1_n();
        }

        
    }
}
