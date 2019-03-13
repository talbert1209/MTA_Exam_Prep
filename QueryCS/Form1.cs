using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (textBox.TextLength > 0)
            {
                SelectData(textBox.Text);
            }
        }

        private void SelectData(string selectCommandText)
        {
            try
            {
                string selectConnection =
                    @"Data Source=LT-MK-G4386S2;Initial Catalog=Northwind;Integrated Security=True";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandText, selectConnection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
