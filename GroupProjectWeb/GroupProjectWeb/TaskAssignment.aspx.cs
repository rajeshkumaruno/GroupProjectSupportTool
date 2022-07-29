using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uno.GroupProjectSupportTool.DAL;
using Uno.GroupProjectSupportTool.BAL;



public partial class TaskAssignment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            GroupProjectDataContext ctx = new GroupProjectDataContext();
            rddlProject.DataSource = ctx.viewProjects;
            rddlProject.DataTextField = "ProjectName";
            rddlProject.DataValueField = "ProjectID";
            rddlProject.DataBind();
            rddlProject.Items.Insert(0, new Telerik.Web.UI.DropDownListItem("--Select a Project --", ""));


            rddTeamMember.DataSource = ctx.viewTeamMembers;
            rddTeamMember.DataTextField = "Name";
            rddTeamMember.DataValueField = "TeamMemberID";
            rddTeamMember.DataBind();
            rddTeamMember.Items.Insert(0, new Telerik.Web.UI.DropDownListItem("--Select Team Member--", ""));


        }

    }

    protected void rddlProject_SelectedIndexChanged(object sender, Telerik.Web.UI.DropDownListEventArgs e)
    {

        string projectid = rddlProject.SelectedValue;
        GroupProjectDataContext ctx = new GroupProjectDataContext();
        List<GetAllTaskForProjectResult> listResults= ctx.GetAllTaskForProject(Convert.ToInt32(projectid)).ToList<GetAllTaskForProjectResult>();

        rddlTask.DataSource = listResults;
        rddlTask.DataTextField = "TaskName";
        rddlTask.DataValueField = "TaskID";
        rddlTask.DataBind();
        rddlTask.Items.Insert(0, new Telerik.Web.UI.DropDownListItem("--Select a Task --", ""));

    }

    protected void rbtnAssignTask_Click(object sender, EventArgs e)
    {
        rlblMessage.Text = "";
        string projectid = rddlProject.SelectedValue;
        string taskid = rddlTask.SelectedValue;
        string memberid = rddTeamMember.SelectedValue;

        GroupProjectDataContext ctx = new GroupProjectDataContext();
        List<CheckIfTaskAssignedResult> listResults = ctx.CheckIfTaskAssigned(Convert.ToInt32(taskid), Convert.ToInt32(memberid) ).ToList<CheckIfTaskAssignedResult>();

        if(listResults.Count>0)
        {
            rlblMessage.Text = "The task is already assigned to the member";
        }
        else
        {
            int result = ctx.AssignTaskToMember(Convert.ToInt32(taskid), Convert.ToInt32(memberid));
            rlblMessage.Text = "The task is now assigned to the member";

        }


    }
}