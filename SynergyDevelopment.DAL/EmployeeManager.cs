using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynergyDevelopment.DAL
{
    partial class EmployeeManager : DbManager
    {
        //employee manager to get data about employees
        public void Create(Employee e)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
INSERT INTO em_employee
           (em_name_13781
           ,em_is_active_13781
           ,em_start_date_13781
           ,em_discharge_date_13781)
     VALUES
           ('{e.Name}'
           ,{Convert.ToInt32(e.IsActive)}
           ,{e.StartDate.Ticks}
           ,{e.DischargeDate.Ticks}
)";

                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        public void Update(Employee e)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
UPDATE em_employee 
   SET em_name_13781 = '{e.Name}'
      ,em_is_active_13781 = {Convert.ToInt32(e.IsActive)}
      ,em_start_date_13781 = {e.StartDate.Ticks}
      ,em_discharge_date_13781 = {e.DischargeDate.Ticks}
WHERE em_id_13781 = {e.Id}";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM em_employee WHERE em_id_13781 = {id}";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public Employee GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT em_id_13781
      ,em_name_13781
      ,em_is_active_13781
      ,em_start_date_13781
      ,em_discharge_date_13781
FROM em_employee
WHERE em_id_13781 = {id}";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    if (reader.Read())
                    {
                        var e = GetFromReader(reader);
                        return e;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            // if we are here - something went wrong
            return null;
        }
        public List<Employee> GetAll()
        {
            var connection = Connection;
            var result = new List<Employee>();
            try
            {
                var sql = @"
SELECT em_id_13781
      ,em_name_13781
      ,em_is_active_13781
      ,em_start_date_13781
      ,em_discharge_date_13781
FROM em_employee";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        var e = GetFromReader(reader);
                        result.Add(e);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }

        private Employee GetFromReader(SQLiteDataReader reader)
        {
            var e = new Employee
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = reader.GetValue(1).ToString(),
                IsActive = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(2))),
                StartDate = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                DischargeDate = new DateTime(Convert.ToInt64(reader.GetValue(4))),
            };

            return e;
        }
    }
}

