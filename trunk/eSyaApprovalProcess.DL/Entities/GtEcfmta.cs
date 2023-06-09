﻿using System;
using System.Collections.Generic;

namespace HCP.ApprovalProcess.DL.Entities
{
    public partial class GtEcfmta
    {
        public int FormId { get; set; }
        public int TaskId { get; set; }
        public bool AutoReassignTimeline { get; set; }
        public bool ActiveStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }
}
