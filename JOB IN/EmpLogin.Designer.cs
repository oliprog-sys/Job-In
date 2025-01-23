using System.Runtime.InteropServices;
using System.Windows.Forms;
using JOB_IN.RJControls;
using System.Collections;


namespace JOB_IN
{
    partial class EmpLogin
    {
        organization org;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nleft, int ntop, int nright, int nbottom, int nwidthEllipse, int nheightEllipse);

        private void InitializeComponent()
        {
            Postbtn = new Customb();
            historybtn = new Customb();
            Jobs = new Customb();
            Profilebtn = new Customb();
            jobpanel = new borderedscrollPanels();
            postpanel = new borderedPanels();
            postb = new Customb();
            numericUpDown1 = new NumericUpDown();
            excomp = new ComboBox();
            roundedTextBox3 = new RoundedTextBox();
            roundedTextBox2 = new RoundedTextBox();
            numofappl = new Label();
            expl = new Label();
            Reql = new Label();
            jobdescl = new Label();
            panel1 = new Panel();
            postbackp = new borderedPanels();
            profilebackp = new borderedPanels();
            historybackp = new borderedPanels();
            Jobbackp = new borderedPanels();
            historypanel = new borderedPanels();
            profilepanel = new borderedPanels();
            editbtn = new Customb();
            smpanel = new borderedPanels();
            smlbl = new Label();
            biop = new borderedPanels();
            biolbl = new Label();
            orglbl = new Label();
            emaillbl = new Label();
            phonelbl = new Label();
            adlbl = new Label();
            namelbl = new Label();
            orgicon = new PictureBox();
            backbtn = new Customb();
            backbtnp = new borderedPanels();
            postpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            postbackp.SuspendLayout();
            profilebackp.SuspendLayout();
            historybackp.SuspendLayout();
            Jobbackp.SuspendLayout();
            profilepanel.SuspendLayout();
            biop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orgicon).BeginInit();
            backbtnp.SuspendLayout();
            SuspendLayout();
            // 
            // Postbtn
            // 
            Postbtn.Anchor = AnchorStyles.Left;
            Postbtn.BackColor = Color.RoyalBlue;
            Postbtn.BackgroundColor = Color.RoyalBlue;
            Postbtn.BorderColor = Color.RoyalBlue;
            Postbtn.BorderColor1 = Color.RoyalBlue;
            Postbtn.BorderRadius = 20;
            Postbtn.BorderRadius1 = 20;
            Postbtn.BorderSize = 0;
            Postbtn.BorderSize1 = 0;
            Postbtn.FlatAppearance.BorderSize = 0;
            Postbtn.FlatStyle = FlatStyle.Flat;
            Postbtn.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            Postbtn.ForeColor = Color.White;
            Postbtn.Location = new Point(16, 18);
            Postbtn.Name = "Postbtn";
            Postbtn.Size = new Size(231, 43);
            Postbtn.TabIndex = 3;
            Postbtn.Text = "Post";
            Postbtn.TextColor = Color.RoyalBlue;
            Postbtn.UseVisualStyleBackColor = false;
            Postbtn.Click += postbtn_Click;
            // 
            // historybtn
            // 
            historybtn.Anchor = AnchorStyles.Left;
            historybtn.BackColor = Color.RoyalBlue;
            historybtn.BackgroundColor = Color.RoyalBlue;
            historybtn.BorderColor = Color.RoyalBlue;
            historybtn.BorderColor1 = Color.RoyalBlue;
            historybtn.BorderRadius = 20;
            historybtn.BorderRadius1 = 20;
            historybtn.BorderSize = 0;
            historybtn.BorderSize1 = 0;
            historybtn.FlatAppearance.BorderSize = 0;
            historybtn.FlatStyle = FlatStyle.Flat;
            historybtn.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            historybtn.ForeColor = Color.White;
            historybtn.Location = new Point(16, 14);
            historybtn.Name = "historybtn";
            historybtn.Size = new Size(231, 43);
            historybtn.TabIndex = 2;
            historybtn.Text = "History";
            historybtn.TextColor = Color.RoyalBlue;
            historybtn.UseVisualStyleBackColor = false;
            historybtn.Click += historybtn_Click;
            // 
            // Jobs
            // 
            Jobs.Anchor = AnchorStyles.Left;
            Jobs.BackColor = Color.RoyalBlue;
            Jobs.BackgroundColor = Color.RoyalBlue;
            Jobs.BorderColor = Color.RoyalBlue;
            Jobs.BorderColor1 = Color.RoyalBlue;
            Jobs.BorderRadius = 20;
            Jobs.BorderRadius1 = 20;
            Jobs.BorderSize = 2;
            Jobs.BorderSize1 = 2;
            Jobs.FlatAppearance.BorderSize = 0;
            Jobs.FlatStyle = FlatStyle.Flat;
            Jobs.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            Jobs.ForeColor = Color.Snow;
            Jobs.Location = new Point(26, 17);
            Jobs.Name = "Jobs";
            Jobs.Size = new Size(198, 40);
            Jobs.TabIndex = 2;
            Jobs.Text = "Jobs";
            Jobs.TextColor = Color.RoyalBlue;
            Jobs.UseVisualStyleBackColor = false;
            Jobs.Click += Jobs_Click;
            // 
            // Profilebtn
            // 
            Profilebtn.Anchor = AnchorStyles.Left;
            Profilebtn.BackColor = Color.RoyalBlue;
            Profilebtn.BackgroundColor = Color.RoyalBlue;
            Profilebtn.BorderColor = Color.RoyalBlue;
            Profilebtn.BorderColor1 = Color.RoyalBlue;
            Profilebtn.BorderRadius = 20;
            Profilebtn.BorderRadius1 = 20;
            Profilebtn.BorderSize = 2;
            Profilebtn.BorderSize1 = 2;
            Profilebtn.FlatAppearance.BorderSize = 0;
            Profilebtn.FlatStyle = FlatStyle.Flat;
            Profilebtn.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            Profilebtn.ForeColor = Color.White;
            Profilebtn.Location = new Point(16, 14);
            Profilebtn.Name = "Profilebtn";
            Profilebtn.Size = new Size(231, 43);
            Profilebtn.TabIndex = 3;
            Profilebtn.Text = "Profile";
            Profilebtn.TextColor = Color.RoyalBlue;
            Profilebtn.UseVisualStyleBackColor = false;
            Profilebtn.Click += Profilebtn_Click;
            // 
            // jobpanel
            // 
            jobpanel.Anchor = AnchorStyles.None;
            jobpanel.BackColor = Color.RoyalBlue;
            jobpanel.BorderRadius = 20;
            jobpanel.BorderSize = 0;
            jobpanel.Location = new Point(49, 125);
            jobpanel.Name = "jobpanel";
            jobpanel.Size = new Size(1453,686 );
            jobpanel.TabIndex = 0;
            jobpanel.AutoScroll = true;
            

            
            // 
            // postpanel
            // 
            postpanel.Anchor = AnchorStyles.None;
            postpanel.BackColor = Color.FromArgb(64, 64, 64);
            postpanel.BorderRadius = 20;
            postpanel.BorderSize = 0;
            postpanel.Controls.Add(postb);
            postpanel.Controls.Add(numericUpDown1);
            postpanel.Controls.Add(excomp);
            postpanel.Controls.Add(roundedTextBox3);
            postpanel.Controls.Add(roundedTextBox2);
            postpanel.Controls.Add(numofappl);
            postpanel.Controls.Add(expl);
            postpanel.Controls.Add(Reql);
            postpanel.Controls.Add(jobdescl);

            
            postpanel.Location = new Point(47, 125);
            postpanel.Name = "postpanel";
            postpanel.Size = new Size(1434, 689);
            postpanel.TabIndex = 1;
            // 
            // postb
            // 
            postb.BackColor = Color.RoyalBlue;
            postb.BackgroundColor = Color.RoyalBlue;
            postb.BorderColor = Color.PaleVioletRed;
            postb.BorderColor1 = Color.PaleVioletRed;
            postb.BorderRadius = 25;
            postb.BorderRadius1 = 25;
            postb.BorderSize = 0;
            postb.BorderSize1 = 0;
            postb.FlatAppearance.BorderSize = 0;
            postb.FlatStyle = FlatStyle.Flat;
            postb.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            postb.ForeColor = Color.White;
            postb.Location = new Point(1167, 565);
            postb.Name = "postb";
            postb.Size = new Size(188, 50);
            postb.TabIndex = 10;
            postb.Text = "Post";
            postb.TextColor = Color.RoyalBlue;
            postb.UseVisualStyleBackColor = false;
            postb.Click += postJob;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Cascadia Mono SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(1126, 75);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 28);
            numericUpDown1.TabIndex = 9;
            // 
            // excomp
            // 
            excomp.BackColor = Color.Coral;
            excomp.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            excomp.ForeColor = Color.White;
            excomp.FormattingEnabled = true;
            excomp.Items.AddRange(new object[] { "Entry", "Junior", "Expert" });
            excomp.Location = new Point(1070, 265);
            excomp.Name = "excomp";
            excomp.Size = new Size(229, 35);
            excomp.TabIndex = 8;
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.Location = new Point(56, 391);
            roundedTextBox3.Multiline = true;
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.Size = new Size(623, 224);
            roundedTextBox3.TabIndex = 7;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.Location = new Point(56, 120);
            roundedTextBox2.Multiline = true;
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.Size = new Size(623, 180);
            roundedTextBox2.TabIndex = 6;
            // 
            // numofappl
            // 
            numofappl.AutoSize = true;
            numofappl.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numofappl.ForeColor = Color.White;
            numofappl.Location = new Point(831, 68);
            numofappl.Name = "numofappl";
            numofappl.Size = new Size(273, 30);
            numofappl.TabIndex = 4;
            numofappl.Text = "Number of Applicants";
            // 
            // expl
            // 
            expl.AutoSize = true;
            expl.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expl.ForeColor = Color.White;
            expl.Location = new Point(831, 265);
            expl.Name = "expl";
            expl.Size = new Size(221, 30);
            expl.TabIndex = 3;
            expl.Text = "Experience Level";

            catlbl = new Label();
            catlbl.AutoSize = true;
            catlbl.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold);
            catlbl.ForeColor = Color.White;
            catlbl.Location = new Point(831, 390);
            catlbl.Anchor= AnchorStyles.None;
            catlbl.Size = new Size(221, 30);
            catlbl.TabIndex = 3;
            catlbl.Text = "Job Catagory";
            postpanel.Controls.Add(catlbl);

            catcb = new ComboBox();
            catcb.BackColor = Color.Coral;
            catcb.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            catcb.ForeColor = Color.White;
            catcb.FormattingEnabled = true;
            foreach (var n in Custom.job_category)
            {
                catcb.Items.Add(n);
            }
            catcb.Location = new Point(1070, 390);
            catcb.Name = "excomp";
            catcb.Size = new Size(350, 35);
            //catcb.TabIndex = 8;
            postpanel.Controls.Add(catcb);


            jname = new Label();
            jname.AutoSize = true;
            jname.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold);
            jname.ForeColor = Color.White;
            jname.Location = new Point(831, 330);
            jname.Anchor = AnchorStyles.None;
            jname.Size = new Size(221, 30);
            jname.TabIndex = 3;
            jname.Text = "Job Name";
            postpanel.Controls.Add(jname);


            jnametxt = new TextBox();
            jnametxt.Size = new Size(350, 0);
            jnametxt.Location = new Point(1070, 330);
            postpanel.Controls.Add(jnametxt);


            // 
            // Reql
            // 
            Reql.AutoSize = true;
            Reql.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reql.ForeColor = Color.White;
            Reql.Location = new Point(56, 330);
            Reql.Name = "Reql";
            Reql.Size = new Size(169, 30);
            Reql.TabIndex = 2;
            Reql.Text = "Requirements";
            // 
            // jobdescl
            // 
            jobdescl.AutoSize = true;
            jobdescl.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jobdescl.ForeColor = Color.White;
            jobdescl.Location = new Point(56, 68);
            jobdescl.Name = "jobdescl";
            jobdescl.Size = new Size(208, 30);
            jobdescl.TabIndex = 1;
            jobdescl.Text = "Job Description";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(backbtnp);
            panel1.Controls.Add(postbackp);
            panel1.Controls.Add(profilebackp);
            panel1.Controls.Add(historybackp);
            panel1.Controls.Add(Jobbackp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1610, 104);
            panel1.TabIndex = 3;
            // 
            // postbackp
            // 
            postbackp.BorderRadius = 10;
            postbackp.BorderSize = 0;
            postbackp.Controls.Add(Postbtn);
            postbackp.Location = new Point(605, 35);
            postbackp.Name = "postbackp";
            postbackp.Size = new Size(263, 87);
            postbackp.TabIndex = 6;
            // 
            // profilebackp
            // 
            profilebackp.BorderRadius = 10;
            profilebackp.BorderSize = 0;
            profilebackp.Controls.Add(Profilebtn);
            profilebackp.Location = new Point(1234, 35);
            profilebackp.Name = "profilebackp";
            profilebackp.Size = new Size(263, 79);
            profilebackp.TabIndex = 7;
            // 
            // historybackp
            // 
            historybackp.BorderRadius = 10;
            historybackp.BorderSize = 0;
            historybackp.Controls.Add(historybtn);
            historybackp.Location = new Point(922, 35);
            historybackp.Name = "historybackp";
            historybackp.Size = new Size(263, 79);
            historybackp.TabIndex = 8;
            // 
            // Jobbackp
            // 
            Jobbackp.BorderRadius = 10;
            Jobbackp.BorderSize = 0;
            Jobbackp.Controls.Add(Jobs);
            Jobbackp.Location = new Point(312, 35);
            Jobbackp.Name = "Jobbackp";
            Jobbackp.Size = new Size(242, 79);
            Jobbackp.TabIndex = 5;
            // 
            // historypanel
            // 
            historypanel.Anchor = AnchorStyles.None;
            historypanel.BackColor = Color.LightGray;
            historypanel.BorderRadius = 20;
            historypanel.BorderSize = 0;
            historypanel.Location = new Point(47, 125);
            historypanel.Name = "historypanel";
            historypanel.Size = new Size(1434, 689);
            historypanel.TabIndex = 1;
            // 
            // profilepanel
            // 
            profilepanel.Anchor = AnchorStyles.None;
            profilepanel.BackColor = Color.White;
            profilepanel.BorderRadius = 20;
            profilepanel.BorderSize = 0;
            profilepanel.Controls.Add(editbtn);
            profilepanel.Controls.Add(smpanel);
            profilepanel.Controls.Add(smlbl);
            profilepanel.Controls.Add(biop);
            profilepanel.Controls.Add(orglbl);
            profilepanel.Controls.Add(emaillbl);
            profilepanel.Controls.Add(phonelbl);
            profilepanel.Controls.Add(adlbl);
            profilepanel.Controls.Add(namelbl);
            profilepanel.Controls.Add(orgicon);
            profilepanel.Location = new Point(47, 125);
            profilepanel.Name = "profilepanel";
            profilepanel.Size = new Size(1434, 689);
            profilepanel.TabIndex = 1;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.Coral;
            editbtn.BackgroundColor = Color.Coral;
            editbtn.BorderColor = Color.PaleVioletRed;
            editbtn.BorderColor1 = Color.PaleVioletRed;
            editbtn.BorderRadius = 20;
            editbtn.BorderRadius1 = 20;
            editbtn.BorderSize = 0;
            editbtn.BorderSize1 = 0;
            editbtn.FlatAppearance.BorderSize = 0;
            editbtn.FlatStyle = FlatStyle.Flat;
            editbtn.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editbtn.ForeColor = Color.White;
            editbtn.Location = new Point(1128, 597);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(188, 50);
            editbtn.TabIndex = 8;
            editbtn.Text = "Edit";
            editbtn.TextColor = Color.Coral;
            editbtn.UseVisualStyleBackColor = false;
            // 
            // smpanel
            // 
            smpanel.BackColor = SystemColors.Control;
            smpanel.BorderRadius = 10;
            smpanel.BorderSize = 0;
            smpanel.Location = new Point(912, 109);
            smpanel.Name = "smpanel";
            smpanel.Size = new Size(445, 153);
            smpanel.TabIndex = 7;
            // 
            // smlbl
            // 
            smlbl.AutoSize = true;
            smlbl.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smlbl.Location = new Point(976, 54);
            smlbl.Name = "smlbl";
            smlbl.Size = new Size(305, 37);
            smlbl.TabIndex = 4;
            smlbl.Text = "Social Media Links";
            // 
            // biop
            // 
            biop.BackColor = SystemColors.Control;
            biop.BorderRadius = 15;
            biop.BorderSize = 0;
            biop.Controls.Add(biolbl);
            biop.Location = new Point(94, 419);
            biop.Name = "biop";
            biop.Size = new Size(771, 228);
            biop.TabIndex = 6;
            // 
            // biolbl
            // 
            biolbl.AutoSize = true;
            biolbl.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            biolbl.Location = new Point(12, 25);
            biolbl.Name = "biolbl";
            biolbl.Size = new Size(81, 37);
            biolbl.TabIndex = 7;
            biolbl.Text = "Bio:";
            // 
            // orglbl
            // 
            orglbl.AutoSize = true;
            orglbl.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orglbl.Location = new Point(90, 240);
            orglbl.Name = "orglbl";
            orglbl.Size = new Size(289, 37);
            orglbl.TabIndex = 5;
            orglbl.Text = "Organization Type";
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emaillbl.Location = new Point(90, 293);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(97, 37);
            emaillbl.TabIndex = 4;
            emaillbl.Text = "Email";
            // 
            // phonelbl
            // 
            phonelbl.AutoSize = true;
            phonelbl.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phonelbl.Location = new Point(90, 351);
            phonelbl.Name = "phonelbl";
            phonelbl.Size = new Size(209, 37);
            phonelbl.TabIndex = 3;
            phonelbl.Text = "Phone Number";
            // 
            // adlbl
            // 
            adlbl.AutoSize = true;
            adlbl.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adlbl.Location = new Point(367, 351);
            adlbl.Name = "adlbl";
            adlbl.Size = new Size(129, 37);
            adlbl.TabIndex = 2;
            adlbl.Text = "Address";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelbl.Location = new Point(90, 192);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(81, 37);
            namelbl.TabIndex = 1;
            namelbl.Text = "Name";
            // 
            // orgicon
            // 
            orgicon.Location = new Point(90, 54);
            orgicon.Name = "orgicon";
            orgicon.Size = new Size(152, 121);
            orgicon.TabIndex = 0;
            orgicon.TabStop = false;
            
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.Black;
            backbtn.BackgroundColor = Color.Black;
            backbtn.BorderColor = Color.PaleVioletRed;
            backbtn.BorderColor1 = Color.PaleVioletRed;
            backbtn.BorderRadius = 20;
            backbtn.BorderRadius1 = 20;
            backbtn.BorderSize = 0;
            backbtn.BorderSize1 = 0;
            backbtn.FlatAppearance.BorderSize = 0;
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.ForeColor = Color.White;
            backbtn.Location = new Point(12, 49);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(110, 41);
            backbtn.TabIndex = 4;
            backbtn.Text = "Back";
            backbtn.TextColor = Color.Black;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // backbtnp
            // 
            backbtnp.BorderRadius = 40;
            backbtnp.BorderSize = 0;
            backbtnp.Controls.Add(backbtn);
            backbtnp.Dock = DockStyle.Left;
            backbtnp.Location = new Point(0, 0);
            backbtnp.Name = "backbtnp";
            backbtnp.Size = new Size(250, 104);
            backbtnp.TabIndex = 9;
            // 
            // EmpLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 898);
            Controls.Add(historypanel);
            Controls.Add(panel1);
            Controls.Add(postpanel);
            Controls.Add(profilepanel);
            Controls.Add(jobpanel);
            Name = "EmpLogin";
            Text = "LoginForm";
            FormClosing += CloseApp;
            Load += LoginForm_Load;
            postpanel.ResumeLayout(false);
            postpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            postbackp.ResumeLayout(false);
            profilebackp.ResumeLayout(false);
            historybackp.ResumeLayout(false);
            Jobbackp.ResumeLayout(false);
            profilepanel.ResumeLayout(false);
            profilepanel.PerformLayout();
            biop.ResumeLayout(false);
            biop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orgicon).EndInit();
            backbtnp.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void postJob(object sender, EventArgs e)
        {
            Job job = new Job();
            job.name= jnametxt.Text;
            job.description=roundedTextBox2.Text;
            job.requirement = roundedTextBox3.Text;
            job.category = catcb.Text;
            job.capacity=(int) numericUpDown1.Value;
            job.oEmail = org.email;
            job.Deadline= DateTime.Now;
            bool success = Db.insertJob(job);
            if (success)
            {
                MessageBox.Show("Job posted successfully");

            }
            else
            {
                MessageBox.Show("Job not posted successfully");
            }

        }

        // #endregion
        private RJControls.Customb Jobs;
        private RJControls.Customb Postbtn;
        private RJControls.Customb historybtn;
        private RJControls.Customb Profilebtn;
      
        private Panel panel1;
        private borderedPanels Jobbackp;
        
        private void CloseApp(object? sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private borderedPanels postbackp;
        private borderedPanels profilebackp;
        private borderedPanels historybackp;
        private borderedscrollPanels jobpanel;
        private borderedPanels postpanel;
        private Label numofappl;
        private Label expl;
        private Label Reql;
        private Label jobdescl;
        private RoundedTextBox roundedTextBox2;
        private RoundedTextBox roundedTextBox3;
        private ComboBox excomp;
        private NumericUpDown numericUpDown1;
        private Customb postb;
        private borderedPanels historypanel;
        private borderedPanels profilepanel;
        private PictureBox orgicon;
        private Label namelbl;
        private Label orglbl;
        private Label emaillbl;
        private Label phonelbl;
        private Label adlbl;
        private Label smlbl;
        private borderedPanels biop;
        private Label biolbl;
        private Customb editbtn;
        private borderedPanels smpanel;
        private Customb backbtn;
        private borderedPanels backbtnp;
        private Label catlbl;
        private ComboBox catcb;
        private Label jname;
        private TextBox jnametxt;


        public void joblist()
        {
            ArrayList arr = Db.fetchOrgJobs(org.email);
            
           foreach(Job i in arr)
            {
                jobpanel.Controls.Add(new jobDesc(i.name, i.description, i.requirement));
            }
        }
    }

}