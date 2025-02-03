using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

            int length = phoneNumField.Text.Length;

            if (length != 10 && length != 0)
            {
                MessageBox.Show("Please enter 10 digit phone number");
                return;
            }

            infoPanel.Hide();
            backBtn.Visible = true;
            titlePanel.BackColor = Color.FromArgb(238, 164, 127);            
            mainPanel1.Controls.Add(infoPanel2);
            infoPanel2.Show();            
        }

        private void OnbackBtn_clicked(object sender, EventArgs e)
        {            
            backBtn.Visible = false;
            infoPanel2.Hide();
            titlePanel.BackColor = Color.White;
            infoPanel.Show();           
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

            if (checkExtension(filePath))
            {
                try
                {
                    ca.ApplicantCV = File.ReadAllBytes(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                    return;
                }
            } else
            {
                MessageBox.Show("Invalid file type. Please upload a PDF file.");
                cvField.Text = "";
            }


            

            string certiPath = certificationField.Text;

            if(string.IsNullOrEmpty(certiPath))
            {
                MessageBox.Show("You should insert the certification file");
                return;
            }

            if (checkExtension(certiPath))
            {
                try
                {
                    ca.ApplicantCertificate = File.ReadAllBytes(certiPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                    return;
                }
            } else
            {
                MessageBox.Show("Invalid file type. Please upload a PDF file.");
                certificationField.Text = "";
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
            
            if (success)
            {
                MessageBox.Show("Account Created Successfully");
                this.Close();
            } else
            {
                MessageBox.Show("Error adding data to the database");
            };

           
        }

        bool isPasswordVisible = false;

        private void showPasswordBtn_clicked(object sender, EventArgs e)
        {
            if(isPasswordVisible)
            {
                passwordField.PasswordChar = '*';
                showPasswordBtn.Text = "Show";
            } else
            {
                passwordField.PasswordChar = '\0';
                showPasswordBtn.Text = "Hide";
            }

            isPasswordVisible = !isPasswordVisible;
        }

        private bool checkExtension(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName).ToLower();
            string[] allowedExtensions = { ".pdf" };

            if (!allowedExtensions.Contains(fileExtension))
            {               
                return false;
            }
            return true;
        }

        private void OnPlusSign_clicked(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    MessageBox.Show("Selected file: " + filePath);
                    certificationField.Text = filePath;
                }
            }
        }

        private void exitBtn_clicked(object sender, EventArgs e)
        {
            this.Close();
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
        public byte[] ApplicantCertificate { get; set; }

        private const string InsertQuery = "INSERT INTO Applicant (Name, Phone_num, DOB, AEmail, Password, Skill_description, Job_category, Experience, Work_status, CV, AppCertificate) VALUES (@ApName, @ApPhone, @ApDob, @ApEmail, @ApPassword, @ApSkill, @ApJob, @ApExper, @ApWork, @ApCV, @ApCerti)";
        
        public bool SaveInfo(CreateAccount ca)
        {
            int row = 0;
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand com = new SqlCommand(InsertQuery, conn))
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
                        com.Parameters.AddWithValue("@ApCerti", ca.ApplicantCertificate);
                        com.Parameters.AddWithValue("@ApCV", ca.ApplicantCV);

                        row = com.ExecuteNonQuery();
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            return row > 0;
        }

    }

}
