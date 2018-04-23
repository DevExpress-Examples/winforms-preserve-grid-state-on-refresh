using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication97 {
    public partial class Form1 : Form {
        RefreshHelper helper;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            this.order_DetailsTableAdapter1.Fill(this.nwindDataSet.Order_Details);
            helper = new RefreshHelper(gridView1, "CustomerID");
        }

        private void button1_Click(object sender, EventArgs e) {
            helper.SaveViewInfo();     
        }

        private void button2_Click(object sender, EventArgs e) {
            helper.LoadViewInfo();
        }
    }
}
