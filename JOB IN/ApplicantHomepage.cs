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
        private Label companyname1;
        private Panel panel1;
        public ApplicantHomepage()
        {
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
         

            jobsPane.Anchor= AnchorStyles.None;
          
            jobsPane.AutoScroll = true;
            jobsPane.BackColor = Color.FromArgb(0,Color.White);
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
            searchBox.Text = "Search";

            searchButton.Anchor = AnchorStyles.None;
            searchButton.Size = new Size(60, 60);
            searchButton.Location = new Point(950, 15);
            searchButton.Font = Custom.font(18);
            searchButton.Text = "🔍";
            searchButton.Click += searchResultFetch;

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
            profilePane.BackColor = Color.BlueViolet;
            profilePane.Size = new Size(1413, 675);
            profilePane.Location = new Point(10, 10);
            profilePane.BorderStyle = BorderStyle.None;

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
            companyname1.Location = new Point(-60, 11);
            companyname1.Name = "companyname1";
            companyname1.Size = new Size(376, 122);
            companyname1.TabIndex = 0;
            companyname1.Text = "JOB IN";
          

            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(companyname1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 143);
            panel1.TabIndex = 0;


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
            MainPanel.BackColor = Color.Gray;
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

        private void searchResultFetch(object? sender, EventArgs e)
        {
            searchResultsPane.Controls.Clear();
            int x = 0;
            //perform data fetch here and add it to searchResultPane
            if (x == 0)
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
            for(int i = 0; i < 10; i++)
            {
                jobsPane.Controls.Add(new jobDesc("title", " description", "requirements"));
            }
        }
        

        //Fetches the job info as a series of strings from the database and creates a panel that will be added to an array list
        public void job_list_fetcher(ArrayList jobList)
        {

        }

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
            for (int i = 0; i < max; i++)
            {
                statusScrollPane.Controls.Add(new jobHistory("title", "Employer"," job type", "requirements", "31/2/25"));
            }
        }


        private static void CloseApp(object? sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
    }

    class jobDesc : borderedPanels
    {
        private Label jobName;
        private Label jobDescription;
        private Label jobRequirement;
        private topButtons more;
        public static int Y=42;
        public jobDesc(string JobName, string  JobDescription, string JobRequirement)
        {
            jobName = new Label();
            jobDescription = new Label();
            jobRequirement = new Label();
            more = new topButtons(0);


            jobName.Anchor = AnchorStyles.None;
            jobName.Font = Custom.font(29);
            jobName.Size = new Size(200, 60);
            jobName.Text = JobName;
            jobName.BackColor = Color.AliceBlue;
            jobName.Location = new Point(-550,-70);

            jobDescription.Anchor = AnchorStyles.None;
            jobDescription.Font = Custom.font(14);
            jobDescription.Size = new Size(200, 60);
            jobDescription.Text = JobDescription;
            jobDescription.Location = new Point(-500, 30);

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(20);
            jobRequirement.Size = new Size(400, 60);
            jobRequirement.Text = JobRequirement;
            jobRequirement.Location = new Point(-525, 80);

            more.Anchor = AnchorStyles.None;
            more.Font = Custom.font(17);
            more.Text = "More Info";
            more.Size = new Size(290, 50);
            more.Location = new Point(450, 130);

            this.BackColor = Color.White;
            this.Controls.Add (jobName);
            this.Controls.Add (jobDescription);
            this.Controls.Add(jobRequirement);
            this.Controls.Add (more);
            this.Size = new Size(1405, 300);
           
            this.Anchor = AnchorStyles.None;
            this.Location = new Point(42,Y);
            recalculateY();

            
        }
        public static void recalculateY()
        {
            Y += 342;
        }
    }



    class jobHistory : borderedPanels
    {
        private Label jobName;
        private Label employer;
        private Label jobType;
        private Label jobRequirement;
        private Label deadline;
        private topButtons more;
        public static int Y = 42;
        public jobHistory(string JobName, string Employer, string JobType, string JobRequirement, string Deadline)
        {
            jobName = new Label();
            employer = new Label();
            jobType = new Label();
            jobRequirement = new Label();
            deadline = new Label();
            more = new topButtons(0);


            jobName.Anchor = AnchorStyles.None;
            jobName.Font = Custom.font(17);
            jobName.Size = new Size(120, 40);
            jobName.Text = JobName;
          //  jobName.BackColor = Color.Red;
            jobName.Location = new Point(-350, -20);


            employer.Anchor = AnchorStyles.None;
            employer.Font = Custom.font(12);
            employer.Size = new Size(120, 40);
            employer.Text = Employer;
            employer.Location = new Point(-350, 40);
            //employer.BackColor = Color.Blue;

            jobType.Anchor = AnchorStyles.None;
            jobType.Font = Custom.font(12);
            jobType.Size = new Size(120, 40);
            jobType.Text = JobType;
            jobType.Location = new Point(0, -20);
            //jobType.BackColor = Color.Blue;

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(11);
            jobRequirement.Size = new Size(140, 40);
            jobRequirement.Text = JobRequirement;
            jobRequirement.Location = new Point(0, 40);
            //jobRequirement.BackColor = Color.Blue;

            deadline.Anchor = AnchorStyles.None;
            deadline.Font = Custom.font(10);
            deadline.Size = new Size(200, 60);
            deadline.Text = Deadline;
            deadline.Location = new Point(400, -20);
            //deadline.BackColor = Color.Blue;

            more.Anchor = AnchorStyles.None;
            more.Font = Custom.font(10);
            more.Text = "More Info";
            more.Size = new Size(290, 50);
            more.Location = new Point(450, 90);

            this.BackColor = Color.LightGray;
            this.Controls.Add(jobName);
            this.Controls.Add(employer);
            this.Controls.Add(jobType);
            this.Controls.Add(jobRequirement);
            this.Controls.Add(deadline);
            //this.Controls.Add(more);
            this.Size = new Size(1205, 150);
            this.MouseHover += Enlarge;
            this.MouseLeave += Shrink;

            

            this.Anchor = AnchorStyles.None;
            this.Location = new Point(42, Y);
            recalculateY();


        }

        private void Shrink(object? sender, EventArgs e)
        {
            jobName.Font = Custom.font(17);
            employer.Font = Custom.font(12);


            jobName.Size = new Size(120, 40);
            employer.Size = new Size(120, 40);
            //employer.Location = new Point(-350, 40);
            //this.Controls.Add(employer);
            this.Size = new Size(1205, 150);
        }

        private void Enlarge(object? sender, EventArgs e)
        {
            jobName.Font = Custom.font(24);
            employer.Font = Custom.font(17);

            jobName.Size = new Size(220, 50);
            employer.Size = new Size(220, 40);
           // employer.Location = new Point(-350, 90);
           // this.Controls.Add(employer);
            this.Size = new Size(1205, 300);
        }

        public static void recalculateY()
        {
            Y += 342;
        }
    }
}
