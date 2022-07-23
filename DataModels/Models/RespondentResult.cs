using System;
using System.Collections.Generic;

#nullable disable

namespace DataModels.Models
{
    public partial class RespondentResult
    {
        public int ResultId { get; set; }
        public int UserId { get; set; }
        public int InternalMeetings { get; set; }
        public int ClientMeetings { get; set; }
        public int EmailsPhoneSkypeCalls { get; set; }
        public int Research { get; set; }
        public int DbDesign { get; set; }
        public int ArchitectureDesignAndPlanning { get; set; }
        public int BackEndDevelopment { get; set; }
        public int FrontEndDevelopment { get; set; }
        public int Integration { get; set; }
        public int Testing { get; set; }

        public virtual Respondent User { get; set; }
    }
}
