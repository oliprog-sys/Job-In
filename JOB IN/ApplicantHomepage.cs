using System;
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
            jobs = new topButtons(0);
            search = new topButtons(0);
            status = new topButtons(0);
            profile = new topButtons(0);
            jobsPane = new Panel();
            searchPane = new Panel();
            statusPane = new Panel();
            profilePane = new borderedPanels();
            MainPanel = new Panel();

            jobs.Anchor = AnchorStyles.None;
            jobs.Font = new Font("Istok Web", 12F);
            jobs.Location = new Point(-647, -380);
            jobs.Size = new Size(140, 80);
            jobs.Text = "Jobs";

            search.Anchor = AnchorStyles.None;
            search.Font = new Font("Istok Web", 12F);
            search.Location = new Point( -215, -380);
            search.Size = new Size(140, 80);
            search.Text = "Search";

            status.Anchor = AnchorStyles.None;
            status.Font = new Font("Istok Web", 12F);
            status.Location = new Point(215, -380);
            status.Size = new Size(140, 80);
            status.Text = "Status";

            profile.Anchor = AnchorStyles.None;
            profile.Font = new Font("Istok Web", 12F);
            profile.Location = new Point(647, -380);
            profile.Size = new Size(140, 80);
            profile.Text = "Profile";


            profilePane.Anchor = AnchorStyles.None;
            profilePane.AutoScroll = true;
            profilePane.BackColor = Color.White;
            profilePane.Size = new Size(1434, 675);
            profilePane.Location = new Point(-647, -220);
            profilePane.BorderStyle = BorderStyle.None;


            MainPanel.Controls.Add(jobs);
            MainPanel.Controls.Add(search);
            MainPanel.Controls.Add(status);
            MainPanel.Controls.Add(profile);
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
            Name = "Form1";
            Text = "Form1";


        }
    }
}
