using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using Project_PDB.Model;
using System.Collections.Generic;
using System.Linq;

namespace Project_PDB.ViewModels
{
    public class VM : ViewModelBase
    {
        ShopEntities _Context;
        IList<Customers> _ItemsSource;
        public IList<Customers> ItemsSource
        {
            get
            {
                if (_ItemsSource == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context = new ShopEntities();
                    _ItemsSource = _Context.Customers.ToList();
                }
                return _ItemsSource;
            }
        }
        [Command]
        public void DataSourceRefresh(DataSourceRefreshArgs args)
        {
            _ItemsSource = null;
            _Context = null;
            RaisePropertyChanged(nameof(ItemsSource));
        }
        ShopEntities _Context1;
        IList<Employees> _ItemsSource1;
        public IList<Employees> ItemsSource1
        {
            get
            {
                if (_ItemsSource1 == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context1 = new ShopEntities();
                    _ItemsSource1 = _Context1.Employees.ToList();
                }
                return _ItemsSource1;
            }
        }
        [Command]
        public void DataSourceRefresh1(DataSourceRefreshArgs args)
        {
            _ItemsSource1 = null;
            _Context1 = null;
            RaisePropertyChanged(nameof(ItemsSource1));
        }
        ShopEntities _Context2;
        IList<Orders> _ItemsSource2;
        public IList<Orders> ItemsSource2
        {
            get
            {
                if (_ItemsSource2 == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context2 = new ShopEntities();
                    _ItemsSource2 = _Context2.Orders.ToList();
                }
                return _ItemsSource2;
            }
        }
        [Command]
        public void DataSourceRefresh2(DataSourceRefreshArgs args)
        {
            _ItemsSource2 = null;
            _Context2 = null;
            RaisePropertyChanged(nameof(ItemsSource2));
        }
        ShopEntities _Context3;
        IList<Orders> _ItemsSource3;
        public IList<Orders> ItemsSource3
        {
            get
            {
                if (_ItemsSource3 == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context3 = new ShopEntities();
                    _ItemsSource3 = _Context3.Orders.ToList();
                }
                return _ItemsSource3;
            }
        }
        [Command]
        public void ValidateRow(RowValidationArgs args)
        {
            var item = (Orders)args.Item;
            if (args.IsNewItem)
                _Context3.Orders.Add(item);
            _Context3.SaveChanges();
        }
        [Command]
        public void ValidateRowDeletion(ValidateRowDeletionArgs args)
        {
            var item = (Orders)args.Items.Single();
            _Context3.Orders.Remove(item);
            _Context3.SaveChanges();
        }
        [Command]
        public void DataSourceRefresh3(DataSourceRefreshArgs args)
        {
            _ItemsSource3 = null;
            _Context3 = null;
            RaisePropertyChanged(nameof(ItemsSource3));
        }
        ShopEntities _Context4;
        IList<Orders> _ItemsSource4;
        public IList<Orders> ItemsSource4
        {
            get
            {
                if (_ItemsSource4 == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context4 = new ShopEntities();
                    _ItemsSource4 = _Context4.Orders.ToList();
                }
                return _ItemsSource4;
            }
        }
        [Command]
        public void ValidateRow1(RowValidationArgs args)
        {
            var item = (Orders)args.Item;
            if (args.IsNewItem)
                _Context4.Orders.Add(item);
            _Context4.SaveChanges();
        }
        [Command]
        public void ValidateRowDeletion1(ValidateRowDeletionArgs args)
        {
            var item = (Orders)args.Items.Single();
            _Context4.Orders.Remove(item);
            _Context4.SaveChanges();
        }
        [Command]
        public void DataSourceRefresh4(DataSourceRefreshArgs args)
        {
            _ItemsSource4 = null;
            _Context4 = null;
            RaisePropertyChanged(nameof(ItemsSource4));
        }
        ShopEntities _Context5;
        IList<Customers> _ItemsSource5;
        public IList<Customers> ItemsSource5
        {
            get
            {
                if (_ItemsSource5 == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context5 = new ShopEntities();
                    _ItemsSource5 = _Context5.Customers.ToList();
                }
                return _ItemsSource5;
            }
        }
        [Command]
        public void ValidateRow2(RowValidationArgs args)
        {
            var item = (Customers)args.Item;
            if (args.IsNewItem)
                _Context5.Customers.Add(item);
            _Context5.SaveChanges();
        }
        [Command]
        public void ValidateRowDeletion2(ValidateRowDeletionArgs args)
        {
            var item = (Customers)args.Items.Single();
            _Context5.Customers.Remove(item);
            _Context5.SaveChanges();
        }
        [Command]
        public void DataSourceRefresh5(DataSourceRefreshArgs args)
        {
            _ItemsSource5 = null;
            _Context5 = null;
            RaisePropertyChanged(nameof(ItemsSource5));
        }
        ShopEntities _Context6;
        IList<Orders> _ItemsSource6;
        public IList<Orders> ItemsSource6
        {
            get
            {
                if (_ItemsSource6 == null && !DevExpress.Mvvm.ViewModelBase.IsInDesignMode)
                {
                    _Context6 = new ShopEntities();
                    _ItemsSource6 = _Context6.Orders.ToList();
                }
                return _ItemsSource6;
            }
        }
        [Command]
        public void ValidateRow3(RowValidationArgs args)
        {
            var item = (Orders)args.Item;
            if (args.IsNewItem)
                _Context6.Orders.Add(item);
            _Context6.SaveChanges();
        }
        [Command]
        public void ValidateRowDeletion3(ValidateRowDeletionArgs args)
        {
            var item = (Orders)args.Items.Single();
            _Context6.Orders.Remove(item);
            _Context6.SaveChanges();
        }
        [Command]
        public void DataSourceRefresh6(DataSourceRefreshArgs args)
        {
            _ItemsSource6 = null;
            _Context6 = null;
            RaisePropertyChanged(nameof(ItemsSource6));
        }
    }
}
