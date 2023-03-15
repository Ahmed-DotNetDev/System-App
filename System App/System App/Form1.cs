using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_App
{
	public partial class Form1 : Form
	{
		Database1Entities db;
		TB1 tbAdd;
		int id;
		public Form1()
		{
			InitializeComponent();
			Loading();
		}

		private void Loading()
		{
			try
			{
				db = new Database1Entities();
				dataGridView1.DataSource = db.TB1.ToList();
			}
			catch 
			{ 

			}
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			try
			{
				db = new Database1Entities();
				tbAdd = new TB1();
				tbAdd.First_Name = textBoxfirstname.Text;
				tbAdd.Last_Name = textBoxlastname.Text;
				db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
				db.SaveChanges();
				Loading();
				textBoxfirstname.Text = textBoxlastname.Text = "";
				MessageBox.Show("Adding Success");
			}
			catch (Exception)
			{

				MessageBox.Show("Adding Failed");
			}
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			try
			{
				db = new Database1Entities();
				tbAdd = new TB1();
				tbAdd.Id = id;
				tbAdd.First_Name = textBoxfirstname.Text;
				tbAdd.Last_Name = textBoxlastname.Text;
				db.Entry(tbAdd).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				Loading();
				textBoxfirstname.Text = textBoxlastname.Text = "";
				MessageBox.Show("Edit Success");
			}
			catch (Exception)
			{

				MessageBox.Show("Editing Failed");
			}
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
				textBoxfirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
				textBoxlastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			}
			catch 
			{

			}
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			try
			{
				db = new Database1Entities();
				tbAdd = new TB1();
				tbAdd.Id = id;
				tbAdd.First_Name = textBoxfirstname.Text;
				tbAdd.Last_Name = textBoxlastname.Text;
				db.Entry(tbAdd).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
				Loading();
				textBoxfirstname.Text = textBoxlastname.Text = "";
				MessageBox.Show("Delete Success");
			}
			catch (Exception)
			{

				MessageBox.Show("Deleting Failed");
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			}
			catch
			{

			}
		}
	}
}
