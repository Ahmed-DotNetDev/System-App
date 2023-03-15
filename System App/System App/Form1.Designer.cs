namespace System_App
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnedit = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnadd = new System.Windows.Forms.Button();
			this.textBoxlastname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxfirstname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(800, 450);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btnedit);
			this.panel1.Controls.Add(this.btndelete);
			this.panel1.Controls.Add(this.btnadd);
			this.panel1.Controls.Add(this.textBoxlastname);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBoxfirstname);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(0, 350);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 100);
			this.panel1.TabIndex = 1;
			// 
			// btnedit
			// 
			this.btnedit.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnedit.Location = new System.Drawing.Point(617, 50);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(75, 23);
			this.btnedit.TabIndex = 6;
			this.btnedit.Text = "Edit";
			this.btnedit.UseVisualStyleBackColor = false;
			this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
			// 
			// btndelete
			// 
			this.btndelete.BackColor = System.Drawing.SystemColors.Highlight;
			this.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btndelete.Location = new System.Drawing.Point(712, 50);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(75, 23);
			this.btndelete.TabIndex = 5;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = false;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// btnadd
			// 
			this.btnadd.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnadd.Location = new System.Drawing.Point(521, 50);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(75, 23);
			this.btnadd.TabIndex = 4;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = false;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// textBoxlastname
			// 
			this.textBoxlastname.BackColor = System.Drawing.Color.White;
			this.textBoxlastname.Location = new System.Drawing.Point(299, 49);
			this.textBoxlastname.Name = "textBoxlastname";
			this.textBoxlastname.Size = new System.Drawing.Size(142, 20);
			this.textBoxlastname.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(236, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name";
			// 
			// textBoxfirstname
			// 
			this.textBoxfirstname.BackColor = System.Drawing.Color.White;
			this.textBoxfirstname.Location = new System.Drawing.Point(76, 49);
			this.textBoxfirstname.Name = "textBoxfirstname";
			this.textBoxfirstname.Size = new System.Drawing.Size(142, 20);
			this.textBoxfirstname.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.TextBox textBoxlastname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxfirstname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnedit;
		private System.Windows.Forms.Button btndelete;
	}
}

