using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Employees
{
    class EmployeeOperations
    {
        static Database database = new Database();
        public EmployeeOperations()
        {
            database.Open();
            
        }

        public bool login(string userName, string password)
        {
            MySqlCommand cmd = database.conn.CreateCommand();
            string query = $"Select * From adminler where username = '{userName}' and password = {password}";

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        public void AddEmployee(string name, string surname, string department, string salary)
        {
            
            MySqlCommand cmd = database.conn.CreateCommand();
            string query = $"Insert into calisanlar (ad, soyad, departman, maas) Values('{name}','{surname}','{department}',{salary})";

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal void DeleteEmployee(string selectedId)
        {
            MySqlCommand cmd = database.conn.CreateCommand();
            string query = $"Delete from calisanlar where id = {selectedId}";

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal void UpdateEmployee(string selectedId, string name, string surname, string department, string salary)
        {
            MySqlCommand cmd = database.conn.CreateCommand();
            string query = $"Update calisanlar set ad = '{name}', soyad = '{surname}', departman = '{department}', maas = '{salary}' where id = {selectedId}";

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
