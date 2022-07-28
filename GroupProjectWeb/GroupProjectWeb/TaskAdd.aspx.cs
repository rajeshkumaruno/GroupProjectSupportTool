using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uno.GroupProjectSupportTool.DAL;
using Uno.GroupProjectSupportTool.BAL;

public partial class TaskAdd : System.Web.UI.Page
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
        }
    }

    protected void rbtnAddtask_Click(object sender, EventArgs e)
    {
        /*
                public string TaskName { get; set; }
    public string TaskNotes { get; set; }
    public int? Iteration { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? CompletionPercent { get; set; }
    public string Status { get; set; }
    public bool IsRemoved { get; set; }
    public bool IsMileStone { get; set; }
    public int? ProjectID { get; set; }  */

        TaskInsertInput taskInput = new TaskInsertInput();

        if (!string.IsNullOrEmpty(rtbTaskName.Text))
            taskInput.TaskName = rtbTaskName.Text;

        if (!string.IsNullOrEmpty(rtbTaskNotes.Text))
            taskInput.TaskNotes = rtbTaskNotes.Text;

        if (!string.IsNullOrEmpty(rtbIteration.Text))
            taskInput.Iteration = Convert.ToInt32(rtbIteration.Text);

        DateTime projectStartDate = rcStartDate.SelectedDate.Date;
        DateTime projectEndDate = rcEndDate.SelectedDate.Date;

        if (rcStartDate.SelectedDate != null)
            taskInput.StartDate = rcStartDate.SelectedDate.Date;

        if (rcEndDate.SelectedDate != null)
            taskInput.EndDate = rcEndDate.SelectedDate.Date;

        if (!string.IsNullOrEmpty(rtbCompletitionPercent.Text))
            taskInput.CompletionPercent = Convert.ToInt32(rtbCompletitionPercent.Text);

        if (!string.IsNullOrEmpty(rddlistStatus.SelectedText))
            taskInput.Status = rddlistStatus.SelectedValue;

        bool? isChecked = rcbRemoved.Checked;
        bool newRemovedBool = isChecked ?? false;

        if (newRemovedBool)
            taskInput.IsRemoved = true;

        bool? isMilestone = rcbIsMileStone.Checked;
        bool newMilestoneBool = isChecked ?? false;

        if (newRemovedBool)
            taskInput.IsRemoved = true;

        if (newMilestoneBool)
            taskInput.IsMileStone = true;

        if (!string.IsNullOrEmpty(rddlProject.SelectedText))
            taskInput.ProjectID = Convert.ToInt32(rddlProject.SelectedValue);



            TaskBAL objBAL = new TaskBAL();
            bool result = objBAL.Insert(taskInput);

            if(result)
                rlblMessage.Text = "The Task was added successfully";
            else
                rlblMessage.Text = "There was a problem in adding task";



    }
}