using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.GroupProjectSupportTool.DAL
{
    public class TeamMemberInsertInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string SSN { get; set; }
        public int? RoleID { get; set; }


    }

    public class TeamMemberUpdateInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string SSN { get; set; }
        public int? RoleID { get; set; }
        public int TeamMemberID { get; set; }

    }


    public class TeamMemberView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string SSN { get; set; }
        public int? RoleID { get; set; }
        public string RoleName { get; set; }
        public int TeamMemberID { get; set; }

    }

}
