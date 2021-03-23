using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Employees
{
    public partial class EmployeeScreen : Form
    {
        EmployeeOperations operations = new EmployeeOperations();
        Database db = new Database();
        DataTable model = new DataTable();
        DataGridViewRow row;
        public EmployeeScreen()
        {
            InitializeComponent();
            showEmployees();
            AddHeaders();
        }
        public void AddHeaders()
        {
            List<string> headers = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                headers.Add(table_employee.Columns[i].HeaderText.ToString());              
            }
            cb_search_category.DataSource = headers;
        }
        public void showEmployees()
        {
            db.Open();
            MySqlCommand cmd = db.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            model.Clear();
            string query = "Select * From calisanlar";
            try
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(model);
                table_employee.DataSource = model;
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
        private void button_add_employee_Click(object sender, EventArgs e)
        {
            label_warning.Text = "";

            string name = tb_name.Text;
            string surname = tb_surname.Text;
            string department = tb_department.Text;
            string salary = tb_salary.Text;

            operations.AddEmployee(name,surname,department,salary);
            showEmployees();
            label_warning.Text = "Yeni bir çalışan eklendi.";
            ClearFields();

        }

        private void table_employee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            row = table_employee.Rows[selectedRow];
            tb_name.Text = row.Cells[1].Value.ToString();
            tb_surname.Text = row.Cells[2].Value.ToString();
            tb_department.Text = row.Cells[3].Value.ToString();
            tb_salary.Text = row.Cells[4].Value.ToString();
        }

        private void button_delete_employee_Click(object sender, EventArgs e)
        {
            label_warning.Text = "";

            string selectedId = row.Cells[0].Value.ToString();

            if (selectedId == null)
            {
                if(table_employee.Rows.Count == 0)
                {
                    label_warning.Text = "Çalışan tablosu şu anda boş.";
                }
                else
                {
                    label_warning.Text = "Silinecek bir çalışan seçin.";
                }
            }
            else
            {
                operations.DeleteEmployee(selectedId);
                showEmployees();
                label_warning.Text = "Bir çalışan silindi.";
                ClearFields();
            }
        }

        private void ClearFields()
        {
            tb_name.Text = "";
            tb_surname.Text = "";
            tb_department.Text = "";
            tb_salary.Text = "";
        }

        private void button_update_employee_Click(object sender, EventArgs e)
        {
            label_warning.Text = "";

            string name = tb_name.Text;
            string surname = tb_surname.Text;
            string department = tb_department.Text;
            string salary = tb_salary.Text;

            string selectedId = row.Cells[0].Value.ToString();

            if (selectedId == null)
            {
                if (table_employee.Rows.Count == 0)
                {
                    label_warning.Text = "Çalışan tablosu şu anda boş.";
                }
                else
                {
                    label_warning.Text = "Güncellenecek bir çalışan seçin.";
                }
            }
            else
            {
                operations.UpdateEmployee(selectedId,name,surname,department,salary);
                showEmployees();
                label_warning.Text = "Bir çalışan başarıyla güncellendi.";
            }
        }

        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = model.DefaultView;
            if(cb_search_category.SelectedItem.Equals("id"))
            {
                if (tb_search.Text.Equals("")) {
                    dv.RowFilter = $"ad LIKE '{tb_search.Text.ToString()}%'";
                    table_employee.DataSource = dv;
                }
                else
                {
                    dv.RowFilter = $"{cb_search_category.SelectedItem} = {tb_search.Text.ToString()}";
                    table_employee.DataSource = dv;
                }
                
            }
            else
            {
                dv.RowFilter = $"{cb_search_category.SelectedItem} LIKE '{tb_search.Text.ToString()}%'";
                table_employee.DataSource = dv;
            }
            
        }

        private void EmployeeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
