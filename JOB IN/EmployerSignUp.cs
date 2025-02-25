using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace JOB_IN
{
    public partial class EmployerSignUp : Form
    {
        CreateOrganizationAccount coa = new CreateOrganizationAccount();
        CreatePersonalAccount cpa = new CreatePersonalAccount();
        public EmployerSignUp()
        {
            InitializeComponent();
        }

        // organization panel
        private void OnOrganizationBtn_clicked(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(organizationPanel);
            choosePanel.Hide();
            organizationPanel.Show();
            signUpAsLabel.Text = "Oraganization  Sign  Up";

        }


        private void next_btn_click(object sender, EventArgs e)
        {

            int length = orgphoneNumField.Text.Length;

            if (length != 10 && length != 0)
            {
                MessageBox.Show("Please enter 10 digit phone number");
                return;
            }


            organizationPanel.Hide();
            backBtn.Visible = true;
            signUpAsPanel.BackColor = Color.FromArgb(0, 83, 156);
            signUpAsLabel.ForeColor = Color.White;
            mainPanel.Controls.Add(organizationalMorePanel);
            organizationalMorePanel.Show();
        }

        private void OnbackBtnForOrganization_clicked(Object sender, EventArgs e)
        {
            backBtn.Visible = false;
            organizationalMorePanel.Hide();
            signUpAsPanel.BackColor = Color.White;
            signUpAsLabel.ForeColor = Color.Black;            
            organizationPanel.Show();
        }

        private void OnorgSubmitBtn_clicked(object sender, EventArgs e)
        {
            coa.orgName = orgnameField.Text;
            coa.orgPhone = orgphoneNumField.Text;
            coa.orgAddress = orgaddressField.Text;
            coa.orgEmail = orgemailField.Text;
            coa.orgPassword = orgpasswordField.Text;
            coa.orgDescription = aboutUsField.Text;
            coa.orgMediaLink = mediaLinkField.Text;

            var success = coa.SaveOrgInfo(coa);

            if (success)
            {
                MessageBox.Show("Account added successfully");
                this.Close();
            } else
            {
                MessageBox.Show("Error: unable to create an account");
            }
        }

        bool isPasswordVisible = false;
        private void showPasswordBtn_on_org_clicked(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                orgpasswordField.PasswordChar = '*';
                showPasswordBtn1.Text = "Show";
            }
            else
            {
                orgpasswordField.PasswordChar = '\0';
                showPasswordBtn1.Text = "Hide";
            }

            isPasswordVisible = !isPasswordVisible;
        }

        private void On_add_media_clicked(object sender, EventArgs e)
        {

        }

        // personal panel
        private void personal_next_btn_click(Object sender, EventArgs e)
        {
            int length = perphoneNumField.Text.Length;

            if (length != 10 && length != 0)
            {
                MessageBox.Show("Please enter 10 digit phone number");
                return;
            }

            personalPanel.Hide();
            backBtn.Visible = true;
            signUpAsPanel.BackColor = Color.FromArgb(0, 83, 156);
            signUpAsLabel.ForeColor = Color.White;
            mainPanel.Controls.Add(personalMorePanel);
            personalMorePanel.Show();
        }

        private void OnbackBtnForPersonal_clicked(object sender, EventArgs e)
        {
            backBtn.Visible = false;
            personalMorePanel.Hide();
            signUpAsPanel.BackColor = Color.White;
            signUpAsLabel.ForeColor = Color.Black;
            personalPanel.Show();
        }

        private void OnperSubmitBtn_clicked(Object sender, EventArgs e)
        {
            cpa.perName = pernameField.Text;
            cpa.perPhone = perphoneNumField.Text;
            cpa.perAddress = peraddressField.Text;
            cpa.perEmail = peremailField.Text;
            cpa.perPassword = perpasswordField.Text;
            cpa.perDescription = peraboutUsField.Text;           
            cpa.perMediaLink = permediaLinkField.Text;

            var success = cpa.SavePerInfo(cpa);

            if (success)
            {
                MessageBox.Show("Account added successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: unable to create an account");
            }
        }

        bool isPasswordVisible2 = false;
        private void showPasswordBtn_on_per_clicked(object sender, EventArgs e)
        {
            if (isPasswordVisible2)
            {
                perpasswordField.PasswordChar = '*';
                showPasswordBtn2.Text = "Show";
            }
            else
            {
                perpasswordField.PasswordChar = '\0';
                showPasswordBtn2.Text = "Hide";
            }

            isPasswordVisible2 = !isPasswordVisible2;
        }

        private void OnPersonalBtn_clicked(object sender, EventArgs e)
        {
            //choosePanel.Hide();
            mainPanel.Controls.Add(personalPanel);
            choosePanel.Hide();
            personalPanel.Show();
            signUpAsLabel.Text = "Employer  Sign  Up";
        }

        private void exitBtn1_clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitBtn2_clicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class CreateOrganizationAccount {

        private string connString = "Data Source=.;Initial Catalog=Job_in;Integrated Security=True;";
        public string orgName { get; set; }
        public string orgPhone { get; set; }
        public string orgAddress { get; set; }
        public string orgEmail { get; set; }
        public string orgPassword { get; set; }
        public string orgDescription { get; set; }
        public string orgMediaLink { get; set; }

        private string InsertQuery = "INSERT INTO Organization (OName, phoneNum, Address, OEmail, Password, Description, mediaLink) VALUES (@name, @phone, @address, @email, @password, @description, @mediaLink)";

        public bool SaveOrgInfo(CreateOrganizationAccount account)
        {
            int row = 0;
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand com = new SqlCommand(InsertQuery, conn))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@name", account.orgName);
                        com.Parameters.AddWithValue("@phone", account.orgPhone);
                        com.Parameters.AddWithValue("@address", account.orgAddress);
                        com.Parameters.AddWithValue("@email", account.orgEmail);
                        string hashed = BCrypt.Net.BCrypt.HashPassword(account.orgPassword);
                        com.Parameters.AddWithValue("@password", hashed);
                        com.Parameters.AddWithValue("@description", account.orgDescription);
                        com.Parameters.AddWithValue("@mediaLink", account.orgMediaLink);

                        row = com.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return row > 0;
        }

       
    }

    public class CreatePersonalAccount
    {

        private string connString = "Data Source=.;Initial Catalog=Job_in;Integrated Security=True;";
        public string perName { get; set; }
        public string perPhone { get; set; }
        public string perAddress { get; set; }
        public string perEmail { get; set; }
        public string perPassword { get; set; }
        public string perDescription { get; set; }
        public string perMediaLink { get; set; }

        private string InsertQuery = "INSERT INTO Organization (OName, phoneNum, Address, OEmail, Password, Description, mediaLink) VALUES (@name, @phone, @address, @email, @password, @description, @mediaLink)";

        public bool SavePerInfo(CreatePersonalAccount account)
        {
            int row = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, conn))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@name", account.perName);
                        com.Parameters.AddWithValue("@phone", account.perPhone);
                        com.Parameters.AddWithValue("@address", account.perAddress);
                        com.Parameters.AddWithValue("@email", account.perEmail);
                        string hash = BCrypt.Net.BCrypt.HashPassword(account.perPassword);
                        com.Parameters.AddWithValue("@password", hash);
                        com.Parameters.AddWithValue("@description", account.perDescription);
                        com.Parameters.AddWithValue("@mediaLink", account.perMediaLink);

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
