using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using JOB_IN.RJControls;
namespace JOB_IN
{
    
    public partial class ApplicantHomepage : Form
    {

        public applicants applicant;

        private Label companyname1;
        private Panel panel1;
        public ApplicantHomepage(applicants ap)
        {
            applicant = ap;
            InitializeComponents();
        }
        public void InitializeComponents()
        {
            
            panel1 = new Panel();
            companyname1 = new Label();

            jobs = new topButtons(2);
            jobsPane = new borderedscrollPanels();

            search = new topButtons(0);
            searchButton = new topButtons(Color.Black,Color.White);
            searchBox = new TextBox();
            searchResultsPane = new borderedscrollPanels();
            searchPane = new borderedPanels();

            status = new topButtons(0);
            sAllbutton = new topButtons(Color.Black, Color.White);
            sAcceptedbutton = new topButtons(Color.Orange, Color.Black);
            sPendingbutton = new topButtons(Color.Orange, Color.Black);
            sDeniedbutton = new topButtons(Color.Orange, Color.Black);
            statusPane = new borderedPanels();
            statusScrollPane = new borderedscrollPanels();

            profile = new topButtons(0);
            profilePane = new borderedPanels();

            subMain = new borderedPanels();
            
            exit = new topButtons(0);
            MainPanel = new Panel();

            jobs.Name = "jobs";
            jobs.Anchor = AnchorStyles.None;
            jobs.Font = Custom.font(12f);
            jobs.Location = new Point(-617, -320);
            jobs.Size = new Size(140, 80);
            jobs.Text = "Jobs";
            jobs.Click += job_nav_MouseClick;


            search.Anchor = AnchorStyles.None;
            search.Font = Custom.font(12f);
            search.Location = new Point( -215, -320);
            search.Size = new Size(140, 80);
            search.Text = "Search";
            search.Click += search_nav_MouseClick;

            status.Anchor = AnchorStyles.None;
            status.Font = Custom.font(12f);
            status.Location = new Point(215, -320);
            status.Size = new Size(140, 80);
            status.Text = "Status";
            status.Click += status_nav_MouseClick;

            profile.Anchor = AnchorStyles.None;
            profile.Font = Custom.font(12f);
            profile.Location = new Point(617, -320);
            profile.Size = new Size(140, 80);
            profile.Text = "Profile";
            profile.Click += profile_nav_MouseClick;

            exit.Anchor = AnchorStyles.None;
            exit.Font = Custom.font(12f);
            exit.Location = new Point(870, 470);
            exit.Size = new Size(140, 80);
            exit.Text = "exit";
           // exit.Click += ClosePanel;
         
            
            jobsPane.Anchor= AnchorStyles.None;
          
            jobsPane.AutoScroll = true;
            jobsPane.BackColor = Color.FromArgb(0,Color.Black);
            jobsPane.Size = new Size(1434, 675);
            jobsPane.Location = new Point(10, 10);
            jobsPane.BorderStyle = BorderStyle.None;

            // jobs.TabStop = false;

            borderedPanels searchboxP = new borderedPanels();
            searchboxP.Anchor = AnchorStyles.None;
            searchboxP.Location = new Point(260, 15);
            searchboxP.Size = new Size(680, 60);
            searchboxP.BackColor = Color.Black;
            searchboxP.BorderRadius = 30;

            searchBox.Anchor = AnchorStyles.None;
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.MinimumSize = new Size(600, 40);
            searchBox.Location = new Point(300, 28);
            //searchBox.Size = new Size(600, 200);
            searchBox.BackColor = Color.Black;
            searchBox.ForeColor = Color.White;
            searchBox.Font = Custom.font(18);
            searchBox.PlaceholderText = "Search";

            searchButton.Anchor = AnchorStyles.None;
            searchButton.Size = new Size(60, 60);
            searchButton.Location = new Point(950, 15);
            searchButton.Font = Custom.font(18);
            searchButton.Text = "🔍";
            searchButton.Click += (s,e)=>searchResultFetch(s,e,searchBox.Text);

            searchResultsPane.Anchor = AnchorStyles.None;
            searchResultsPane.Size = new Size(1250, 500);
            searchResultsPane.BackColor = Color.FromArgb(0, Color.Chartreuse);
            searchResultsPane.Location = new Point(100, 100);


            searchPane.Anchor = AnchorStyles.None;
            searchPane.AutoScroll = true;
            searchPane.BackColor = Color.FromArgb(255, Color.WhiteSmoke);
            searchPane.Size = new Size(1413, 675);
            searchPane.Location = new Point(10, 10);
            searchPane.BorderStyle = BorderStyle.None;

            searchPane.Controls.Add(searchboxP);
            searchPane.Controls.Add(searchBox);
            searchPane.Controls.Add(searchButton);
            searchPane.Controls.Add(searchResultsPane);

            searchBox.BringToFront();

            sAllbutton.Anchor = AnchorStyles.None;
            sAllbutton.Size = new Size(160, 40);
            sAllbutton.Location = new Point(320, 30);
            sAllbutton.Font = Custom.font(15);
            sAllbutton.Text = "All";
            sAllbutton.Click += all_button_nav;

            sAcceptedbutton.Anchor = AnchorStyles.None;
            sAcceptedbutton.Size = new Size(160, 40);
            sAcceptedbutton.Location = new Point(510, 30);
            sAcceptedbutton.Font = Custom.font(15);
            sAcceptedbutton.Text = "Accepted";
            sAcceptedbutton.Click += accepted_button_nav;

            sDeniedbutton.Anchor = AnchorStyles.None;
            sDeniedbutton.Size = new Size(160, 40);
            sDeniedbutton.Location = new Point(700, 30);
            sDeniedbutton.Font = Custom.font(15);
            sDeniedbutton.Text = "Rejected";
            sDeniedbutton.Click += denied_button_click;

            sPendingbutton.Anchor = AnchorStyles.None;
            sPendingbutton.Size = new Size(160, 40);
            sPendingbutton.Location = new Point(890, 30);
            sPendingbutton.Font = Custom.font(15);
            sPendingbutton.Text = "Pending";
            sPendingbutton.Click += pending_button_nav;

            statusPane.Anchor = AnchorStyles.None;
            statusPane.AutoScroll = true;
            statusPane.BackColor = Color.White;
            statusPane.Size = new Size(1413, 675);
            statusPane.Location = new Point(10, 10);
            statusPane.BorderStyle = BorderStyle.None;

            statusScrollPane.Anchor = AnchorStyles.None;
            statusScrollPane.AutoScroll = true;
            statusScrollPane.Size = new Size(1250, 550);
            statusScrollPane.Location = new Point(100, 100);
            statusScrollPane.BackColor = Color.FromArgb(0, Color.PaleGoldenrod);
           

            statusPane.Controls.Add(sAllbutton);
            statusPane.Controls.Add(sAcceptedbutton);
            statusPane.Controls.Add(sPendingbutton);
            statusPane.Controls.Add(sDeniedbutton);
            statusPane.Controls.Add(statusScrollPane);

            profilePane.Anchor = AnchorStyles.None;
            profilePane.AutoScroll = true;
            profilePane.BackColor = Color.White;
            profilePane.Size = new Size(1413, 675);
            profilePane.Location = new Point(10, 10);
            profilePane.BorderStyle = BorderStyle.None;

            Panel profileImg = new Panel();
            Label UserNameL = new Label();
            Label Email = new Label();
            Label PhoneNum = new Label();
            Label Status = new Label();
            Label Bio = new Label();
            borderedPanels BioP = new borderedPanels();
            TextBox bioT = new TextBox();
            Label Experience = new Label();
            Label CV = new Label();
            borderedPanels cvP = new borderedPanels();
            borderedscrollPanels cvs = new borderedscrollPanels();
            Label CertificationsLabel = new Label();
            borderedPanels CertificationPanel = new borderedPanels();
            borderedscrollPanels CertificationScroll = new borderedscrollPanels();
            topButtons edit = new topButtons(0);
            topButtons addCertification = new topButtons(Color.AliceBlue, Color.Coral);
            //Label UserName = new Label();

            profileImg.Size = new Size(140, 140);
            profileImg.Location = new Point(40, 25);
            profileImg.BorderStyle = BorderStyle.None;  
            profileImg.BackColor = Color.OrangeRed;
       //     profileImg.Controls.Add(new Label("profile image"));

            UserNameL.Text = "Name: "+applicant.name;
            UserNameL.Anchor = AnchorStyles.None;
            UserNameL.Font = Custom.font(15);
            UserNameL.Location = new Point(40, 170);
            UserNameL.Size = new Size(200, 40);

            Email.Text = "Email: "+applicant.email;
            Email.Anchor = AnchorStyles.None;
            Email.Font = Custom.font(15);
            Email.Location = new Point(40, 210);
            Email.Size = new Size(400, 40);

            PhoneNum.Text = "Phone: " + applicant.PhoneNum;
            PhoneNum.Anchor = AnchorStyles.None;
            PhoneNum.Font = Custom.font(15);
            PhoneNum.Location = new Point(40, 250);
            PhoneNum.Size = new Size(200, 40);

            Status.Text = "Status: " + applicant.work_status;
            Status.Anchor = AnchorStyles.None;
            Status.Font = Custom.font(15);
            Status.Location = new Point(40, 290);
            Status.Size = new Size(400, 40);


            Bio.Text = "Bio: " ;
            Bio.Anchor = AnchorStyles.None;
            Bio.Font = Custom.font(15);
            Bio.Location = new Point(40, 330);
            Bio.Size = new Size(200, 30);

            BioP.Size = new Size(400, 200);
            BioP.Location = new Point(40, 370);
            BioP.Anchor = AnchorStyles.None;
            BioP.BackColor = Color.Coral;

            bioT.Text = applicant.skill_description;
            bioT.Anchor = AnchorStyles.None;    
            bioT.AllowDrop = true;
            bioT.Multiline = true;
            bioT.Size = new Size(350,160);
            bioT.BorderStyle = BorderStyle.None;
            bioT.Location = new Point(25, 20);
            BioP.Controls.Add(bioT);

            Experience.Text = "Experience: " + applicant.experience;
            Experience.Anchor = AnchorStyles.None;
            Experience.Font = Custom.font(15);
            Experience.Location = new Point(400, 170);
            Experience.Size = new Size(400, 30);

            CV.Text = "Curriculum Vitae";
            CV.Anchor = AnchorStyles.None;
            CV.Font = Custom.font(15);
            CV.Location = new Point(900, 40);
            CV.Size = new Size(400, 30);

            cvP.Size = new Size(400, 200);
            cvP.Location = new Point(880, 70);
            cvP.Anchor = AnchorStyles.None;
            cvP.BackColor = Color.Coral;

            CertificationsLabel.Text = "Certifications";
            CertificationsLabel.Anchor = AnchorStyles.None;
            CertificationsLabel.Font = Custom.font(15);
            CertificationsLabel.Location = new Point(900, 300);
            CertificationsLabel.Size = new Size(400, 30);

            CertificationScroll.Size = new Size(400, 130);
            CertificationScroll.Location = new Point(3, 3);
            CertificationScroll.Anchor = AnchorStyles.None;
            CertificationScroll.BackColor = Color.FromArgb(0,Color.White);

            addCertification.Anchor = AnchorStyles.None;
            addCertification.Size = new Size(180, 40);
            addCertification.Text = "Add";
            addCertification.Location = new Point(180, 150);
            

            CertificationPanel.Size = new Size(400, 200);
            CertificationPanel.Location = new Point(880, 350);
            CertificationPanel.Anchor = AnchorStyles.None;
            CertificationPanel.BackColor = Color.Coral;
            CertificationPanel.Controls.Add(CertificationScroll);
            CertificationPanel.Controls.Add(addCertification);


            edit.Anchor = AnchorStyles.None;
            edit.Font = Custom.font(17);
            edit.Text = "Edit";
            edit.Size = new Size(290, 50);
            edit.Location = new Point(935, 600);

            profilePane.Controls.Add(profileImg);
            profilePane.Controls.Add(UserNameL);
            profilePane.Controls.Add(Experience);
            profilePane.Controls.Add(Email);
            profilePane.Controls.Add(PhoneNum);
            profilePane.Controls.Add(Status);
            profilePane.Controls.Add(Bio);
            profilePane.Controls.Add(BioP);
            profilePane.Controls.Add(CV);
            profilePane.Controls.Add(cvP);
            profilePane.Controls.Add(CertificationsLabel);
            profilePane.Controls.Add(CertificationPanel);
            profilePane.Controls.Add(edit);
            edit.BringToFront();

            subMain.Anchor = AnchorStyles.None;
            subMain.AutoScroll = true;
            subMain.BackColor = Color.Coral;
            subMain.Size = new Size(1443, 705);
            subMain.Location = new Point(-617, -220);
            subMain.BorderStyle = BorderStyle.None;


            companyname1.AccessibleName = "";
            companyname1.Anchor = AnchorStyles.None;
            companyname1.AutoSize = true;
            companyname1.Font = new Font("Cascadia Mono", 55F);
            companyname1.Location = new Point(-90, 11);
            companyname1.Name = "companyname1";
            companyname1.Size = new Size(376, 122);
            companyname1.TabIndex = 0;
            companyname1.ForeColor= Color.White;
            companyname1.Text = "JOB IN";
          

            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(companyname1);
            panel1.Anchor = AnchorStyles.None;
            panel1.Location = new Point(-860, -500);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 143);
            panel1.TabIndex = 0;

