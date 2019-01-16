using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connecioctionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Laurynas\Desktop\C_adv\C adv\SQLapp\SQLduomenubaze.mdf; Integrated Security = True";
            SqlConnection sql = new SqlConnection(connecioctionString);

            DateTime date = new DateTime(year: 2018, month: 11, day: 15);
            var datos = DateTime.Parse("2018-12-18");
            /*
            string querry = "INSERT INTO Students(Name, Surname, Phone, Email) Values(@Name, @Surname, @Phone, @Email)";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite Studento Varda, Pavarde, Telefono numeri ir email");
                var data = Console.ReadLine().Split(' ');

                using (SqlCommand command = new SqlCommand(querry, sql))
                {
                    command.Parameters.AddWithValue("@Name", data[0]);
                    command.Parameters.AddWithValue("@Surname", data[1]);
                    command.Parameters.AddWithValue("@Phone", int.Parse(data[2]));
                    if (data.Length == 4)
                    command.Parameters.AddWithValue("@Email", data[3]);
                    sql.Open();
                    command.ExecuteNonQuery();
                    sql.Close();

                }
            }
            

            string querry1 = "INSERT INTO Student_marks(Student_id, Title, Mark, Time_stamp) Values(@Student_id, @Title, @Mark, CURRENT_TIMESTAMP)";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iveskite Student_id, Title, Mark x2");
                var data = Console.ReadLine().Split(' ');

                using (SqlCommand command = new SqlCommand(querry1, sql))
                {
                    command.Parameters.AddWithValue("@Student_id", data[0]);
                    command.Parameters.AddWithValue("@Title", data[1]);
                    command.Parameters.AddWithValue("@Mark", int.Parse(data[2]));
                    sql.Open();
                    command.ExecuteNonQuery();
                    sql.Close();

                }
            }
            
            SqlDataReader reader = null;
            string querry2 = "SELECT * FROM Students Order by Name Asc";
            using (SqlCommand command = new SqlCommand(querry2, sql))
            {
                sql.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Id"].ToString());
                    Console.WriteLine(reader["Name"].ToString());
                    Console.WriteLine(reader["Surname"].ToString());
                    Console.WriteLine(reader["Phone"].ToString());
                    Console.WriteLine(reader["Email"].ToString());
                }
                sql.Close();
            }
            */

        }
    }
}
