using System;


namespace ITJobs.DataClass
{
    public class Candidate
    {
        #region Fields

        private int _candidateId;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private string _password2;
        private string _address;
        private string _city;
        private string _postcode;
        private string _country;
        private string _telephone;
        private string _employmentStatus;
        private string _recentJobTitle;
        private string _highestQualification;
        private string _targetJob;
        private string _preferedLocation;
        private string _jobType;
        private string _minimumSalary;

        #endregion
    
    #region Constructor

        /// <summary>
        /// Initializes a new instants of the candidate class
        /// </summary>
        public Candidate()
        {
            
        }

        /// <summary>
        /// Initializes a new instants of the candidate class
        /// </summary>
        public Candidate(int candidateId, string firstName, string lastName, string email, string password, string password2, string address, string city,
            string postcode, string country, string telephone, string employmentStatus, string recentJobTitle,
            string highestQualification, string targetJob, string preferedLocation, string jobType, string minimumSalary)
        {
            this._candidateId = candidateId;
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
            this._password = password;
            this._password2 = password2;
            this._address = address;
            this._city = city;
            this._postcode = postcode;
            this._country = country;
            this._telephone = telephone;
            this._employmentStatus = employmentStatus;
            this._recentJobTitle = recentJobTitle;
            this._highestQualification = highestQualification;
            this._targetJob = targetJob;
            this._preferedLocation = preferedLocation;
            this._jobType = jobType;
            this._minimumSalary = minimumSalary;

        }

        /// <summary>
        /// Initializes a new instants of the candidate class
        /// </summary>
        public Candidate(string firstName, string lastName, string email, string password, string password2, string address, string city,
            string postcode, string country, string telephone, string employmentStatus, string recentJobTitle,
            string highestQualification, string targetJob, string preferedLocation, string jobType, string minimumSalary)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
            this._password = password;
            this._password2 = password2;
            this._address = address;
            this._city = city;
            this._postcode = postcode;
            this._country = country;
            this._telephone = telephone;
            this._employmentStatus = employmentStatus;
            this._recentJobTitle = recentJobTitle;
            this._highestQualification = highestQualification;
            this._targetJob = targetJob;
            this._preferedLocation = preferedLocation;
            this._jobType = jobType;
            this._minimumSalary = minimumSalary;

        }
        
    #endregion

        #region Properties
        /// <summary>
        /// Gets and Sets the candidate id.
        /// </summary>
        public int CandidateId 
        {
            get
            {
                return _candidateId;
            }
            set
            {
                _candidateId = value;
            }
        }

        /// <summary>
        /// Gets and sets the firts name of candidate value.
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        /// <summary>
        /// Gets and sets the surname name of candidate.
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        /// <summary>
        /// Gets and sets the email of candidate.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Gets and sets the password of candidate.
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        /// <summary>
        /// Gets and sets the values of the second password.
        /// </summary>
        public string Password2
        {
            get
            {
                return _password2;
            }
            set
            {
                _password2 = value;
            }
        }

        /// <summary>
        /// Gets and sets the address of candidate value.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Gets and sets the value of city.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        /// <summary>
        /// Gets and sets the value of postcode.
        /// </summary>
        public string Postcode
        {
            get
            {
                return _postcode;
            }
            set
            {
                _postcode = value;
            }
        }

        /// <summary>
        /// Gets and sets the firts country of candidate.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                
                _country = value;
            }
        }

        /// <summary>
        /// Gets and sets the telephone of candidate.
        /// </summary>
        public string Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
            }
        }

        /// <summary>
        /// Gets and sets the employment status of candidate.
        /// </summary>
        public string EmploymentStatus
        {
            get
            {
                return _employmentStatus;
            }
            set
            {
                _employmentStatus = value;
            }
        }

        /// <summary>
        /// Gets and sets the recent job title of candidate.
        /// </summary>
        public string RecentJobTitle
        {
            get
            {
                return _recentJobTitle;
            }
            set
            {
                _recentJobTitle = value;
            }
        }

        /// <summary>
        /// Gets and sets the highest qualification of candidate.
        /// </summary>
        public string HighestQualification
        {
            get
            {
                return _highestQualification;
            }
            set
            {
                _highestQualification = value;
            }
        }

        /// <summary>
        /// Gets and sets the target job of candidate.
        /// </summary>
        public string TargetJob
        {
            get
            {
                return _targetJob;
            }
            set
            {
                _targetJob = value;
            }
        }

        /// <summary>
        /// Gets and sets the prefered location of candidate.
        /// </summary>
        public string PreferedLocation
        {
            get
            {
                return _preferedLocation;
            }
            set
            {
                _preferedLocation = value;
            }
        }

        /// <summary>
        /// Gets and sets the job type candidate.
        /// </summary>
        public string JobType
        {
            get
            {
                return _jobType;
            }
            set
            {
                _jobType = value;
            }
        }

        /// <summary>
        /// Gets and sets the minimum salary of candidate.
        /// </summary>
        public string MinimumSalary
        {
            get
            {
                return _minimumSalary;
            }
            set
            {
                _minimumSalary = value;
            }
        }
        #endregion
    }
}