using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BHISApi.Custom.Models.History
{
    public class PatientCase
    {
        public int Id { get; set; }
        public bool Closed { get; set; }
        public DateTime InsertionDate { get; set; }
        public string InsertionDateFormated
        {
            get
            {
                return InsertionDate.ToString("dd.MM.yyyy HH:mm");
            }
        }
        public string InsuranceNumber { get; set; }
        public string FirstLast { get; set; }
        public DateTime Birthdate { get; set; }
        public string PersonalNumber { get; set; }
        public int IdPatient { get; set; }
        //public string Phone { get; set; }
        public bool IsCaseManaged { get; set; }
        public bool CompletedVisits { get; set; }

    }
}
