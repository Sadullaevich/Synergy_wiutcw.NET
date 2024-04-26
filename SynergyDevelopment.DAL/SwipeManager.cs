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
    public class SwipeManager : DbManager
    {
        //create a swipe to get data about swipes
        public void Create(Swipe sw)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
INSERT INTO sp_swipe
           (sp_emp_id_13781
           ,sp_date_13781
           ,sp_in_13781
           ,sp_out_13781)
     VALUES
           ('{sw.EmpId}'
           ,'{sw.Date}'
           ,'{sw.InTime.Ticks}'
           ,'{sw.OutTime.Ticks}')";

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

        public Swipe GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT sp_id_13781
      ,sp_emp_id_13781
      ,sp_date_13781
      ,sp_in_13781
      ,sp_out_13781
FROM sp_swipe
WHERE sp_id_13781 = {id}";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    if (reader.Read())
                    {
                        var sw = GetFromReader(reader);
                        return sw;
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


            return null;
        }

        public List<Swipe> GetAll()
        {
            var connection = Connection;
            var result = new List<Swipe>();
            try
            {
                var sql = @"
SELECT sp_id_13781
      ,sp_emp_id_13781
      ,sp_date_13781
      ,sp_in_13781
      ,sp_out_13781
FROM sp_swipe";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        var sw = GetFromReader(reader);
                        result.Add(sw);
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

        private Swipe GetFromReader(SQLiteDataReader reader)
        {
            Swipe sw = new Swipe
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                EmpId = Convert.ToInt32(reader.GetValue(1)),
                Date = new DateTime(Convert.ToInt64(reader.GetValue(2))),
                InTime = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                OutTime = new DateTime(Convert.ToInt64(reader.GetValue(4))),

            };

            return sw;
        }
    }
}
