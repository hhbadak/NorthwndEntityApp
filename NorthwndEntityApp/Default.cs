using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwndEntityApp
{
    public partial class Default : Form
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public Default()
        {
            InitializeComponent();
        }
        private void TSMI_categories_Click(object sender, EventArgs e)
        {
            var categoriesList = from x in db.Categories
                                 select new { KategoriSırası = x.CategoryID, Isim = x.CategoryName, Aciklama = x.Description };
            dgv_list.DataSource = categoriesList.ToList();
        }

        private void TSMI_products_Click(object sender, EventArgs e)
        {
            var productList = from x in db.Products
                              where x.Discontinued == true
                              select new { ÜrünNumarası = x.ProductID, ÜrünAdı = x.ProductName, Fiyat = x.UnitPrice + " ₺" };
            dgv_list.DataSource = productList.ToList();
        }

        private void TSMI_suppliers_Click(object sender, EventArgs e)
        {
            var supplierList = from x in db.Suppliers
                               select new { TedarikçiNumarası = x.SupplierID, ŞirketAdı = x.CompanyName, KişiAdı = x.ContactName, Şehir = x.City, Ülke = x.Country };
            dgv_list.DataSource = supplierList.ToList();
        }

        private void TSMI_customers_Click(object sender, EventArgs e)
        {
            var customerList = from x in db.Customers
                               select new { MüşteriNumarası = x.CustomerID, ŞirketAdı = x.CompanyName, KişiAdı = x.ContactName, Şehir = x.City, Ülke = x.Country };
            dgv_list.DataSource= customerList.ToList();
        }

        private void TSMI_employees_Click(object sender, EventArgs e)
        {
            var employeeList = from x in db.Employees
                               select new { ÇalışanNumarası = x.EmployeeID, Adı = x.FirstName, Soyadı = x.LastName, DoğumTarihi = x.BirthDate, Şehir = x.City };
            dgv_list.DataSource = employeeList.ToList();
        }

        private void TSMI_orders_Click(object sender, EventArgs e)
        {
            var orderList = from x in db.Orders
                             where x.Freight > 100
                             select new {SiparişNumarası = x.OrderID, MüşteriAdı = x.Customers.ContactName, SatışYapanPersonel = x.Employees.FirstName, SatışTarihi = x.OrderDate, TedarikçiŞirket = x.Shippers.CompanyName  };
            dgv_list.DataSource = orderList.ToList();
        }

        private void TSMI_regions_Click(object sender, EventArgs e)
        {
            var regionList = from x in db.Region
                             select new { BölgeSırası = x.RegionID, BölgeAdı = x.RegionDescription };
            dgv_list.DataSource = regionList.ToList();
        }

        private void TSMI_shippers_Click(object sender, EventArgs e)
        {
            var shipperList = from x in db.Shippers
                              select new {NakliyatçıNumarası = x.ShipperID, NakliyeciŞirket = x.CompanyName };
            dgv_list.DataSource = shipperList.ToList();
        }
    }
}
