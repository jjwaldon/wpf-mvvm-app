using Project_PDB.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Project_PDB.Views
{

    public partial class Modifying : UserControl
    {
        ShopEntities db;

        public Modifying()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {



            db = new ShopEntities();
            Cgrid.ItemsSource = db.Customers.ToList();
            Egrid.ItemsSource = db.Employees.ToList();
            Ogrid.ItemsSource = db.Orders.ToList();


        }

        private void Add_Click_Customers(object sender, RoutedEventArgs e)
        {

            Customers save = new Customers();
            save.CustomerId = Convert.ToInt32(CustID.Text);
            save.Name = CompName.Text;
            save.Phone = CompPhone.Text;
            save.Email = ComEmail.Text;
            save.HasVIPStatus = Convert.ToBoolean(VIPStatus.Text);
            db.Customers.Add(save);
            db.SaveChanges();
            Cgrid.ItemsSource = db.Customers.ToList();


        }

        private void Delete_Click_Customers(object sender, RoutedEventArgs e)
        {

            int num = Convert.ToInt32(CustID.Text);
            var Drow = db.Customers.Where(w => w.CustomerId == num).FirstOrDefault();
            db.Customers.Remove(Drow);
            db.SaveChanges();
            Cgrid.ItemsSource = db.Customers.ToList();

        }

        private void Update_Click_Customers(object sender, RoutedEventArgs e)
        {

            int num = Convert.ToInt32(CustID.Text);
            var Urow = db.Customers.Where(w => w.CustomerId == num).FirstOrDefault();
            Urow.Name = CompName.Text;
            Urow.Phone = CompPhone.Text;
            Urow.Email = ComEmail.Text;
            Urow.HasVIPStatus = Convert.ToBoolean(VIPStatus.Text);
            db.SaveChanges();
            Cgrid.ItemsSource = db.Customers.ToList();

        }

        private void Add_Click_Employee(object sender, RoutedEventArgs e)
        {
            Employees save = new Employees();

            save.EmployeeId = Convert.ToInt32(EmploId.Text);
            save.Name = EmpName.Text;
            save.Title = EmpTitle.Text;
            save.Country = EmpCo.Text;
            save.IsWorkingRemotely = Convert.ToBoolean(IWR.Text);
            db.Employees.Add(save);
            db.SaveChanges();
            Egrid.ItemsSource = db.Employees.ToList();

        }

        private void Delete_Click_Employee(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(EmploId.Text);
            var Drow = db.Employees.Where(w => w.EmployeeId == num).FirstOrDefault();
            db.Employees.Remove(Drow);
            db.SaveChanges();
            Egrid.ItemsSource = db.Employees.ToList();

        }

        private void Update_Click_Employee(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(EmploId.Text);
            var Urow = db.Employees.Where(w => w.EmployeeId == num).FirstOrDefault();
            Urow.Name = EmpName.Text;
            Urow.Title = EmpTitle.Text;
            Urow.Country = EmpCo.Text;
            Urow.IsWorkingRemotely = Convert.ToBoolean(IWR.Text);
            db.SaveChanges();
            Egrid.ItemsSource = db.Employees.ToList();
        }

        private void Add_Click_Order(object sender, RoutedEventArgs e)
        {
            Orders save = new Orders();
            save.OrderId = Convert.ToInt32(OrdId.Text);
            save.CustomerOrderNumber = Convert.ToInt32(OrdNumber.Text);
            save.AssignedEmployee = Convert.ToInt32(AssNum.Text);
            save.OrderAmount = OrdCur.Text;
            save.AccountNumber = AccNum.Text;
            save.TransactionDate = TranDate.Text;
            save.IsVIPOrder = Convert.ToBoolean(IVO.Text);
            db.Orders.Add(save);
            db.SaveChanges();
            Ogrid.ItemsSource = db.Orders.ToList();

        }

        private void Delete_Click_Order(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(OrdId.Text);
            var Drow = db.Orders.Where(w => w.OrderId == num).FirstOrDefault();
            db.Orders.Remove(Drow);
            db.SaveChanges();
            Ogrid.ItemsSource = db.Orders.ToList();

        }

        private void Update_Click_Order(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(OrdId.Text);
            var Urow = db.Orders.Where(w => w.OrderId == num).FirstOrDefault();
            Urow.CustomerOrderNumber = Convert.ToInt32(OrdNumber.Text);
            Urow.AssignedEmployee = Convert.ToInt32(AssNum.Text);
            Urow.OrderAmount = OrdCur.Text;
            Urow.AccountNumber = AccNum.Text;
            Urow.TransactionDate = TranDate.Text;
            Urow.IsVIPOrder = Convert.ToBoolean(IVO.Text);
            db.SaveChanges();
            Ogrid.ItemsSource = db.Orders.ToList();
        }
    }
}
