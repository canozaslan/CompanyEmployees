
namespace Company_Employees
{
    partial class EmployeeScreen
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
            this.table_employee = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_department = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_warning = new System.Windows.Forms.Label();
            this.button_add_employee = new System.Windows.Forms.Button();
            this.button_update_employee = new System.Windows.Forms.Button();
            this.button_delete_employee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_search_category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // table_employee
            // 
            this.table_employee.AllowUserToAddRows = false;
            this.table_employee.AllowUserToDeleteRows = false;
            this.table_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_employee.Location = new System.Drawing.Point(55, 319);
            this.table_employee.Name = "table_employee";
            this.table_employee.Size = new System.Drawing.Size(693, 180);
            this.table_employee.TabIndex = 0;
            this.table_employee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_employee_RowHeaderMouseClick);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(220, 13);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(528, 20);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            this.tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyUp);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(135, 87);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(283, 20);
            this.tb_name.TabIndex = 2;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(135, 124);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(283, 20);
            this.tb_surname.TabIndex = 3;
            // 
            // tb_department
            // 
            this.tb_department.Location = new System.Drawing.Point(135, 169);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(283, 20);
            this.tb_department.TabIndex = 4;
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(135, 212);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(283, 20);
            this.tb_salary.TabIndex = 5;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(52, 90);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(26, 13);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Ad: ";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(52, 127);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(43, 13);
            this.label_surname.TabIndex = 7;
            this.label_surname.Text = "Soyad: ";
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Location = new System.Drawing.Point(52, 172);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(65, 13);
            this.label_department.TabIndex = 8;
            this.label_department.Text = "Departman: ";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(52, 212);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(39, 13);
            this.label_salary.TabIndex = 9;
            this.label_salary.Text = "Maaş: ";
            // 
            // label_warning
            // 
            this.label_warning.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(60, 268);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(688, 31);
            this.label_warning.TabIndex = 10;
            // 
            // button_add_employee
            // 
            this.button_add_employee.Location = new System.Drawing.Point(549, 76);
            this.button_add_employee.Name = "button_add_employee";
            this.button_add_employee.Size = new System.Drawing.Size(161, 41);
            this.button_add_employee.TabIndex = 11;
            this.button_add_employee.Text = "Çalışan Ekle";
            this.button_add_employee.UseVisualStyleBackColor = true;
            this.button_add_employee.Click += new System.EventHandler(this.button_add_employee_Click);
            // 
            // button_update_employee
            // 
            this.button_update_employee.Location = new System.Drawing.Point(549, 144);
            this.button_update_employee.Name = "button_update_employee";
            this.button_update_employee.Size = new System.Drawing.Size(161, 41);
            this.button_update_employee.TabIndex = 12;
            this.button_update_employee.Text = "Çalışanı Güncelle";
            this.button_update_employee.UseVisualStyleBackColor = true;
            this.button_update_employee.Click += new System.EventHandler(this.button_update_employee_Click);
            // 
            // button_delete_employee
            // 
            this.button_delete_employee.Location = new System.Drawing.Point(549, 201);
            this.button_delete_employee.Name = "button_delete_employee";
            this.button_delete_employee.Size = new System.Drawing.Size(161, 41);
            this.button_delete_employee.TabIndex = 13;
            this.button_delete_employee.Text = "Çalışanı Sil";
            this.button_delete_employee.UseVisualStyleBackColor = true;
            this.button_delete_employee.Click += new System.EventHandler(this.button_delete_employee_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 2);
            this.label1.TabIndex = 14;
            // 
            // cb_search_category
            // 
            this.cb_search_category.FormattingEnabled = true;
            this.cb_search_category.Location = new System.Drawing.Point(39, 12);
            this.cb_search_category.Name = "cb_search_category";
            this.cb_search_category.Size = new System.Drawing.Size(150, 21);
            this.cb_search_category.TabIndex = 15;
            // 
            // EmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.cb_search_category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete_employee);
            this.Controls.Add(this.button_update_employee);
            this.Controls.Add(this.button_add_employee);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.label_department);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_department);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.table_employee);
            this.Name = "EmployeeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeScreen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.table_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_employee;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_department;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_department;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Button button_add_employee;
        private System.Windows.Forms.Button button_update_employee;
        private System.Windows.Forms.Button button_delete_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_search_category;
    }
}