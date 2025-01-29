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
            applicants b = new applicants("abebe", "091121", DateTime.Now, "abebe@gmail.com", "abebe11", "abe in the house", "abe likes work", "abe no work", 2, "notworking", null, null);
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
            if ((int)r == 1)
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
                app = new applicants(s["Name"].ToString(), s["Phone_num"].ToString(), (DateTime)s["DOB"], s["AEmail"].ToString(), s["Password"].ToString(), s["Job_category"].ToString(), s["Skill_description"].ToString(), s["Job_category"].ToString(), (int)s["Experience"], s["Work_status"].ToString(), (byte[])s["CV"], (byte[])s["AppCertificate"]);


            }
            return app;

        }


        public static Job fetchJobId(int id)
        {
            SqlDataReader s;
            Job app;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Jobs where Job_id=@1;";
                command.Parameters.AddWithValue("@1", id);

                //      command.CommandText = String.Format(commandText, b.name, b.PhoneNum, b.dob, b.email, b.password, b.description, b.skill_description, b.job_description, b.experience, b.work_status);
                command.Connection = conn;
                s = command.ExecuteReader();
                s.Read();
                app = new Job((int)s["Job_id"], s["Job_name"].ToString(), s["Job_category"].ToString(), s["OEmail"].ToString(), (int)s["capacity"], s["Requirement"].ToString(), s["Job_description"].ToString(), (DateTime)s["Deadline"], (int)s["job_exp_level"], (int)s["payestimate"]);




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
                command.CommandText = "insert into Jobs(Job_description,Requirement,capacity, Deadline, OEmail, Job_name, Job_category,job_exp_level,payestimate) values(@1,@2,@3,@4,@5,@6,@7,@8,@9);";
                command.Parameters.AddWithValue("@1", job.description);
                command.Parameters.AddWithValue("@2", job.requirement);
                command.Parameters.AddWithValue("@3", job.capacity);
                command.Parameters.AddWithValue("@4", job.Deadline);
                command.Parameters.AddWithValue("@5", job.oEmail);
                command.Parameters.AddWithValue("@6", job.name);
                command.Parameters.AddWithValue("@7", job.category);
                command.Parameters.AddWithValue("@8", job.Explevel);
                command.Parameters.AddWithValue("@9", job.Explevel);
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
                command.Parameters.AddWithValue("@4", org.password);
                command.Parameters.AddWithValue("@5", org.description);
                command.Parameters.AddWithValue("@6", org.email);
                command.Parameters.AddWithValue("@7", org.mediaLink);

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
                    arrayList.Add(new Job((int)a["Job_id"], a["Job_name"].ToString(), a["Job_category"].ToString(), a["OEmail"].ToString(), (int)a["capacity"], a["requirement"].ToString(), a["Job_description"].ToString(), (DateTime)a["Deadline"], (int)a["job_exp_level"], (int)a["payestimate"]));
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
                //    command.CommandText = "select * from Jobs;";
                command.CommandText = "select * from Jobs where Job_category=@1;";
                command.Parameters.AddWithValue("@1", category);
                SqlDataReader a = command.ExecuteReader();
                while (a.Read())
                {
                    arrayList.Add(new Job((int)a["Job_id"], a["Job_name"].ToString(), a["Job_category"].ToString(), a["OEmail"].ToString(), (int)a["capacity"], a["requirement"].ToString(), a["Job_description"].ToString(), (DateTime)a["Deadline"], (int)a["job_exp_level"], (int)a["payestimate"]));
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
                    arrayList.Add(new Job((int)a["Job_id"], a["Job_name"].ToString(), a["Job_category"].ToString(), a["OEmail"].ToString(), (int)a["capacity"], a["requirement"].ToString(), a["Job_description"].ToString(), (DateTime)a["Deadline"], (int)a["job_exp_level"], (int)a["payestimate"]));
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
        public static ArrayList applied_list2(int jid)
        {
            ArrayList arrayList = new ArrayList();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select Aemail from ApplicantJob where Job_id=@1 and Message = 'pending';";
                command.Parameters.AddWithValue("@1", jid);
                SqlDataReader a = command.ExecuteReader();
                while (a.Read())
                {
                    arrayList.Add(a["AEmail"].ToString());
                }
            }

            return arrayList;

        }

        public static bool Accepted(int jid, string email)
        {
            int a;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update ApplicantJob set Message='Accepted' where Job_id=@1 and AEmail = @2 ";
                command.Parameters.AddWithValue("@1", jid);
                command.Parameters.AddWithValue("@2", email);
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
        public static bool Rejected(int jid, string email)
        {
            int a;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update ApplicantJob set Message='Rejected' where Job_id=@1 and AEmail = @2";
                command.Parameters.AddWithValue("@1", jid);
                command.Parameters.AddWithValue("@2", email);


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
        public static ArrayList fetchJobName(string id)
        {
            SqlDataReader s;
            Job app;
            ArrayList arrayList = new ArrayList();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Jobs where Job_name=@1 or OEmail=@1 or Job_category=@1;";
                command.Parameters.AddWithValue("@1", id);

                //      command.CommandText = String.Format(commandText, b.name, b.PhoneNum, b.dob, b.email, b.password, b.description, b.skill_description, b.job_description, b.experience, b.work_status);
                command.Connection = conn;
                s = command.ExecuteReader();

                while (s.Read())
                {

                    app = new Job((int)s["Job_id"], s["Job_name"].ToString(), s["Job_category"].ToString(), s["OEmail"].ToString(), (int)s["capacity"], s["Requirement"].ToString(), s["Job_description"].ToString(), (DateTime)s["Deadline"], (int)s["job_exp_level"], (int)s["payestimate"]);
                    arrayList.Add(app);
                }





            }
            return arrayList;


        }
        public static string acceptance(int jobid, string email)
        {
            SqlDataReader s;
            string stat = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select Message from ApplicantJob where AEmail=@1 and Job_id=@2;";
                command.Parameters.AddWithValue("@1", email);
                command.Parameters.AddWithValue("@2", jobid);

                //      command.CommandText = String.Format(commandText, b.name, b.PhoneNum, b.dob, b.email, b.password, b.description, b.skill_description, b.job_description, b.experience, b.work_status);
                command.Connection = conn;
                s = command.ExecuteReader();
                while (s.Read())
                {
                    stat = s["Message"].ToString();
                }

            }
            return stat;
        }
        public static bool apply(int jid, string aemail)
        {
            SqlDataReader s;
            int a = 0;
            int applicants, capacity, min_exp,exp;

            int c;
            
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;

                command.CommandText = "select count(*)  from ApplicantJob  where Job_id=@11 and Aemail=@0;";
                command.Parameters.AddWithValue("@11", jid);
                command.Parameters.AddWithValue("@0", aemail);

                if(command.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("You have already applied to this job.");
                    return false;
                }

                command.CommandType = CommandType.Text;
                command.CommandText = "select count(*)  from ApplicantJob  where Job_id=@1 Jp;";
                command.Parameters.AddWithValue("@1", jid);
               
                applicants =(int) command.ExecuteScalar();

                command.CommandText = "select capacity  from Jobs  where Job_id=@2;";
                command.Parameters.AddWithValue("@2", jid);

                capacity = (int)command.ExecuteScalar();
                /*
                command.CommandText = "select jop_exp_level from ApplicantJob  where Job_id=@3;";
                command.Parameters.AddWithValue("@3", jid);

                min_exp = (int)command.ExecuteScalar();

                command.CommandText = "select Experience  from Applicant  where Aemail=@4;";
                command.Parameters.AddWithValue("@4", aemail);
                */
                exp = (int)command.ExecuteScalar();

                if (applicants >= capacity)
                {
                    MessageBox.Show("Capacity full, Cannot apply to this job.");
                    return false;
                }
                /*
                if(min_exp > exp)
                {
                    MessageBox.Show("You do not have the experience needed to apply to this job.");
                    return false;
                }
                */
                DateTime d = DateTime.Now;
                command.CommandText = "insert into ApplicantJob values (@5, @6, @7, 'pending');";
                command.Parameters.AddWithValue("@5", aemail);
                command.Parameters.AddWithValue("@6", jid);
                command.Parameters.AddWithValue("@7", d);

                c = command.ExecuteNonQuery();

            }
            if (c == 1)
            {
                return true;
            }
            return false;
        }

        public static ArrayList Applied_History(string aemail, string stat)
        {
            SqlDataReader s;
            ArrayList arr = new ArrayList();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                if (stat == "all")
                {
                    command.CommandText = "select *  from ApplicantJob  where Aemail=@1;";
                    command.Parameters.AddWithValue("@1", aemail);
                }
                else
                {
                    command.CommandText = "select *  from ApplicantJob  where Aemail=@1 and Message=@2;";

                    command.Parameters.AddWithValue("@1", aemail);
                    command.Parameters.AddWithValue("@2", stat);
                }

                s = command.ExecuteReader();
                while(s.Read())
                {
                    arr.Add((int)s["Job_id"]);
                }

            }
           
            return arr;
        }


    }
    public class applicants
    {
        public string name;
        public string PhoneNum;
        public DateTime dob;
        public string email;
        public string password;
        public string category;
        public string skill_description;
        public string job_description;
        public int experience;
        public string work_status;
        public byte[] cv;
        public byte[] certificateFile;
        // CV varbinary(max) not null,
        // Photo varbinary

        public applicants( string name, string PhoneNum, DateTime dob, string email, string password, string category, string skill_description, string job_description, int experience, string work_status, byte[] cv, byte[] certificateFile)
        {
            this.name = name; 
            this.PhoneNum = PhoneNum;
            this.dob = dob;
            this.email = email;
            this.password = password;
            this.category = category;
            this.skill_description = skill_description;
            this.job_description = job_description;
            this.experience = experience;
            this.work_status = work_status;
            this.cv = cv;
            this.certificateFile = certificateFile;

        }
        public applicants(SqlDataReader s)
        {
            this.name = s["Name"].ToString();
            this.PhoneNum = s["Phone_num"].ToString();
            this.dob = (DateTime)s["DOB"];
            this.email = s["AEmail"].ToString();
            //this.password = s["Password"].ToString();
            this.category = s["category"].ToString();
            this.skill_description = s["Skill_description"].ToString();
            this.job_description = s["Job_category"].ToString();
            this.experience = (int)s["Experience"];
            this.work_status = s["Work_status"].ToString();
            this.cv = (byte[])s["CV"];

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
        public int Explevel;
        public int payestimate;
        public Job(){ }

        public Job(int id, string name, string category, string oEmail, int capacity, string requirement, string description, DateTime deadline,int Explevel,int payestimate)
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
            this.payestimate = payestimate;
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
