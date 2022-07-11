using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uno.GroupProjectSupportTool.DAL;

public partial class ProjectAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            GroupProjectDataContext ctx = new GroupProjectDataContext();
            rddlManager.DataSource = ctx.viewTeamManagers;
            rddlManager.DataTextField = "Name";
            rddlManager.DataValueField = "TeamMemberID";
            rddlManager.DataBind();
            rddlManager.Items.Insert(0, new Telerik.Web.UI.DropDownListItem("--Select Project manager--", ""));
        }

    }

    protected void RadButton1_Click(object sender, EventArgs e)
    {
        string projectname = rtbProjectName.Text;
        DateTime projectStartDate = rcStartDate.SelectedDate;
        DateTime projectEndDate = rcEndDate.SelectedDate.Date;
        int memberID = Convert.ToInt32(rddlManager.SelectedValue);

        //Here Model1 is the class
        GroupProjectDataContext context = new GroupProjectDataContext();

        // Create a new project  
        Project objProject = new Project();
        objProject.ProjectName = projectname;
        objProject.ProjectStartDate = projectStartDate;
        objProject.ProjectEndDate = projectEndDate;
        objProject.ManagerID = memberID;


        //Add the created project object to the context.  
        context.Projects.InsertOnSubmit(objProject);
        context.SubmitChanges();


        rlblMessage.Text = "The project was added";


    }



    public class ItemProjectMember
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public ItemProjectMember(int id, string description)
        {
            this.Id = id;
            this.Description = description;
        }
    }



    protected void RadButtonHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void RadButtonView_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewProject.aspx");
    }
}