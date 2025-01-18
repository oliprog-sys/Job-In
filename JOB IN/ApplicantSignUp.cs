using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_IN
{
    public partial class ApplicantSignUp : Form
    {
        private string connString = "Data Source=DESKTOP-D5PCH38\\SQLEXPRESS;Initial Catalog=Job_in;Integrated Security=True;Trust Server Certificate=True";
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

        private void onUploadBtn_clicked(object sender, EventArgs e)
        {
            uploadFile();
        }

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
            CreateAccount ca = new CreateAccount();
            ca.ApplicantName = nameField.Text;
            ca.ApplicantPhoneNum = phoneNumField.Text;
            ca.ApplicantDOB = DobField.Text;
            ca.ApplicantEmail = emailField.Text;
            ca.ApplicantPassword = passwordField.Text;
            ca.ApplicantSkillDesc = skillField.Text;
            ca.ApplicantCV = File.ReadAllBytes(cvField.Text);
            ca.ApplicantJobCategory = jobCategoryCB.SelectedText;
            ca.ApplicantExperience = int.Parse(experienceField.Text);
            if (statusRadioBtn1.Checked)
            {
                ca.ApplicantWorkStatus = statusRadioBtn1.Text;
            } else
            {
                ca.ApplicantWorkStatus = statusRadioBtn2.Text;
            }


            ca.SaveInfo();
            MessageBox.Show("Account created successfully");

        }

        private void uploadFile()
        {
            string filePath = cvField.Text;
            
            if(string.IsNullOrEmpty(filePath) )
            {
                MessageBox.Show("You should insert the file to upload");
                return;
            }

            string fileExtension = Path.GetExtension(filePath).ToLower();

            string[] allowedExtension = { ".pdf" };

            if(!allowedExtension.Contains(fileExtension))
            {
                MessageBox.Show("Invalid file type. please upload pdf file");
                return;
            }

            byte[] fileData = File.ReadAllBytes(filePath);

            using (SqlConnection conn = new SqlConnection(connString))           
            {
                string fileUpload = "INSERT INTO Job_in (CV) VALUES (@fileInput)";
                
                using(SqlCommand com = new SqlCommand(fileUpload, conn))
                {
                    com.Parameters.AddWithValue("@fileInput", fileData);

                    try
                    {
                        conn.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("File uploaded successfully");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void OnPlusSign_clicked(object sender, EventArgs e)
        {

        }

    }

    public class CreateAccount
    {
        private string connString = "Data Source=DESKTOP-D5PCH38\\SQLEXPRESS;Initial Catalog=Job_in;Integrated Security=True;Trust Server Certificate=True";
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
        private const string InsertQuery = "Insert Into Job_in(Name, Phone_num, DOB, AEmail, Password, Skill_description, Job_category, Experience, Work_status, CV) Values (@ApplicantName, @ApplicantPhoneNum, @ApplicantDOB, @ApplicantEmail, @ApplicantPassword, @ApplicantSkillDesc, @ApplicantJobCategory, @ApplicantExperience, @ApplicantWorkStatus, @ApplicantCV)";

        public void SaveInfo()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, conn))
                {
                    com.Parameters.AddWithValue("@ApplicantName", ApplicantName);
                    com.Parameters.AddWithValue("@ApplicantPhoneNum", ApplicantPhoneNum);
                    com.Parameters.AddWithValue("@ApplicantDOB", ApplicantDOB);
                    com.Parameters.AddWithValue("@ApplicantEmail", ApplicantEmail);
                    com.Parameters.AddWithValue("@ApplicantPassword", ApplicantPassword);
                    com.Parameters.AddWithValue("@ApplicantSkillDesc", ApplicantSkillDesc);
                    com.Parameters.AddWithValue("@ApplicantJobCategory", ApplicantJobCategory);
                    com.Parameters.AddWithValue("@ApplicantExperience", ApplicantExperience);
                    com.Parameters.AddWithValue("@ApplicantWorkStatus", ApplicantWorkStatus);
                    com.Parameters.AddWithValue("@ApplicantCV", ApplicantCV);

                    com.ExecuteNonQuery(); 
                }
            }
        }
    }
}
