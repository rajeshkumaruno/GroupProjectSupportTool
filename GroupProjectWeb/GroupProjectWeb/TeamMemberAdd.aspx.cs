using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uno.GroupProjectSupportTool.DAL;
using Uno.GroupProjectSupportTool.BAL;

public partial class TeamMemberAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            GroupProjectDataContext ctx = new GroupProjectDataContext();
            rddlRole.DataSource = ctx.viewRoles;
            rddlRole.DataTextField = "RoleName";
            rddlRole.DataValueField = "RoleID";
            rddlRole.DataBind();
            rddlRole.Items.Insert(0, new Telerik.Web.UI.DropDownListItem("--Select a Role --", ""));
        }
    }

    protected void rbtnAddtask_Click(object sender, EventArgs e)
    {

        TeamMemberInsertInput taskInput = new TeamMemberInsertInput();

        if (!string.IsNullOrEmpty(rtbFirstName.Text))
            taskInput.FirstName = rtbFirstName.Text;

        if (!string.IsNullOrEmpty(rtbLastName.Text))
            taskInput.LastName = rtbLastName.Text;

        if (!string.IsNullOrEmpty(rtbInitial.Text))
            taskInput.Initials = rtbInitial.Text;

        if (!string.IsNullOrEmpty(rtbSSN.Text))
            taskInput.SSN = rtbSSN.Text;


        if (!string.IsNullOrEmpty(rddlRole.SelectedText))
            taskInput.RoleID = Convert.ToInt32(rddlRole.SelectedValue);

        
        TeamMemberBAL objBAL = new TeamMemberBAL();
        bool result = objBAL.Insert(taskInput);

        if (result)
        {
            rlblMessage.Text = "The TeamMember was added successfully";
            Response.Redirect("TeamMemberView.aspx");
        }
        else
            rlblMessage.Text = "There was a problem in adding team member";



    }
}