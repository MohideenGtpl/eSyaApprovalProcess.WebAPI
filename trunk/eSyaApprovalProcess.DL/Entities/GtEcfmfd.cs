﻿using System;
using System.Collections.Generic;

namespace HCP.ApprovalProcess.DL.Entities
{
    public partial class GtEcfmfd
    {
        public int FormId { get; set; }
        public string FormCode { get; set; }
        public string FormName { get; set; }
        public string ControllerName { get; set; }
        public string ToolTip { get; set; }
        public bool IsStoreLink { get; set; }
        public bool IsDocumentNumberRequired { get; set; }
        public bool IsMaterial { get; set; }
        public bool IsPharmacy { get; set; }
        public bool IsStationary { get; set; }
        public bool IsCafeteria { get; set; }
        public bool IsFandB { get; set; }
        public bool IsDoctor { get; set; }
        public bool ActiveStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }
}
