using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.GroupProjectSupportTool.DAL
{
    public class ProjectInsertInput
    {
        public string ProjectName { get; set; }
        public DateTime? projectStartDate { get; set; }
        public DateTime? projectEndDate { get; set; }
        public int? ManagerID { get; set; }

    }

    public class ProjectUpdInput
    {
        public string ProjectName { get; set; }
        public DateTime? projectStartDate { get; set; }
        public DateTime? projectEndDate { get; set; }
        public int? ManagerID { get; set; }
        public int ProjectID { get; set; }

    }


    public class ProjectView
    {
        public string ProjectName { get; set; }
        public DateTime? projectStartDate { get; set; }
        public DateTime? projectEndDate { get; set; }
        public int? ManagerID { get; set; }

    }


}


