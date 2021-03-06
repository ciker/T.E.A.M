﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

using TEAM.Entity.Base;

namespace TEAM.Entity
{
    [Table("WorkItems")]
    public class WorkItem : EntityBase
    {
        public string TaskId { get; set; }
        public int ServerId { get; set; }
        public int WeekId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public string Sprint { get; set; }
        public string Project { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ETA { get; set; }
        public int EstimatedHours { get; set; }
        public int WeekHours { get; set; }
        public int TotalHours { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}