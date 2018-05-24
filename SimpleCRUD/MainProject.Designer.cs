namespace SimpleCRUD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lName = new System.Windows.Forms.Label();
            this.lState = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.nameStateDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameStateDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameStateDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nameStateDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchDropDwn = new System.Windows.Forms.ComboBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.custInforecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lNumber = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.laadhar = new System.Windows.Forms.Label();
            this.lNetwork = new System.Windows.Forms.Label();
            this.txt_aadhar = new System.Windows.Forms.TextBox();
            this.txt_ntwrk = new System.Windows.Forms.TextBox();
            this.custInforecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aadharNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custInforecordBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.custInfoDataSet = new SimpleCRUD.CustInfoDataSet();
            this.custInfo_recordTableAdapter = new SimpleCRUD.CustInfoDataSetTableAdapters.CustInfo_recordTableAdapter();
            this.orderBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AscDesc = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nameStateDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameStateDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameStateDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameStateDataSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInforecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInforecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInforecordBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInfoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(38, 43);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(69, 20);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name :";
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Location = new System.Drawing.Point(38, 103);
            this.lState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(65, 20);
            this.lState.TabIndex = 1;
            this.lState.Text = "State :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(208, 36);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(182, 27);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_State
            // 
            this.txt_State.Location = new System.Drawing.Point(208, 97);
            this.txt_State.Margin = new System.Windows.Forms.Padding(4);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(182, 27);
            this.txt_State.TabIndex = 3;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(492, 16);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(121, 29);
            this.btn_Insert.TabIndex = 5;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(640, 16);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(128, 30);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(792, 18);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(117, 28);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // SearchDropDwn
            // 
            this.SearchDropDwn.AllowDrop = true;
            this.SearchDropDwn.FormattingEnabled = true;
            this.SearchDropDwn.Items.AddRange(new object[] {
            "Name",
            "Phone_Number"});
            this.SearchDropDwn.Location = new System.Drawing.Point(12, 13);
            this.SearchDropDwn.Name = "SearchDropDwn";
            this.SearchDropDwn.Size = new System.Drawing.Size(121, 28);
            this.SearchDropDwn.TabIndex = 9;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(139, 14);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(163, 27);
            this.searchText.TabIndex = 10;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(308, 14);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 27);
            this.go.TabIndex = 11;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(938, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 587);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "Instructions";
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(38, 159);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(102, 20);
            this.lNumber.TabIndex = 15;
            this.lNumber.Text = "Phone No :";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(208, 156);
            this.txt_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_number.MaxLength = 10;
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(182, 27);
            this.txt_number.TabIndex = 16;
            // 
            // laadhar
            // 
            this.laadhar.AutoSize = true;
            this.laadhar.Location = new System.Drawing.Point(443, 39);
            this.laadhar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laadhar.Name = "laadhar";
            this.laadhar.Size = new System.Drawing.Size(114, 20);
            this.laadhar.TabIndex = 17;
            this.laadhar.Text = "Aadhar No. :";
            // 
            // lNetwork
            // 
            this.lNetwork.AutoSize = true;
            this.lNetwork.Location = new System.Drawing.Point(443, 100);
            this.lNetwork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNetwork.Name = "lNetwork";
            this.lNetwork.Size = new System.Drawing.Size(163, 20);
            this.lNetwork.TabIndex = 18;
            this.lNetwork.Text = "Network provider :";
            // 
            // txt_aadhar
            // 
            this.txt_aadhar.Location = new System.Drawing.Point(614, 36);
            this.txt_aadhar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aadhar.MaxLength = 12;
            this.txt_aadhar.Name = "txt_aadhar";
            this.txt_aadhar.Size = new System.Drawing.Size(182, 27);
            this.txt_aadhar.TabIndex = 19;
            // 
            // txt_ntwrk
            // 
            this.txt_ntwrk.Location = new System.Drawing.Point(614, 100);
            this.txt_ntwrk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ntwrk.Name = "txt_ntwrk";
            this.txt_ntwrk.Size = new System.Drawing.Size(182, 27);
            this.txt_ntwrk.TabIndex = 20;
            // 
            // tableDataGrid
            // 
            this.tableDataGrid.AutoGenerateColumns = false;
            this.tableDataGrid.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.tableDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.aadharNumberDataGridViewTextBoxColumn,
            this.networkProviderDataGridViewTextBoxColumn});
            this.tableDataGrid.DataSource = this.custInforecordBindingSource2;
            this.tableDataGrid.Location = new System.Drawing.Point(373, 437);
            this.tableDataGrid.Name = "tableDataGrid";
            this.tableDataGrid.RowTemplate.Height = 24;
            this.tableDataGrid.Size = new System.Drawing.Size(814, 150);
            this.tableDataGrid.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // aadharNumberDataGridViewTextBoxColumn
            // 
            this.aadharNumberDataGridViewTextBoxColumn.DataPropertyName = "Aadhar_Number";
            this.aadharNumberDataGridViewTextBoxColumn.HeaderText = "Aadhar_Number";
            this.aadharNumberDataGridViewTextBoxColumn.Name = "aadharNumberDataGridViewTextBoxColumn";
            this.aadharNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // networkProviderDataGridViewTextBoxColumn
            // 
            this.networkProviderDataGridViewTextBoxColumn.DataPropertyName = "Network_Provider";
            this.networkProviderDataGridViewTextBoxColumn.HeaderText = "Network_Provider";
            this.networkProviderDataGridViewTextBoxColumn.Name = "networkProviderDataGridViewTextBoxColumn";
            this.networkProviderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custInforecordBindingSource2
            // 
            this.custInforecordBindingSource2.DataMember = "CustInfo_record";
            this.custInforecordBindingSource2.DataSource = this.custInfoDataSet;
            // 
            // custInfoDataSet
            // 
            this.custInfoDataSet.DataSetName = "CustInfoDataSet";
            this.custInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custInfo_recordTableAdapter
            // 
            this.custInfo_recordTableAdapter.ClearBeforeFill = true;
            // 
            // orderBy
            // 
            this.orderBy.AllowDrop = true;
            this.orderBy.FormattingEnabled = true;
            this.orderBy.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone Number",
            "State",
            "Aadhar Number",
            "Network Provider"});
            this.orderBy.Location = new System.Drawing.Point(1029, 394);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(121, 28);
            this.orderBy.TabIndex = 22;
            this.orderBy.SelectedIndexChanged += new System.EventHandler(this.orderBy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Order By :";
            // 
            // AscDesc
            // 
            this.AscDesc.Location = new System.Drawing.Point(1156, 394);
            this.AscDesc.Name = "AscDesc";
            this.AscDesc.Size = new System.Drawing.Size(31, 28);
            this.AscDesc.TabIndex = 24;
            this.AscDesc.Text = "↑";
            this.AscDesc.UseVisualStyleBackColor = true;
            this.AscDesc.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorBox
            // 
            this.errorBox.AllowDrop = true;
            this.errorBox.BackColor = System.Drawing.Color.YellowGreen;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(127, 231);
            this.errorBox.Multiline = true;
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(594, 81);
            this.errorBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.SearchDropDwn);
            this.panel1.Controls.Add(this.searchText);
            this.panel1.Controls.Add(this.go);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Insert);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 56);
            this.panel1.TabIndex = 28;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(1079, 20);
            this.user_name.Name = "user_name";
            this.user_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user_name.Size = new System.Drawing.Size(86, 20);
            this.user_name.TabIndex = 13;
            this.user_name.Text = "Welcome";
            this.user_name.Click += new System.EventHandler(this.userName_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.txt_aadhar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.laadhar);
            this.panel2.Controls.Add(this.txt_ntwrk);
            this.panel2.Controls.Add(this.lNetwork);
            this.panel2.Controls.Add(this.lNumber);
            this.panel2.Controls.Add(this.txt_number);
            this.panel2.Controls.Add(this.txt_Name);
            this.panel2.Controls.Add(this.txt_State);
            this.panel2.Controls.Add(this.lName);
            this.panel2.Controls.Add(this.lState);
            this.panel2.Controls.Add(this.errorBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(357, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 587);
            this.panel2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "*";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1239, 679);
            this.Controls.Add(this.AscDesc);
            this.Controls.Add(this.orderBy);
            this.Controls.Add(this.tableDataGrid);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameStateDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameStateDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameStateDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameStateDataSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInforecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInforecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInforecordBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInfoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_State;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.BindingSource nameStateDataSetBindingSource;
        private System.Windows.Forms.BindingSource nameStateDataSetBindingSource1;
        private System.Windows.Forms.BindingSource nameStateDataSetBindingSource2;
        private System.Windows.Forms.BindingSource nameStateDataSetBindingSource3;
        private System.Windows.Forms.BindingSource tblrecordBindingSource;
#pragma warning disable CS0169 // The field 'frmMain.idDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'frmMain.idDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'frmMain.nameDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'frmMain.nameDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'frmMain.stateDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'frmMain.stateDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.ComboBox SearchDropDwn;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource custInforecordBindingSource;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label laadhar;
        private System.Windows.Forms.Label lNetwork;
        private System.Windows.Forms.TextBox txt_aadhar;
        private System.Windows.Forms.TextBox txt_ntwrk;
        private System.Windows.Forms.BindingSource custInforecordBindingSource1;
        private System.Windows.Forms.DataGridView tableDataGrid;
        private CustInfoDataSet custInfoDataSet;
        private System.Windows.Forms.BindingSource custInforecordBindingSource2;
        private CustInfoDataSetTableAdapters.CustInfo_recordTableAdapter custInfo_recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aadharNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkProviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox orderBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AscDesc;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label user_name;
    }
}

