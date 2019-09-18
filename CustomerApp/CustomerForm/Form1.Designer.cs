namespace CustomerForm
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
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnlistCust = new System.Windows.Forms.Button();
            this.btnclearList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bTNdelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(52, 23);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(116, 13);
            this.lblsearch.TabIndex = 0;
            this.lblsearch.Text = "Enter Customer Name: ";
            this.lblsearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(54, 50);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(192, 20);
            this.txtsearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(252, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(57, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 212);
            this.listBox1.TabIndex = 3;
            // 
            // btnlistCust
            // 
            this.btnlistCust.Location = new System.Drawing.Point(58, 329);
            this.btnlistCust.Name = "btnlistCust";
            this.btnlistCust.Size = new System.Drawing.Size(160, 39);
            this.btnlistCust.TabIndex = 4;
            this.btnlistCust.Text = "LIST CUSTOMERS";
            this.btnlistCust.UseVisualStyleBackColor = true;
            // 
            // btnclearList
            // 
            this.btnclearList.Location = new System.Drawing.Point(230, 329);
            this.btnclearList.Name = "btnclearList";
            this.btnclearList.Size = new System.Drawing.Size(154, 38);
            this.btnclearList.TabIndex = 5;
            this.btnclearList.Text = "CLEAR LIST";
            this.btnclearList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(503, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 39);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CustomerDetails:";
            // 
            // bTNdelete
            // 
            this.bTNdelete.Location = new System.Drawing.Point(428, 329);
            this.bTNdelete.Name = "bTNdelete";
            this.bTNdelete.Size = new System.Drawing.Size(141, 37);
            this.bTNdelete.TabIndex = 7;
            this.bTNdelete.Text = "DELETE";
            this.bTNdelete.UseVisualStyleBackColor = true;
            this.bTNdelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(589, 329);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(133, 36);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(428, 288);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 35);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(592, 288);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(129, 34);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.bTNdelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnclearList);
            this.Controls.Add(this.btnlistCust);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnlistCust;
        private System.Windows.Forms.Button btnclearList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bTNdelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
    }
}

