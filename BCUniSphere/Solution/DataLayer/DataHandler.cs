using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Data;
using BCUniSphere.LogicLayer;
using BCUniSphere.PresentationLayer;
using System.Net;
using System.Xml.Linq;
using System.Reflection;

namespace BCUniSphere.DataLayer
{
    internal class DataHandler
    {

        private const string ConnectionString = "Server=DANSZEN\\SQLSERVERNEW; Initial Catalog=BCUniSphere; Integrated Security=SSPI;";

        public DataHandler() 
        {
            
        }

        string path = "usernamesAndPasswords.txt";
        List<string> usernamesPasswords = new List<string>();

        public void signUp(string userName, string passWord)
        {
            if (userName != null && passWord != null)
            {
                using (TextWriter writer = File.AppendText(path))
                {
                    writer.WriteLine($"{userName},{passWord}");
                    MessageBox.Show("User added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username or password");
            }
        }
        public bool newLogin(string username, string password)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] item = line.Split(',');
                string results = $"{item[0].Trim()},{item[1].Trim()}";
                usernamesPasswords.Add(results);
            }
            if (usernamesPasswords.Contains($"{username},{password}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkExsist(string userName) 
        {
            string filecontent = File.ReadAllText(path);

            if (filecontent.Contains(userName))
            {
                return false;
            }
            else { return true; }
        }


        public static DataTable GetStudents()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Students", connection))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }

        public static void AddStudent(Students.Student student)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Students (StudentNum, StudentName, Surname, StudentImage, DateOfBirth, Gender, Phone, StudentAddress, CourseID) " +
                               "VALUES (@StudentNumber, @Name, @Surname, @StudentImage, @DateOfBirth, @Gender, @Phone, @Address, @CourseID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Surname", student.Surname);
                    command.Parameters.AddWithValue("@StudentImage", student.StudentImage);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@Phone", student.Phone);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@CourseID", student.CourseID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataSet UpdateStudent(int studentnum, string name, string surname, DateTime dateOfBirth, string gender, string phone, string address, int courseId, byte[] StudentImage)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand update = new SqlCommand("spUpdateStudent", conn);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("@StudentNumber", studentnum);
                update.Parameters.AddWithValue("@Name", name);
                update.Parameters.AddWithValue("@Surname", surname);
                update.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                update.Parameters.AddWithValue("@Gender", gender);
                update.Parameters.AddWithValue("@Phone", phone);
                update.Parameters.AddWithValue("@Address", address);
                update.Parameters.AddWithValue("@CourseID", courseId);
                update.Parameters.AddWithValue("@StudentImage", StudentImage);
                update.ExecuteNonQuery();
                
                string query = @"SELECT * FROM Students";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataSet data = new DataSet();
                dataAdapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public DataSet DelStudent(int studentnum)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand del = new SqlCommand("spDeleteStudent", conn);
                del.CommandType = CommandType.StoredProcedure;
                del.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = studentnum;
                del.ExecuteNonQuery();
                string query = @"SELECT * FROM Students";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataSet data = new DataSet();
                dataAdapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public string[] Search(int studentnum)
        {
            string[] data = new string[9];
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT StudentNum, StudentName, Surname, DateOfBirth, Gender, Phone, StudentAddress, CourseID, StudentImage FROM Students WHERE StudentNum = @StudentNum";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@StudentNum", studentnum);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data[i] = reader.IsDBNull(i) ? null : reader[i].ToString();
                        }
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return data;
        }

        public static DataTable GetModules()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CourseModules";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }

        public void AddModule(int courseId, string moduleCode, string moduleName, string moduleDescription, string moduleLinks)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO CourseModules (CourseID, ModuleCode, ModuleName, ModuleDescription, ModuleLinks) VALUES (@CourseID, @ModuleCode, @ModuleName, @ModuleDescription, @ModuleLinks)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@CourseID", courseId);
                    command.Parameters.AddWithValue("@ModuleCode", moduleCode);
                    command.Parameters.AddWithValue("@ModuleName", moduleName);
                    command.Parameters.AddWithValue("@ModuleDescription", moduleDescription);
                    command.Parameters.AddWithValue("@ModuleLinks", moduleLinks);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteModule(int moduleID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand del = new SqlCommand("spDeleteModule", conn);
                    del.CommandType = CommandType.StoredProcedure;
                    del.Parameters.AddWithValue("@ModuleID", moduleID);
                    del.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the module: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateModule(int moduleID, string moduleCode, string moduleName, string moduleDescription, string moduleLinks, int courseId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("spUpdateModule", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ModuleID", moduleID);
                    command.Parameters.AddWithValue("@ModuleCode", moduleCode);
                    command.Parameters.AddWithValue("@ModuleName", moduleName);
                    command.Parameters.AddWithValue("@ModuleDescription", moduleDescription);
                    command.Parameters.AddWithValue("@ModuleLinks", moduleLinks);
                    command.Parameters.AddWithValue("@CourseID", courseId);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
        }

        public DataTable GetCourses()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT CourseID, CourseName FROM Courses";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }

        public DataTable SearchModule(int moduleId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CourseModules WHERE ModuleID = @ModuleID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ModuleID", moduleId);
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }
    }
}