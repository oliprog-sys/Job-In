using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_IN
{
    public partial class ApplicantHomepage : Form
    {
        public ApplicantHomepage()
        {
            InitializeComponents();
        }
        public void InitializeComponents()
        {
            jobs = new topButtons(2);
            search = new topButtons(0);
            status = new topButtons(0);
            profile = new topButtons(0);
            jobsPane = new borderedPanels();
            searchPane = new borderedPanels();
            statusPane = new borderedPanels();
            profilePane = new borderedPanels();
            MainPanel = new Panel();

            jobs.Name = "jobs";
            jobs.Anchor = AnchorStyles.None;
            jobs.Font = new Font("Istok Web", 12F);
            jobs.Location = new Point(-647, -380);
            jobs.Size = new Size(140, 80);
            jobs.Text = "Jobs";
            jobs.Click += job_nav_MouseClick;

            search.Anchor = AnchorStyles.None;
            search.Font = new Font("Istok Web", 12F);
            search.Location = new Point( -215, -380);
            search.Size = new Size(140, 80);
            search.Text = "Search";
            search.Click += search_nav_MouseClick;

            status.Anchor = AnchorStyles.None;
            status.Font = new Font("Istok Web", 12F);
            status.Location = new Point(215, -380);
            status.Size = new Size(140, 80);
            status.Text = "Status";
            status.Click += status_nav_MouseClick;

            profile.Anchor = AnchorStyles.None;
            profile.Font = new Font("Istok Web", 12F);
            profile.Location = new Point(647, -380);
            profile.Size = new Size(140, 80);
            profile.Text = "Profile";
            profile.Click += profile_nav_MouseClick;

            jobsPane.Anchor = AnchorStyles.None;
            jobsPane.AutoScroll = true;
            jobsPane.BackColor = Color.White;
            jobsPane.Size = new Size(1434, 675);
            jobsPane.Location = new Point(-647, -220);
            jobsPane.BorderStyle = BorderStyle.None;


            searchPane.Anchor = AnchorStyles.None;
            searchPane.AutoScroll = true;
            searchPane.BackColor = Color.Green;
            searchPane.Size = new Size(1434, 675);
            searchPane.Location = new Point(-647, -220);
            searchPane.BorderStyle = BorderStyle.None;

            statusPane.Anchor = AnchorStyles.None;
            statusPane.AutoScroll = true;
            statusPane.BackColor = Color.Blue;
            statusPane.Size = new Size(1434, 675);
            statusPane.Location = new Point(-647, -220);
            statusPane.BorderStyle = BorderStyle.None;

            profilePane.Anchor = AnchorStyles.None;
            profilePane.AutoScroll = true;
            profilePane.BackColor = Color.BlueViolet;
            profilePane.Size = new Size(1434, 675);
            profilePane.Location = new Point(-647, -220);
            profilePane.BorderStyle = BorderStyle.None;

           

            MainPanel.Controls.Add(jobs);
            MainPanel.Controls.Add(search);
            MainPanel.Controls.Add(status);
            MainPanel.Controls.Add(profile);
            MainPanel.Controls.Add(jobsPane);
            MainPanel.Controls.Add(searchPane);
            MainPanel.Controls.Add(statusPane);
            MainPanel.Controls.Add(profilePane);

            MainPanel.Dock = DockStyle.Fill;
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
            Text = "Form1";

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
        public void job_list_adder()
        {
            ArrayList jobList= new ArrayList { };
            job_list_fetcher(jobList);
            //used to control the vertical spacing of the 
            int j = 0;
            foreach(borderedPanels i in jobList)
            {
                i.Location = new Point(j,10);
                jobsPane.Controls.Add(i);
                j += i.Width + 20;
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
}
