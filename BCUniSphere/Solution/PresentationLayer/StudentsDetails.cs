using BCUniSphere.DataLayer;
using BCUniSphere.LogicLayer;
using BCUniSphere.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BCUniSphere.LogicLayer.Students;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace BCUniSphere
{
    public partial class StudentsDetails : Form
    {
        DataHandler handler = new DataHandler();
        private string imagePath;
        public StudentsDetails()
        {
            InitializeComponent();
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = DataHandler.GetStudents();
            PopulateCoursesComboBoxStud();
        }

        private void txtStudentName_Enter(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "Student Name")
            {
                txtStudentName.Text = "";
                txtStudentName.ForeColor = Color.IndianRed;
            }
        }

        private void txtStudentNum_Leave(object sender, EventArgs e)
        {
            if (txtStudentNum.Text == "")
            {
                txtStudentNum.Text = "Student Number";
                txtStudentNum.ForeColor = Color.Silver;
            }
        }

        private void txtStudentNum_Enter(object sender, EventArgs e)
        {
            if (txtStudentNum.Text == "Student Number")
            {
                txtStudentNum.Text = "";
                txtStudentNum.ForeColor = Color.IndianRed;
            }
        }

        private void txtStudentName_Leave(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "")
            {
                txtStudentName.Text = "Student Name";
                txtStudentName.ForeColor = Color.Silver;
            }
        }
        private void txtStudentSurname_Enter(object sender, EventArgs e)
        {
            if (txtStudentSurname.Text == "Student Surname")
            {
                txtStudentSurname.Text = "";
                txtStudentSurname.ForeColor = Color.IndianRed;
            }
        }

        private void txtStudentSurname_Leave(object sender, EventArgs e)
        {
            if (txtStudentSurname.Text == "")
            {
                txtStudentSurname.Text = "Student Surname";
                txtStudentSurname.ForeColor = Color.Silver;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone Number")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.IndianRed;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Phone Number";
                txtPhone.ForeColor = Color.Silver;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.IndianRed;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Address";
                txtAddress.ForeColor = Color.Silver;
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentNum.Text, out int studentNumber) ||
                string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtStudentSurname.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                cbGender.SelectedIndex == -1 ||
                cbStudCourse.SelectedIndex == -1 ||
                pbImage.Image == null)
            {
                MessageBox.Show("Invalid input. Please fill in all fields correctly, including selecting an image.");
                return;
            }

            if (!string.IsNullOrEmpty(imagePath))
            {
                using (Image image = Image.FromFile(imagePath))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        byte[] imageBytes = ms.ToArray();

                        string name = txtStudentName.Text;
                        string surname = txtStudentSurname.Text;
                        byte[] studentImage = imageBytes;
                        string gender = cbGender.SelectedItem.ToString();
                        string phone = txtPhone.Text;
                        string address = txtAddress.Text;
                        DateTime dob = dtpDOB.Value;
                        int courseId = Convert.ToInt32(cbStudCourse.SelectedValue);

                        Student newStudent = new Student(studentNumber, name, surname, studentImage, dob, gender, phone, address, courseId);

                        DataHandler.AddStudent(newStudent);
                        MessageBox.Show("Student added successfully!");
                        dgvStudents.DataSource = DataHandler.GetStudents();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
                return;
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentNum.Text, out int studentNum))
            {
                MessageBox.Show("Invalid student number.");
                return;
            }

            byte[] imageBytes = ImageToByteArray(pbImage.Image);
            DataSet data = handler.UpdateStudent(
                studentNum,
                txtStudentName.Text,
                txtStudentSurname.Text,
                dtpDOB.Value,
                cbGender.Text,
                txtPhone.Text,
                txtAddress.Text,
                Convert.ToInt32(cbStudCourse.SelectedValue),
                imageBytes
            );
            MessageBox.Show("Student updated successfully");
            dgvStudents.DataSource = data.Tables[0];
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentNum.Text))
            {
                DataHandler handler = new DataHandler();
                DataSet data = new DataSet();

                try
                {
                    int studentNum = int.Parse(txtStudentNum.Text);
                    data = handler.DelStudent(studentNum);
                    MessageBox.Show("Student deleted successfully");
                    dgvStudents.DataSource = data.Tables[0];

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input. Please enter a valid student number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a student number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtStudentNum.Text;
            if (int.TryParse(input, out int studentNum))
            {
                DataHandler handler = new DataHandler();
                string[] stud = handler.Search(studentNum);

                if (stud != null && stud.Length > 5 && !string.IsNullOrEmpty(stud[0]))
                {
                    PopulateFieldsWithData(stud);
                    MessageBox.Show("Student was successfully located.");
                }
                else
                {
                    MessageBox.Show("The searched for student could not be found");
                }
            }
            else
            {
                MessageBox.Show("Invalid student number entered.");
            }
        }

        private void PopulateFieldsWithData(string[] stud)
        {
            txtStudentNum.ForeColor = Color.IndianRed;
            txtStudentName.ForeColor = Color.IndianRed;
            txtStudentSurname.ForeColor = Color.IndianRed;
            txtPhone.ForeColor = Color.IndianRed;
            txtAddress.ForeColor = Color.IndianRed;
            cbGender.ForeColor = Color.IndianRed;
            cbStudCourse.ForeColor = Color.IndianRed;

            txtStudentName.Text = stud[1];
            txtStudentSurname.Text = stud[2];
            dtpDOB.Value = DateTime.TryParse(stud[3], out DateTime dob) ? dob : DateTime.Now;
            cbGender.Text = stud[4];
            txtPhone.Text = stud[5];
            txtAddress.Text = stud[6];
            cbStudCourse.Text = stud[7];

            int rowIndex = FindRowIndex(stud[0]);

            if (rowIndex >= 0)
            {
                dgvStudents.Rows[rowIndex].Selected = true;

                object stImage = dgvStudents.Rows[rowIndex].Cells["StudentImage"].Value;
                if (stImage != null && stImage is byte[])
                {
                    pbImage.Image = Image.FromStream(new MemoryStream((byte[])stImage));
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbImage.Image = null;
                }
            }
            else
            {
                pbImage.Image = null;
            }
        }

        private int FindRowIndex(string studentNumber)
        {
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.Cells["StudentNum"].Value.ToString() == studentNumber)
                {
                    return row.Index;
                }
            }
            return -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDetail mainForm = new MainDetail();
            mainForm.Show();
            this.Hide();
        }

        private void btnStudExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PopulateCoursesComboBoxStud()
        {
            DataTable courses = handler.GetCourses();
            cbStudCourse.DataSource = courses;
            cbStudCourse.DisplayMember = "CourseName";
            cbStudCourse.ValueMember = "CourseID";
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedItem.ToString() == "Male" || cbGender.SelectedItem.ToString() == "Female")
            {
                cbGender.ForeColor = Color.IndianRed;
            }
            else
            {
                cbGender.ForeColor = Color.Silver;
            }
        }

        private void btnStudProfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an Image";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = Image.FromFile(ofd.FileName);
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagePath = ofd.FileName;
                }
            }
        }

        private void dgvStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStudents.Rows.Count - 1)
            {
                txtStudentNum.ForeColor = Color.IndianRed;
                txtStudentName.ForeColor = Color.IndianRed;
                txtStudentSurname.ForeColor = Color.IndianRed;
                txtPhone.ForeColor = Color.IndianRed;
                txtAddress.ForeColor = Color.IndianRed;
                cbStudCourse.ForeColor = Color.IndianRed;

                object stNumber = dgvStudents.Rows[e.RowIndex].Cells["StudentNum"].Value;
                txtStudentNum.Clear();
                txtStudentNum.Text = stNumber.ToString();
                object stName = dgvStudents.Rows[e.RowIndex].Cells["StudentName"].Value;
                txtStudentName.Text = stName.ToString();
                object stSurname = dgvStudents.Rows[e.RowIndex].Cells["Surname"].Value;
                txtStudentSurname.Text = stSurname.ToString();
                object DOB = dgvStudents.Rows[e.RowIndex].Cells["DateOfBirth"].Value;
                dtpDOB.Text = DOB.ToString();
                object Gender = dgvStudents.Rows[e.RowIndex].Cells["Gender"].Value;
                cbGender.Text = Gender.ToString();
                object Phone = dgvStudents.Rows[e.RowIndex].Cells["Phone"].Value;
                txtPhone.Text = Phone.ToString();
                object stAdress = dgvStudents.Rows[e.RowIndex].Cells["StudentAddress"].Value;
                txtAddress.Text = stAdress.ToString();
                object moduleCodes = dgvStudents.Rows[e.RowIndex].Cells["CourseID"].Value;
                if (moduleCodes != null)
                {
                    int courseId = Convert.ToInt32(moduleCodes);
                    string courseName = GetCourseNameFromID(courseId);
                    cbStudCourse.Text = courseName;
                }

                try
                {
                    object stImage = dgvStudents.Rows[e.RowIndex].Cells["StudentImage"].Value;
                    if (stImage != null && stImage is byte[])
                    {
                        pbImage.Image = Image.FromStream(new MemoryStream((byte[])stImage));
                        pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pbImage.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetCourseNameFromID(int courseId)
        {
            DataTable courses = handler.GetCourses();
            foreach (DataRow row in courses.Rows)
            {
                if (Convert.ToInt32(row["CourseID"]) == courseId)
                {
                    return row["CourseName"].ToString();
                }
            }

            return "";
        }

        private void cbStudCourse_Leave(object sender, EventArgs e)
        {
            if (cbStudCourse.SelectedItem != null)
            {
                string selectedText = cbStudCourse.GetItemText(cbStudCourse.SelectedItem);
                cbStudCourse.ForeColor = (selectedText == "Bachelor of Computing" ||
                                         selectedText == "Bachelor of Information Technology" ||
                                         selectedText == "Diploma in Information Technology" ||
                                         selectedText == "Diploma for Deaf Students" ||
                                         selectedText == "Certificate: IT (Database Development)" ||
                                         selectedText == "National Certificate: IT (Systems Development)")
                                         ? Color.IndianRed : Color.Silver;
            }
            else
            {
                cbStudCourse.ForeColor = Color.Silver;
            }
        }
    }
}
