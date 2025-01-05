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
            search = new topButtons(0);
            status = new topButtons(0);
            profile = new topButtons(0);
            jobsPane = new borderedscrollPanels();
            searchPane = new borderedscrollPanels();
            statusPane = new borderedPanels();
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
           
            jobs.TabStop = false;



            searchPane.Anchor = AnchorStyles.None;
            searchPane.AutoScroll = true;
            searchPane.BackColor = Color.Green;
            searchPane.Size = new Size(1413, 675);
            searchPane.Location = new Point(10, 10);
            searchPane.BorderStyle = BorderStyle.None;

            statusPane.Anchor = AnchorStyles.None;
            statusPane.AutoScroll = true;
            statusPane.BackColor = Color.Blue;
            statusPane.Size = new Size(1413, 675);
            statusPane.Location = new Point(10, 10);
            statusPane.BorderStyle = BorderStyle.None;

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
                jobsPane.Controls.Add(new jobDesc("title", " description", "requirement"));
            }
        }
        

        //Fetches the job info as a series of strings from the database and creates a panel that will be added to an array list
        public void job_list_fetcher(ArrayList jobList)
        {

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
            jobName.Text = JobName;
            jobName.Location = new Point(-500,-50);

            jobDescription.Anchor = AnchorStyles.None;
            jobDescription.Text = JobDescription;
            jobDescription.Location = new Point(0, 40);

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Text = JobRequirement;
            jobRequirement.Location = new Point(0, 80);

            this.BackColor = Color.White;
            this.Controls.Add (jobName);
            this.Controls.Add (jobDescription);
            this.Controls.Add(jobRequirement);
            // this.Controls.Add (more);
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
}
