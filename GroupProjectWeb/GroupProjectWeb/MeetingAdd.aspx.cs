using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uno.GroupProjectSupportTool.DAL;
using Uno.GroupProjectSupportTool.BAL;
using Telerik.Web.UI;

public partial class MeetingAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            GroupProjectDataContext ctx = new GroupProjectDataContext();
            rcbTeamMember.DataSource = ctx.viewTeamMembers;
            rcbTeamMember.DataTextField = "Name";
            rcbTeamMember.DataValueField = "TeamMemberID";
            rcbTeamMember.DataBind();



            rddlSlot.DataSource = ctx.viewSlots;
            rddlSlot.DataTextField = "SlotName";
            rddlSlot.DataValueField = "SlotID";
            rddlSlot.DataBind();



        }
    }

    protected void rbtnSchedule_Click(object sender, EventArgs e)
    {
        rlblMessage.Text = "";

        if (string.IsNullOrEmpty(rddlSlot.SelectedValue))
        {
            rlblMessage.Text = "Please select a time slot";
            return;
        }

        if (string.IsNullOrEmpty(rtbMeetingName.Text) )
        {
            rlblMessage.Text = "Please provide a meeting name";
            return;
        }

        try
        {
            int slotid = Convert.ToInt32(rddlSlot.SelectedValue);

            GroupProjectDataContext ctx = new GroupProjectDataContext();
            ctx.AddMeeting(rtbMeetingName.Text, slotid);


            foreach (RadComboBoxItem item in rcbTeamMember.Items)
            {
                if (item.Checked == true)
                {

                    ctx.AddSlotToTeamMember(Convert.ToInt32(item.Value), slotid);

                }
            }

            rlblMessage.Text = "Meeting was scheduled successfully";
        }
        catch (Exception)
        {
            rlblMessage.Text = "Meeting could not be scheduled";
            throw;
        }




    }
}