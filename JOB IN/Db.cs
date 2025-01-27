using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace JOB_IN
{
    public class Db
    {
       // static string ConnectionString= "Data Source=.;Initial Catalog=Job_in;Integrated Security=True;Trust Server Certificate=True";
        static string ConnectionString = "Data Source=.;Initial Catalog=Job_in;Integrated Security=True;";
        public static bool InsertApplicant()
        {
            applicants b = new applicants("abebe", "091121", DateTime.Now, "abebe@gmail.com", "abebe11", "abe in the house", "abe likes work", "abe no work", 2, "notworking");
            int r;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into applicant(Name,Phone_num,DOB,AEmail, Password, Skill_description, Job_category,Experience , Work_status) values (@1,@2,@3,@4,@5,@6,@7,@8,@9);";
                command.Parameters.AddWithValue("@1", b.name);
                command.Parameters.AddWithValue("@2", b.PhoneNum);
                command.Parameters.AddWithValue("@3", b.dob);
                command.Parameters.AddWithValue("@4", b.email);
                command.Parameters.AddWithValue("@5", b.password);
                command.Parameters.AddWithValue("@6", b.skill_description);
                command.Parameters.AddWithValue("@7", b.job_description);
                command.Parameters.AddWithValue("@8", b.experience);
                command.Parameters.AddWithValue("@9", b.work_status);
          //      command.CommandText = String.Format(commandText, b.name, b.PhoneNum, b.dob, b.email, b.password, b.description, b.skill_description, b.job_description, b.experience, b.work_status);
                command.Connection = conn;
                r = command.ExecuteNonQuery();
            }

                return true;
        }

        public static bool check(string email, string password)
        {
            Object r;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select count (*) from Applicant where AEmail=@1 and Password=@2;";
                command.Parameters.AddWithValue("@1", email);
                command.Parameters.AddWithValue("@2", password);
                
                //      command.CommandText = String.Format(commandText, b.name, b.PhoneNum, b.dob, b.email, b.password, b.description, b.skill_description, b.job_description, b.experience, b.work_status);
                command.Connection = conn;
                r = command.ExecuteScalar();
            
            }
            if ((int)r ==  1)
            {
                return true;
            }
            return false;
        }

        public static applicants fetchApplicantinfo(string email)
        {
            SqlDataReader s;
            applicants app;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Applicant where AEmail=@1;";
                command.Parameters.AddWithValue("@1", email);

                //      command.CommandText = String.Format(commandText, b.name, b.PhoneNum, b.dob, b.email, b.password, b.description, b.skill_description, b.job_description, b.experience, b.work_status);
                command.Connection = conn;
                s = command.ExecuteReader();
                s.Read();
                app = new applicants(s["Name"].ToString(), s["Phone_num"].ToString(), (DateTime)s["DOB"], s["AEmail"].ToString(), s["Password"].ToString(), s["Skill_description"].ToString(), s["Skill_description"].ToString(), s["Job_category"].ToString(), (int)s["Experience"], s["Work_status"].ToString());


            }
            return app;

        }

        public static organization fetchOrganizationInfo(string email)
        {
            SqlDataReader s;
            organization org;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Organization where OEmail=@1;";
                command.Parameters.AddWithValue("@1", email);

                //      command.CommandText = String.Format(commandText, b.name, b.PhoneNum, b.dob, b.email, b.password, b.description, b.skill_description, b.job_description, b.experience, b.work_status);
                command.Connection = conn;
                s = command.ExecuteReader();
                s.Read();
                org = new organization(s["OName"].ToString(), s["phoneNum"].ToString(), s["OEmail"].ToString(), s["Password"].ToString(), s["Address"].ToString(), s["Description"].ToString(), s["mediaLink"].ToString());


            }
            return org;

        }

        public static bool checkOrganization(string email, string password)
        {
            Object r;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select count (*) from Organization where OEmail=@1 and Password=@2;";
                command.Parameters.AddWithValue("@1", email);
                command.Parameters.AddWithValue("@2", password);

                //      command.CommandText = String.Format(commandText, b.name, b.PhoneNum, b.dob, b.email, b.password, b.description, b.skill_description, b.job_description, b.experience, b.work_status);
                command.Connection = conn;
                r = command.ExecuteScalar();

            }
            if ((int)r == 1)
            {
                return true;
            }
            return false;
        }

        public static bool insertJob(Job job)
        {
            int a;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Jobs(Job_description,Requirement,capacity, Deadline, OEmail, Job_name, Job_category,job_exp_level) values(@1,@2,@3,@4,@5,@6,@7,@8);";
                command.Parameters.AddWithValue("@1", job.description);
                command.Parameters.AddWithValue("@2", job.requirement);
                command.Parameters.AddWithValue("@3", job.capacity);
                command.Parameters.AddWithValue("@4", job.Deadline);
                command.Parameters.AddWithValue("@5", job.oEmail);
                command.Parameters.AddWithValue("@6", job.name);
                command.Parameters.AddWithValue("@7", job.category);
                command.Parameters.AddWithValue("@8", job.Explevel);
                a = command.ExecuteNonQuery();
            }
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool UpdateOrgInfo(organization org)
        {
            int a;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update Organization set OName = @1 , phoneNum = @2,Address = @3,Password = @4,Description = @5,mediaLink= @7 where OEmail = @6";
                command.Parameters.AddWithValue("@1", org.name);
                command.Parameters.AddWithValue("@2", org.PhoneNum);
                command.Parameters.AddWithValue("@3", org.address);
                command.Parameters.AddWithValue("@4",org.password);
                command.Parameters.AddWithValue("@5", org.description);
                command.Parameters.AddWithValue("@6", org.email);
                command.Parameters.AddWithValue("@7",org.mediaLink);
                
                a = command.ExecuteNonQuery();
            }
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ArrayList fetchOrgJobs(string email)
        {
            ArrayList arrayList = new ArrayList();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Jobs where OEmail=@1;";
                command.Parameters.AddWithValue("@1", email);
                SqlDataReader a = command.ExecuteReader();
                while (a.Read())
                {
                    arrayList.Add(new Job((int)a["Job_id"], a["Job_name"].ToString(), a["Job_category"].ToString(), a["OEmail"].ToString(),(int) a["capacity"], a["requirement"].ToString(), a["Job_description"].ToString(), (DateTime)a["Deadline"], a["job_exp_level"].ToString()));
                }
            }
           
                return arrayList;
            

        }

        public static ArrayList fetchJobs(string category)
        {
            ArrayList arrayList = new ArrayList();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Jobs where category=@1;";
                command.Parameters.AddWithValue("@1", category);
                SqlDataReader a = command.ExecuteReader();
                while (a.Read())
                {
                    arrayList.Add(new Job((int)a["Job_id"], a["Job_name"].ToString(), a["Job_category"].ToString(), a["OEmail"].ToString(), (int)a["capacity"], a["requirement"].ToString(), a["Job_description"].ToString(), (DateTime)a["Deadline"], a["job_exp_level"].ToString()));
                }
            }

            return arrayList;

        }


        public static ArrayList fetchOrgJobsothers(string email)
        {
            ArrayList arrayList = new ArrayList();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Jobs where OEmail!=@1;";
                command.Parameters.AddWithValue("@1", email);
                SqlDataReader a = command.ExecuteReader();
                while (a.Read())
                {
                    arrayList.Add(new Job((int)a["Job_id"], a["Job_name"].ToString(), a["Job_category"].ToString(), a["OEmail"].ToString(), (int)a["capacity"], a["requirement"].ToString(), a["Job_description"].ToString(), (DateTime)a["Deadline"], a["job_exp_level"].ToString()));
                }
            }

            return arrayList;


        }

        public static ArrayList applied_list(int jid)
        {
            ArrayList arrayList = new ArrayList();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select Aemail from ApplicantJob where Job_id=@1;";
                command.Parameters.AddWithValue("@1", jid);
                SqlDataReader a = command.ExecuteReader();
                while (a.Read())
                {
                    arrayList.Add(a["AEmail"].ToString());
                }
            }

            return arrayList;

        }
        public static bool Accepted(int jid)
        {
            int a;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update ApplicantJob set Message='Accepted' where Job_id=@1 ";
                command.Parameters.AddWithValue("@1", jid);

                a = command.ExecuteNonQuery();
            }
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Rejected(int jid)
        {
            int a;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update ApplicantJob set Message='Rejected' where Job_id=@1";
                command.Parameters.AddWithValue("@1", jid);

                a = command.ExecuteNonQuery();
            }
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class applicants
    {
        public string name;
        public string PhoneNum;
        public DateTime dob;
        public string email;
        public string password;
        public string description;
        public string skill_description;
        public string job_description;
        public int experience;
        public string work_status;
        // CV varbinary(max) not null,
        // Photo varbinary

        public applicants( string name, string PhoneNum, DateTime dob, string email, string password, string description, string skill_description, string job_description, int experience, string work_status)
        {
            this.name = name; 
            this.PhoneNum = PhoneNum;
            this.dob = dob;
            this.email = email;
            this.password = password;
            this.description = description;
            this.skill_description = skill_description;
            this.job_description = job_description;
            this.experience = experience;
            this.work_status = work_status;

        }
        public applicants(SqlDataReader s)
        {
            this.name = s["Name"].ToString();
            this.PhoneNum = s["Phone_num"].ToString();
            this.dob = (DateTime)s["DOB"];
            this.email = s["AEmail"].ToString();
            //this.password = s["Password"].ToString();
            this.description = s["Skill_description"].ToString();
            this.skill_description = s["Skill_description"].ToString();
            this.job_description = s["Job_category"].ToString();
            this.experience = (int)s["Experience"];
            this.work_status = s["Work_status"].ToString();

        }



    }

    public class Job
    {
        public int id;
        public string name;
        public string category;
        public string oEmail;
        public int capacity;
        public string requirement;
        public string description;
        public DateTime Deadline;
        public string Explevel;
        public Job(){ }

        public Job(int id, string name, string category, string oEmail, int capacity, string requirement, string description, DateTime deadline,string Explevel)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.oEmail = oEmail;
            this.capacity = capacity;
            this.requirement = requirement;
            this.description = description;
            Deadline = deadline;
            this.Explevel = Explevel;
        }   
    }

    public class organization
    {
        public string name;
        public string PhoneNum;
        public string email;
        public string password;
        public string address;
        public string description;
        public string mediaLink;
        // CV varbinary(max) not null,
        // Photo varbinary

        public organization(string name, string PhoneNum, string email, string password, string address, string description, string medialink )
        {
            
            this.name = name;
            this.PhoneNum = PhoneNum;
            this.address = address; 
            this.email = email;
            this.password = password;
            this.description = description;
            this.mediaLink = medialink;
            
        }


    }

}
