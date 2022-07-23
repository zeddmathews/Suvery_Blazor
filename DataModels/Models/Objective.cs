using System;
using System.Collections.Generic;

#nullable disable

namespace DataModels.Models
{
    public partial class Objective
    {
        public int ObjId { get; set; }
        public string Questions { get; set; }
        public int? RespondentsWeight { get; set; }
        public int? RespondentsTotal { get; set; }
        public int? ExpectationGap { get; set; }
        public int? Accuracy { get; set; }
        public int? ManagerSWeight { get; set; }
        public int? ManagerSTotal { get; set; }
    }
}
