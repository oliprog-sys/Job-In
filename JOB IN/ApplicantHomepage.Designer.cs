using JOB_IN.RJControls;
namespace JOB_IN
{
    partial class ApplicantHomepage
    {
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
                this.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public static bool hidden=false;
        private TextBox searchBox;
        private topButtons searchButton;
        private topButtons jobs;
        private topButtons search;
        private topButtons status;
        private topButtons sAllbutton;
        private topButtons sPendingbutton;
        private topButtons sAcceptedbutton;
        private topButtons sDeniedbutton;
        private topButtons profile;
        public topButtons exit;
        private borderedscrollPanels jobsPane;
        private borderedscrollPanels searchResultsPane;
        private borderedscrollPanels statusScrollPane;
        private borderedPanels searchPane;
        private borderedPanels statusPane;
        private borderedPanels subMain;
        private borderedPanels profilePane;
        private Panel MainPanel;

      
    }
}