            Label welcome = new Label();
            welcome.Text = "WELCOME, " + applicant.name.ToUpperInvariant();
            welcome.Font = Custom.font(30);
            welcome.Anchor = AnchorStyles.None;
            welcome.Location = new Point(-200, -450);
            welcome.ForeColor = Color.OrangeRed;
            welcome.Size = new Size(850, 100);

            MainPanel.Controls.Add(welcome);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(jobs);
            MainPanel.Controls.Add(search);
            MainPanel.Controls.Add(status);
            MainPanel.Controls.Add(profile);
            MainPanel.Controls.Add(exit);
            subMain.Controls.Add(jobsPane);
            subMain.Controls.Add(searchPane);
            subMain.Controls.Add(statusPane);
            subMain.Controls.Add(profilePane);
            MainPanel.Controls.Add(subMain);

            MainPanel.Anchor = AnchorStyles.None;
            MainPanel.BackColor = Color.White;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1920, 1080);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);


            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(1635, 920);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(MainPanel);
            Name = "Applicant";
            Text = "Applicant";

            this.FormClosing += CloseApp;


        }

        private void pending_button_nav(object? sender, EventArgs e)
        {
            selectedButtonStatus("pending");
            job_history_adder("pending");
        }

        private void denied_button_click(object? sender, EventArgs e)
        {
            selectedButtonStatus("denied");
            job_history_adder("denied");
        }

        private void accepted_button_nav(object? sender, EventArgs e)
        {
            selectedButtonStatus("accepted");
            job_history_adder("accepted");
        }

        private void all_button_nav(object? sender, EventArgs e)
        {
            selectedButtonStatus("all");
            job_history_adder("all");
        }

        private void searchResultFetch(object? sender, EventArgs e, string search)
        {
            searchResultsPane.Controls.Clear();
         
            //perform data fetch here and add it to searchResultPane
            ArrayList arr = Db.fetchJobName(search);
            if (arr.Count == 0)
            {
                Panel wrap = new Panel();
               // wrap.BackColor = Color.Azure;
                wrap.Size = new Size(1250, 160);
                
                Label noResult = new Label();
                noResult.Anchor = AnchorStyles.None;
                noResult.BorderStyle = BorderStyle.None;
                noResult.Font = Custom.font(23);
                noResult.Size = new Size(600, 90);
                noResult.Text = "No results found...";
                noResult.BackColor = Color.FromArgb(0, Color.White);
                noResult.Location = new Point(400, 80);
                wrap.Controls.Add(noResult);
                searchResultsPane.Controls.Add(wrap);
            }
            else
            {
                foreach(Job j in arr)
                {

                    jobDesc jd = new jobDesc(j.name, j.description, j.requirement);
                    //jd.Size = new Size(1100, 400);
                    jd.more.Click += (sender, e) => jobExpand(sender, e, j.id);
                    searchResultsPane.Controls.Add(jd);
                }
            }
        }



        private void selectedButton(string button)
        {
            if (button == "jobs")
            {
                jobs.BackColor= Color.AliceBlue;
                jobs.ForeColor = Color.Coral;
                search.BackColor = Color.Coral;
                search.ForeColor = Color.Black;
                status.BackColor = Color.Coral;
                status.ForeColor = Color.Black;
                profile.BackColor = Color.Coral;
                profile.ForeColor = Color.Black;
            }
            else if (button == "search")
            {
                search.BackColor = Color.AliceBlue;
                search.ForeColor = Color.Coral;
                jobs.BackColor = Color.Coral;
                jobs.ForeColor = Color.Black;
                status.BackColor = Color.Coral;
                status.ForeColor = Color.Black;
                profile.BackColor = Color.Coral;
                profile.ForeColor = Color.Black;
            }
            else if (button == "status")
            {
                status.BackColor = Color.AliceBlue;
                status.ForeColor = Color.Coral;
                jobs.BackColor = Color.Coral;
                jobs.ForeColor = Color.Black;
                search.BackColor = Color.Coral;
                search.ForeColor = Color.Black;
                profile.BackColor = Color.Coral;
                profile.ForeColor = Color.Black;
            }
            else if (button == "profile")
            {
                profile.BackColor = Color.AliceBlue;
                profile.ForeColor = Color.Coral;
                jobs.BackColor = Color.Coral;
                jobs.ForeColor = Color.Black;
                status.BackColor = Color.Coral;
                status.ForeColor = Color.Black;
                search.BackColor = Color.Coral;
                search.ForeColor = Color.Black;
            }
        }

        private void selectedButtonStatus(string button)
        {
            if (button == "all")
            {
                sAllbutton.BackColor = Color.Black;
                sAllbutton.ForeColor = Color.White;
                sAcceptedbutton.BackColor = Color.Orange;
                sAcceptedbutton.ForeColor = Color.Black;
                sDeniedbutton.BackColor = Color.Orange;
                sDeniedbutton.ForeColor = Color.Black;
                sPendingbutton.BackColor = Color.Orange;
                sPendingbutton.ForeColor = Color.Black;
            }
            else if (button == "accepted")
            {
                sAllbutton.BackColor = Color.Orange;
                sAllbutton.ForeColor = Color.Black;
                sAcceptedbutton.BackColor = Color.Black;
                sAcceptedbutton.ForeColor = Color.White;
                sDeniedbutton.BackColor = Color.Orange;
                sDeniedbutton.ForeColor = Color.Black;
                sPendingbutton.BackColor = Color.Orange;
                sPendingbutton.ForeColor = Color.Black;
            }
            else if (button == "pending")
            {
                sAllbutton.BackColor = Color.Orange;
                sAllbutton.ForeColor = Color.Black;
                sAcceptedbutton.BackColor = Color.Orange;
                sAcceptedbutton.ForeColor = Color.Black;
                sDeniedbutton.BackColor = Color.Orange;
                sDeniedbutton.ForeColor = Color.Black;
                sPendingbutton.BackColor = Color.Black;
                sPendingbutton.ForeColor = Color.White;
            }
            else if (button == "denied")
            {
                sAllbutton.BackColor = Color.Orange;
                sAllbutton.ForeColor = Color.Black;
                sAcceptedbutton.BackColor = Color.Orange;
                sAcceptedbutton.ForeColor = Color.Black;
                sDeniedbutton.BackColor = Color.Black;
                sDeniedbutton.ForeColor = Color.White;
                sPendingbutton.BackColor = Color.Orange;
                sPendingbutton.ForeColor = Color.Black; ;
            }
        }

        private void job_nav_MouseClick(object? sender, EventArgs e)
        {
            selectedButton("jobs");
            jobsPane.BringToFront();
           
        }

        private void search_nav_MouseClick(object? sender, EventArgs e)
        {
            selectedButton("search");
            searchPane.BringToFront();
           

        }

        private void status_nav_MouseClick(object? sender, EventArgs e)
        {
            selectedButton("status");
            statusPane.BringToFront();
            job_history_adder("all");


        }

        private void profile_nav_MouseClick(object? sender, EventArgs e)
        {
            selectedButton("profile");
            profilePane.BringToFront();

        }

        // 
        public  void  job_list_adder()
        {
            ArrayList arr = Db.fetchJobs(applicant.category);
            jobsPane.Controls.Clear();
            if (arr.Count==0)
            {
                borderedPanels b = new borderedPanels();
                b.Size = new Size(1410, 650);
                b.BackColor = Color.White;
                b.Anchor = AnchorStyles.None;
                b.Location = new Point(1000, 700);

                Label l = new Label();
                l.ForeColor = Color.Black;
                l.Text = "No jobs available, Try again later";
                l.Font = Custom.font(24);
                l.Anchor = AnchorStyles.None;
                l.Size = new Size(1200, 60);
                l.Location = new Point(340, 280);

                b.Controls.Add(l);
                jobsPane.Controls.Add(b);
            }
            else
            {
                foreach (Job j in arr)
                {

                    jobDesc jd = new jobDesc(j.name, j.description, j.requirement);
                    jd.more.Click += (sender, e) => jobExpand(sender, e, j.id);
                    jobsPane.Controls.Add(jd);

                }
            }
            
        }

        private void jobExpand(object? sender, EventArgs e, int id)
        {
            jobDescDetail a = new jobDescDetail(id);
            MainPanel.Controls.Add(a);
            a.BringToFront();
        }


        //Fetches the job info as a series of strings from the database and creates a panel that will be added to an array list
        public void job_list_fetcher(ArrayList jobList)
        {

        }

        //needs db
        public void job_history_fetcher()
        {

        }
       
        
        public void job_history_adder(string stat)
        {
            statusScrollPane.Controls.Clear();

            int max=0;
            if (stat == "all")
            {
                max = 9;
            }else if(stat == "accepted")
            {
                max = 5;
            }
            else if (stat == "pending")
            {
                max = 3;
            }
            else if (stat == "denied")
            {
                max = 1;
            }
            for (int i = 1; i < max+1; i++)
            {
                statusScrollPane.Controls.Add(new jobHistory("title "+ i, "Employer"," job type", "requirements", "31/2/25"));
            }
        }


        private static void CloseApp(object? sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }


        private void ClosePanel(object? sender, EventArgs e)
        {
            this.Close();
            MainPanel.BringToFront();

            // Application.Exit();
        }

        public  void return_to_login(Object sender, EventArgs e, Form1 f)
        {
            f.Show();
            f.activeForm.Controls.Remove(this);
            this.Hide();
          
        }
    }



}
