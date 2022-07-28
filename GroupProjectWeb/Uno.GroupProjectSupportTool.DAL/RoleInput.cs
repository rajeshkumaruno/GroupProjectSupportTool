using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.GroupProjectSupportTool.DAL
{
    public class RoleInsertInput
    {
        public string RoleName { get; set; }
    }

    public class RoleUpdateInput
    {
        public string RoleName { get; set; }
        public int RoleID { get; set; }
    }

    public class RoleView
    {
        public string RoleName { get; set; }
        public int RoleID { get; set; }
    }

}
