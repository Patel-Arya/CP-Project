﻿
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aadhaarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gstnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accadddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDACCOUNTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dballDataSet1 = new WindowsFormsApp1.dballDataSet1();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.aDD_ACCOUNTTableAdapter1 = new WindowsFormsApp1.dballDataSet1TableAdapters.ADD_ACCOUNTTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDACCOUNTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dballDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accnameDataGridViewTextBoxColumn,
            this.typeofcustomerDataGridViewTextBoxColumn,
            this.openingbalanceDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.pincodeDataGridViewTextBoxColumn,
            this.phonenoDataGridViewTextBoxColumn,
            this.panDataGridViewTextBoxColumn,
            this.aadhaarDataGridViewTextBoxColumn,
            this.gstnoDataGridViewTextBoxColumn,
            this.accadddateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aDDACCOUNTBindingSource1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 316);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // accnameDataGridViewTextBoxColumn
            // 
            this.accnameDataGridViewTextBoxColumn.DataPropertyName = "acc_name";
            this.accnameDataGridViewTextBoxColumn.HeaderText = "acc_name";
            this.accnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accnameDataGridViewTextBoxColumn.Name = "accnameDataGridViewTextBoxColumn";
            this.accnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.accnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeofcustomerDataGridViewTextBoxColumn
            // 
            this.typeofcustomerDataGridViewTextBoxColumn.DataPropertyName = "type_of_customer";
            this.typeofcustomerDataGridViewTextBoxColumn.HeaderText = "type_of_customer";
            this.typeofcustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeofcustomerDataGridViewTextBoxColumn.Name = "typeofcustomerDataGridViewTextBoxColumn";
            this.typeofcustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeofcustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // openingbalanceDataGridViewTextBoxColumn
            // 
            this.openingbalanceDataGridViewTextBoxColumn.DataPropertyName = "opening_balance";
            this.openingbalanceDataGridViewTextBoxColumn.HeaderText = "opening_balance";
            this.openingbalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openingbalanceDataGridViewTextBoxColumn.Name = "openingbalanceDataGridViewTextBoxColumn";
            this.openingbalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.openingbalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // pincodeDataGridViewTextBoxColumn
            // 
            this.pincodeDataGridViewTextBoxColumn.DataPropertyName = "pincode";
            this.pincodeDataGridViewTextBoxColumn.HeaderText = "pincode";
            this.pincodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pincodeDataGridViewTextBoxColumn.Name = "pincodeDataGridViewTextBoxColumn";
            this.pincodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pincodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenoDataGridViewTextBoxColumn
            // 
            this.phonenoDataGridViewTextBoxColumn.DataPropertyName = "phone_no";
            this.phonenoDataGridViewTextBoxColumn.HeaderText = "phone_no";
            this.phonenoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenoDataGridViewTextBoxColumn.Name = "phonenoDataGridViewTextBoxColumn";
            this.phonenoDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenoDataGridViewTextBoxColumn.Width = 125;
            // 
            // panDataGridViewTextBoxColumn
            // 
            this.panDataGridViewTextBoxColumn.DataPropertyName = "pan";
            this.panDataGridViewTextBoxColumn.HeaderText = "pan";
            this.panDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.panDataGridViewTextBoxColumn.Name = "panDataGridViewTextBoxColumn";
            this.panDataGridViewTextBoxColumn.ReadOnly = true;
            this.panDataGridViewTextBoxColumn.Width = 125;
            // 
            // aadhaarDataGridViewTextBoxColumn
            // 
            this.aadhaarDataGridViewTextBoxColumn.DataPropertyName = "aadhaar";
            this.aadhaarDataGridViewTextBoxColumn.HeaderText = "aadhaar";
            this.aadhaarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aadhaarDataGridViewTextBoxColumn.Name = "aadhaarDataGridViewTextBoxColumn";
            this.aadhaarDataGridViewTextBoxColumn.ReadOnly = true;
            this.aadhaarDataGridViewTextBoxColumn.Width = 125;
            // 
            // gstnoDataGridViewTextBoxColumn
            // 
            this.gstnoDataGridViewTextBoxColumn.DataPropertyName = "gst_no";
            this.gstnoDataGridViewTextBoxColumn.HeaderText = "gst_no";
            this.gstnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gstnoDataGridViewTextBoxColumn.Name = "gstnoDataGridViewTextBoxColumn";
            this.gstnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.gstnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // accadddateDataGridViewTextBoxColumn
            // 
            this.accadddateDataGridViewTextBoxColumn.DataPropertyName = "acc_add_date";
            this.accadddateDataGridViewTextBoxColumn.HeaderText = "acc_add_date";
            this.accadddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accadddateDataGridViewTextBoxColumn.Name = "accadddateDataGridViewTextBoxColumn";
            this.accadddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.accadddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDDACCOUNTBindingSource1
            // 
            this.aDDACCOUNTBindingSource1.DataMember = "ADD_ACCOUNT";
            this.aDDACCOUNTBindingSource1.DataSource = this.dballDataSet1;
            // 
            // dballDataSet1
            // 
            this.dballDataSet1.DataSetName = "dballDataSet1";
            this.dballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox
            // 
            this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox.DataSource = this.aDDACCOUNTBindingSource1;
            this.comboBox.DisplayMember = "acc_name";
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(137, 30);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(737, 27);
            this.comboBox.TabIndex = 4;
            this.comboBox.ValueMember = "acc_name";
            // 
            // aDD_ACCOUNTTableAdapter1
            // 
            this.aDD_ACCOUNTTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(966, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDACCOUNTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dballDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox;
        private dballDataSet1 dballDataSet1;
        private System.Windows.Forms.BindingSource aDDACCOUNTBindingSource1;
        private dballDataSet1TableAdapters.ADD_ACCOUNTTableAdapter aDD_ACCOUNTTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn panDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aadhaarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gstnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accadddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}