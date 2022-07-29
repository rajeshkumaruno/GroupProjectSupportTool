using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uno.GroupProjectSupportTool.DAL;
using Uno.GroupProjectSupportTool.BAL;

public partial class TaskByMemberProject : System.Web.UI.Page
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
        try
        {

            if (!string.IsNullOrEmpty(rddlProject.SelectedValue))
            {
                string projectid = rddlProject.SelectedValue;
                GroupProjectDataContext ctx = new GroupProjectDataContext();
                List<GetTaskByProjectResult> listResults = ctx.GetTaskByProject(Convert.ToInt32(projectid)).ToList<GetTaskByProjectResult>();
                RadGrid1.DataSource = listResults;
                RadGrid1.DataBind();
            }
        }
        catch (Exception ex)
        {

            throw;
        }



    }

    protected void rddTeamMember_SelectedIndexChanged(object sender, Telerik.Web.UI.DropDownListEventArgs e)
    {
        try
        {

            if (!string.IsNullOrEmpty(rddTeamMember.SelectedValue))
            {
                string projectid = rddTeamMember.SelectedValue;
                GroupProjectDataContext ctx = new GroupProjectDataContext();
                List<GetTaskByMemberResult> listResults = ctx.GetTaskByMember(Convert.ToInt32(projectid)).ToList<GetTaskByMemberResult>();
                RadGrid1.DataSource = listResults;
                RadGrid1.DataBind();
            }
        }
        catch (Exception ex)
        {

            throw;
        }


    }
}