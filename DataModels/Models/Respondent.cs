using System;
using System.Collections.Generic;

#nullable disable

namespace DataModels.Models
{
    public partial class Respondent
    {
        public Respondent()
        {
            RespondentResults = new HashSet<RespondentResult>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }

        public virtual ICollection<RespondentResult> RespondentResults { get; set; }
    }
}
