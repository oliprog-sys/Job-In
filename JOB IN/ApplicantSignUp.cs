using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace JOB_IN
{
    public partial class ApplicantSignUp : Form
    {
        CreateAccount ca = new CreateAccount();
        //private string connString = "Data Source=DESKTOP-D5PCH38\\SQLEXPRESS;Initial Catalog=Job_in;Integrated Security=True;";
        public ApplicantSignUp()
        {
            InitializeComponent();
        }

        private void next_btn_click(object sender, EventArgs e)
        {
            infoPanel.Hide();
            titlePanel.BackColor = Color.FromArgb(238, 164, 127);
            mainPanel1.Controls.Add(infoPanel2);
        }

        //private void onUploadBtn_clicked(object sender, EventArgs e)
        //{
        //    uploadFile();
        //}

        private void OnChooseFile_clicked(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    MessageBox.Show("Selected file: " + filePath);
                    cvField.Text = filePath;
                }
            }
        }

        private void OnSubmitBtn_clicked(Object sender, EventArgs e)
        {
            ca.ApplicantName = nameField.Text;
            ca.ApplicantPhoneNum = phoneNumField.Text;
            ca.ApplicantDOB = DobField.Text;
            ca.ApplicantEmail = emailField.Text;
            ca.ApplicantPassword = passwordField.Text;
            ca.ApplicantSkillDesc = skillField.Text;

            string filePath = cvField.Text;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("You should insert the file to upload");
                return;
            }

            string fileExtension = Path.GetExtension(filePath).ToLower();
            string[] allowedExtensions = { ".pdf" };

            if (!allowedExtensions.Contains(fileExtension))
            {
                MessageBox.Show("Invalid file type. Please upload a PDF file.");
                return;
            }

            try
            {
                ca.ApplicantCV = File.ReadAllBytes(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
                return;
            }

            if (!int.TryParse(experienceField.Text, out int experience))
            {
                MessageBox.Show("Please enter a valid number for experience.");
                return;
            }
            ca.ApplicantExperience = experience;

            ca.ApplicantJobCategory = jobCategoryCB.SelectedItem.ToString();

            if (statusRadioBtn1.Checked)
            {
                ca.ApplicantWorkStatus = statusRadioBtn1.Text;
            }
            else
            {
                ca.ApplicantWorkStatus = statusRadioBtn2.Text;
            }

            var success = ca.SaveInfo(ca);

            if(success)
            {
                MessageBox.Show("Account Created Successfully");
            } else
            {
                MessageBox.Show("Error adding data to the database");
            }

           
        }

       

        private void OnPlusSign_clicked(object sender, EventArgs e)
        {

        }

    }

    public class CreateAccount
    {
        private string connString = "Data Source=.;Initial Catalog=Job_in;Integrated Security=True;";
        public string ApplicantName { get; set; }
        public string ApplicantPhoneNum { get; set; }
        public string ApplicantDOB { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPassword { get; set; }
        public string ApplicantSkillDesc { get; set; }
        public string ApplicantJobCategory { get; set; }
        public int ApplicantExperience { get; set; }
        public string ApplicantWorkStatus { get; set; }
        public byte[] ApplicantCV { get; set; }
        private const string InsertQuery = "INSERT INTO Applicant (Name, Phone_num, DOB, AEmail, Password, Skill_description, Job_category, Experience, Work_status, CV) VALUES (@ApName, @ApPhone, @ApDob, @ApEmail, @ApPassword, @ApSkill, @ApJob, @ApExper, @ApWork, @ApCV)";

        public bool SaveInfo(CreateAccount ca)
        {
            int row = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, conn))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@ApName", ca.ApplicantName);
                        com.Parameters.AddWithValue("@ApPhone", ca.ApplicantPhoneNum);
                        com.Parameters.AddWithValue("@ApDob", ca.ApplicantDOB);
                        com.Parameters.AddWithValue("@ApEmail", ca.ApplicantEmail);
                        com.Parameters.AddWithValue("@ApPassword", ca.ApplicantPassword);
                        com.Parameters.AddWithValue("@ApSkill", ca.ApplicantSkillDesc);
                        com.Parameters.AddWithValue("@ApJob", ca.ApplicantJobCategory);
                        com.Parameters.AddWithValue("@ApExper", ca.ApplicantExperience);
                        com.Parameters.AddWithValue("@ApWork", ca.ApplicantWorkStatus);
                        com.Parameters.AddWithValue("@ApCV", ca.ApplicantCV);

                        row = com.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            return row > 0;
        }
    }
}
