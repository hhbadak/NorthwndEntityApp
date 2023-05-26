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
                                 select new { ID = x.CategoryID, Isim = x.CategoryName, Aciklama = x.Description};
            dgv_list.DataSource = categoriesList.ToList();
        }

        private void TSMI_products_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_suppliers_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_customers_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_employees_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_orders_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_regions_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_shippers_Click(object sender, EventArgs e)
        {

        }
    }
}
