using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ITJobs.DataClass;
using System.Web.Security;


namespace ITJobs.DataClass
{
    public static class ConnectionClass
    {
        private static SqlConnection conn;
        public static SqlCommand cmd;

        static ConnectionClass()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand("", conn);
        }

        #region Candidate Login
        /// <summary>
        /// // Candidate Login details
        /// </summary>
        public static bool AuthenticateCandidate(string email, string password)
        {
            SqlCommand cmd = new SqlCommand("spAuthenticateCandidate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string encriptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

            SqlParameter emailParam = new SqlParameter("@Email", email);
            SqlParameter passParam = new SqlParameter("@Password", encriptPassword);

            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(passParam);
            try
            {
                conn.Open();
                int ReturnCandidateNo = (int)cmd.ExecuteScalar();

                return ReturnCandidateNo == 1;
            }
            finally
            {
                conn.Close();
            }
        }
       #endregion
        #region Candidate Registeration
        /// <summary>
        /// // save a record of a jobseeker to Jobseekers table
        /// </summary>
        public static string insertCandidate(Candidate candidate)
        {
            using (SqlCommand cmd = new SqlCommand("spRegisterCandidate", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                string encryptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(candidate.Password, "SHA1");
                string encryptPassword2 = FormsAuthentication.HashPasswordForStoringInConfigFile(candidate.Password2, "SHA1");

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@FirstName", candidate.FirstName),
                    new SqlParameter("@LastName", candidate.LastName),
                    new SqlParameter("@Email", candidate.Email),
                    new SqlParameter("@Password", encryptPassword),
                    new SqlParameter("@Password2", encryptPassword2),
                    new SqlParameter("@Address", candidate.Address),
                    new SqlParameter("@City", candidate.City),
                    new SqlParameter("@Postcode", candidate.Postcode),
                    new SqlParameter("@Country", candidate.Country),
                    new SqlParameter("@Telephone", candidate.Telephone),
                    new SqlParameter("@EmploymentStatus", candidate.EmploymentStatus),
                    new SqlParameter("@RecentJobTitle", candidate.RecentJobTitle),
                    new SqlParameter("@HighestQualification", candidate.HighestQualification),
                    new SqlParameter("@TargetJob", candidate.TargetJob),
                    new SqlParameter("@PreferedLocation", candidate.PreferedLocation),
                    new SqlParameter("@JobType", candidate.JobType),
                    new SqlParameter("@MinimumSalary", candidate.MinimumSalary)
                };
                cmd.Parameters.AddRange(parameters);
                try
                {
                    conn.Open();
                    int ReturnEmployerNo = (int)cmd.ExecuteScalar();
                    if (ReturnEmployerNo == -1)
                    {
                        return "An email already in use, please choose another email!";
                    }
                    else
                    {
                        return "success";
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        
        
        #endregion
        #region Candidate Update
        /// <summary>
        /// // update a record of a Candidate
        /// </summary>
        #endregion
        #region Employer Login
        /// <summary>
        /// // Employer Login details
        /// </summary>
        public static bool AuthenticateEmployer(string email, string password)
        {
            SqlCommand cmd = new SqlCommand("spAuthenticateEmployer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string encriptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

            SqlParameter emailParam = new SqlParameter("@Email", email);
            SqlParameter passParam = new SqlParameter("@Password", encriptPassword);

            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(passParam);
            try
            {
                conn.Open();
                int ReturnEmployerNo = (int)cmd.ExecuteScalar();

                return ReturnEmployerNo == 1;
            }
            finally
            {
                conn.Close();
            }
        }
       
        #endregion
        #region Employer Registration
        /// <summary>
        /// // inserte a record of an employer to the employer table
        /// </summary>
        public static string insertEmployer(Employer employer)
        {
            using (SqlCommand cmd = new SqlCommand("spRegisterEmployer", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                string encryptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(employer.Password, "SHA1");
                string encryptPassword2 = FormsAuthentication.HashPasswordForStoringInConfigFile(employer.Password2, "SHA1");

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@FirstName", employer.FirstName),
                    new SqlParameter("@LastName", employer.LastName),
                    new SqlParameter("@Email", employer.Email),
                    new SqlParameter("@Password", encryptPassword),
                    new SqlParameter("@Password2", encryptPassword2),
                    new SqlParameter("@Organisation", employer.Organisation),
                    new SqlParameter("@Address", employer.Address),
                    new SqlParameter("@City", employer.City),
                    new SqlParameter("@Postcode", employer.Postcode),
                    new SqlParameter("@Country", employer.Country),
                    new SqlParameter("@Telephone", employer.Telephone)
                };
                 cmd.Parameters.AddRange(parameters);
                 try
                 {
                     conn.Open();
                     int ReturnEmployerNo = (int)cmd.ExecuteScalar();
                     if (ReturnEmployerNo == -1)
                     {
                         return "An email already in use, please choose another email!";
                     }
                     else
                     {
                         return "success";
                     }
                 }
                 finally
                 {
                     conn.Close();
                 }
            }
        }
        
        #endregion
        #region Employer Update
        /// <summary>
        /// // Update a record of an employer
        /// </summary>
        #endregion
        #region InsertJob
        ///<summary>
        ///insert a recod of a job into Job table
        ///</summary>
        public static string InsertJob(Job job)
        {
            using (SqlCommand cmd = new SqlCommand("spInsertJob", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@JobTitle", job.JobTitle),
                    new SqlParameter("@Organisation", job.Organisation),
                    new SqlParameter("@Category", job.Category),
                    new SqlParameter("@JobType", job.JobType),
                    new SqlParameter("@PostingDate", job.PostingDate),
                    new SqlParameter("@ClosingDate", job.ClosingDate),
                    new SqlParameter("@Location", job.Location),
                    new SqlParameter("@Salary", job.Salary),
                    new SqlParameter("@JobDescription", job.JobDescription),
                    new SqlParameter("@YourReference", job.YourReference),
                    new SqlParameter("@OnlineApplicationEmail", job.OnlineApplicationEmail),
                    new SqlParameter("@EmployerID", job.EmployerId)
                };
                cmd.Parameters.AddRange(parameter);
                conn.Open();
                cmd.ExecuteNonQuery();
                return "success";
            }
        }
        #endregion
        #region Jobs posted by employer
       
         ///<summary>
        ///displays all jobs advertaised by an employer
        ///</summary>
        public static List<Job> selectJobsByEmployersID(int employerID)
        {
            List<Job> liveJobs = new List<Job>();
            using (SqlCommand cmd = new SqlCommand("spLiveJobsByEmployer", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@EmployerID", employerID);
                cmd.Parameters.Add(parameter);
                try
                {
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                
                    while (rdr.Read())
                    {
                        Job job = new Job();
                        job.JobId = Convert.ToInt32(rdr["JobID"]);
                        job.JobTitle = rdr["JobTitle"].ToString();
                        job.Organisation = rdr["Organisation"].ToString();
                        job.Category = rdr["Category"].ToString();
                        job.JobType = rdr["JobType"].ToString();
                        job.PostingDate = Convert.ToDateTime(rdr["PostingDate"].ToString());
                        job.ClosingDate = Convert.ToDateTime(rdr["ClosingDate"].ToString());
                        job.Location = rdr["Location"].ToString();
                        job.Salary = rdr["Salary"].ToString();
                        job.YourReference = rdr["YourReference"].ToString();
                        job.OnlineApplicationEmail = rdr["OnlineApplicationEmail"].ToString();
                        job.EmployerId = Convert.ToInt32(rdr["EmployerId"]);
                           
                        liveJobs.Add(job);

                    }

                    return liveJobs;
                }
                    finally
                {
                    conn.Close();
                }

            }
        }
        #endregion
        #region job Applications
        ///<summary>
        ///insert an instance of Application class
        ///</summary>
        public static string insertApplication(Applications application)
        {
            using (SqlCommand cmd = new SqlCommand("spInsertApplication", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@JobID", application.JobId),
                    new SqlParameter("@CandidateID", application.CandidateId),
                    new SqlParameter("@FirstName", application.FirstName),
                    new SqlParameter("@LastName", application.LastName),
                    new SqlParameter("@Email", application.Email),
                    new SqlParameter("@ApplicationDate", application.ApplicationDate),
                    new SqlParameter("@CoverLetter", application.CoverLetter),
                    new SqlParameter("@CVFileName", application.CvFileName),
                    new SqlParameter("@Status", application.Status)
                };
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                cmd.ExecuteNonQuery();
                return "success";
            }  
        }
        #endregion
    }
}