using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.GroupProjectSupportTool.DAL
{
    public class TaskInsertInput
    {
        public string TaskName { get; set; }
        public string TaskNotes { get; set; }
        public int? Iteration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CompletionPercent { get; set; }
        public string Status { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsMileStone { get; set; }
        public int? ProjectID { get; set; }


    }

    public class TaskUpdateInput
    {
        public string TaskName { get; set; }
        public string TaskNotes { get; set; }
        public int? Iteration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CompletionPercent { get; set; }
        public string Status { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsMileStone { get; set; }
        public int? ProjectID { get; set; }
        public int TaskID { get; set; }

    }


    public class TaskView
    {
        public string TaskName { get; set; }
        public string TaskNotes { get; set; }
        public int? Iteration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CompletionPercent { get; set; }
        public string Status { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsMileStone { get; set; }
        public int? ProjectID { get; set; }

        public string ProjectName { get; set; }
        public int TaskID { get; set; }

    }
}
