using DevExpress.Xpf.Grid;
using Project_PDB.Model;
using System;
using System.Linq;
using System.Windows.Controls;

namespace Project_PDB.Views
{

    public partial class Filtering : UserControl
    {
        public Filtering()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
            LoadData2();
            LoadData3();
            LoadData4();
            LoadData5();
        }
        ShopEntities _Context;

        void LoadData()
        {
            _Context = new ShopEntities();
            grid.ItemsSource = _Context.Customers.ToList();
        }
        void OnDataSourceRefresh(object sender, DataSourceRefreshEventArgs e) { LoadData(); }
        ShopEntities _Context1;

        void LoadData1()
        {
            _Context1 = new ShopEntities();
            grid1.ItemsSource = _Context1.Employees.ToList();
        }
        void OnDataSourceRefresh1(object sender, DataSourceRefreshEventArgs e) { LoadData1(); }
        ShopEntities _Context2;

        void LoadData2()
        {
            _Context2 = new ShopEntities();
            grid2.ItemsSource = _Context2.Orders.ToList();
        }
        void OnDataSourceRefresh2(object sender, DataSourceRefreshEventArgs e) { LoadData2(); }
        ShopEntities _Context3;

        void LoadData3()
        {
            _Context3 = new ShopEntities();
            grid.ItemsSource = _Context3.Customers.ToList();
        }
        void OnDataSourceRefresh3(object sender, DataSourceRefreshEventArgs e) { LoadData3(); }
        ShopEntities _Context4;

        void LoadData4()
        {
            _Context4 = new ShopEntities();
            grid1.ItemsSource = _Context4.Employees.ToList();
        }
        void OnDataSourceRefresh4(object sender, DataSourceRefreshEventArgs e) { LoadData4(); }
        ShopEntities _Context5;

        void LoadData5()
        {
            _Context5 = new ShopEntities();
            grid2.ItemsSource = _Context5.Orders.ToList();
        }




    }
}
