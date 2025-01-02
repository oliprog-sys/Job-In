
namespace JOB_IN
{
    internal static class Program
    {
        static Form1 strt_form;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            strt_form = new Form1();
            //strt_form.Show();
            Application.Run(strt_form);
           // Application.Exit();


          
        }

       
    }
}