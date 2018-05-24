using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SimpleCRUD
{

    public partial class frmMain : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual_Studio_project\SimpleCRUD\SimpleCRUD\CustInfo.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        private static string errorMessage = "";
        private static int errorBoxHeight = 0;

        int ID = 0;
        public frmMain()
        {
            InitializeComponent();
            user_name.Text = "Welcome " +Login.loginName;
            SearchDropDwn.Text = "Name";
            orderBy.Text = "ID";
            errorBox.Visible = false;
            errorBox.Height = 0;
            tableDataGrid.Columns[0].Width = 50;
            tableDataGrid.Columns[5].Width = tableDataGrid.Columns[4].Width = tableDataGrid.Columns[3].Width = tableDataGrid.Columns[2].Width = 150;
            SearchDropDwn.DropDownStyle = ComboBoxStyle.DropDownList;
            orderBy.DropDownStyle = ComboBoxStyle.DropDownList;
            DisplayData();
            tableDataGrid.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_number.Text != "")
            {
                if (!validateTextBox())
                {
                    errorBox.Visible = true;
                    errorBox.Height = errorBoxHeight;
                    errorBox.Text = errorMessage;
                }
                else
                {
                    errorBox.Visible = false;
                    cmd = new SqlCommand("insert into CustInfo_record(Name,State,Phone_Number,Aadhar_Number, Network_Provider) values(@name,@state,@number,@aadhar,@network)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@state", txt_State.Text);
                    cmd.Parameters.AddWithValue("@number", txt_number.Text);
                    cmd.Parameters.AddWithValue("@aadhar", txt_aadhar.Text);
                    cmd.Parameters.AddWithValue("@network", txt_ntwrk.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                    DisplayData();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from CustInfo_record", con);
            adapt.Fill(dt);
            tableDataGrid.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            txt_Name.Text = "";
            txt_State.Text = "";
            txt_number.Text = "";
            txt_aadhar.Text = "";
            txt_ntwrk.Text = "";
            ID = 0;
            errorBox.Text = "";
            errorBoxHeight = 0;
            searchText.Text = "";
            SearchDropDwn.Text = "Name";
            orderBy.Text = "ID";
            btn_Insert.Enabled = true;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_number.Text != "")
            {
                if (!validateTextBox())
                {
                    errorBox.Visible = true;
                    errorBox.Height = errorBoxHeight;
                    errorBox.Text = errorMessage;

                }
                else
                {
                    errorBox.Visible = false;
                    cmd = new SqlCommand("update CustInfo_record set Name=@name,State=@state,Phone_Number=@number,Aadhar_Number=@aadhar,Network_Provider=@network where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@state", txt_State.Text);
                    cmd.Parameters.AddWithValue("@number", txt_number.Text);
                    cmd.Parameters.AddWithValue("@aadhar", txt_aadhar.Text);
                    cmd.Parameters.AddWithValue("@network", txt_ntwrk.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    DisplayData();
                    ClearData();
                }

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
            btn_Insert.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete CustInfo_record where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
                btn_Insert.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            btn_Insert.Enabled = true;
        }

        //dataGridView1 RowHeaderMouseClick Event  
        private void OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(tableDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = tableDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_State.Text = tableDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_aadhar.Text = tableDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_number.Text = tableDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ntwrk.Text = tableDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

            btn_Insert.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'custInfoDataSet.CustInfo_record' table. You can move, or remove it, as needed.
            this.custInfo_recordTableAdapter.Fill(this.custInfoDataSet.CustInfo_record);
            // TODO: This line of code loads data into the 'custInfoDataSet.CustInfo_record' table. You can move, or remove it, as needed.
            this.custInfo_recordTableAdapter.Fill(this.custInfoDataSet.CustInfo_record);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //adapt = new SqlDataAdapter("select * from tbl_Record", con);
            if (SearchDropDwn.Text != "" && searchText.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from CustInfo_record", con);
                adapt.Fill(dt);

                DataView dataView = dt.DefaultView;
                dataView.RowFilter = SearchDropDwn.Text+" LIKE '%" + searchText.Text + "%'";
                tableDataGrid.DataSource = dataView;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Somrthing in search bar to Search");
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayData();
            ClearData();
        }

        private void orderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderBySelectedDataType();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(AscDesc.Text == "↑")
            {
                AscDesc.Text = "↓";
            }
            else
            {
                AscDesc.Text = "↑";
            }
            orderBySelectedDataType();
        }

        private void orderBySelectedDataType()
        {
            string orderbyCol = orderBy.Text;
            string sql = "select * from CustInfo_record order by " + ((int)orderBy.SelectedIndex + 1);
            if (AscDesc.Text == "↑")
            {
                sql = sql + " desc";
            }
            else
            {
                sql = sql + " asc";
            }

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            tableDataGrid.DataSource = dt;
            con.Close();
        }
        
        private Boolean validateTextBox()
        {
            errorMessage = "";
            errorBoxHeight = 0;
            bool valid = true;
            if(txt_Name.Text.Length < 3 || !IsCharsOnly(txt_Name.Text)) {
                errorMessage += "* Name Should be greater than 3 alphabet and string only!"+ System.Environment.NewLine;
                errorBoxHeight += 27;
                valid = false;
            }

            if(txt_number.Text.Length != 10 || !IsDigitsOnly(txt_number.Text)){
                errorMessage += "* Phone Number should be 10 digit and number only!"+ System.Environment.NewLine;
                errorBoxHeight += 27;
                valid = false;
            }

            if (txt_aadhar.Text.Length != 12 || !IsDigitsOnly(txt_aadhar.Text)) {
                errorMessage += "* Aadhar Number should be 12 digit and number only!"+ System.Environment.NewLine;
                errorBoxHeight += 27;
                valid = false; }

            if (txt_State.Text.Length < 2 || !IsCharsOnly(txt_State.Text)) {
                errorMessage += "* State name should be greater than 2 alphabet and string only!" + System.Environment.NewLine;
                errorBoxHeight += 27;
                valid = false; }
            return valid;
        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        static bool IsCharsOnly(string str)
        {
            foreach (char c in str.ToLower().Replace(" ", String.Empty))
            {
                if (c < 'a' || c > 'z')
                    return false;
            }

            return true;
        }

        private void userName_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to log off", "Log Off",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                Login login = new Login();
                login.Show();
                Hide();
            }
        }
    }
}
