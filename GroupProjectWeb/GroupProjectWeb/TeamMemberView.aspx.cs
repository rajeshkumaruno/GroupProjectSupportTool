using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uno.GroupProjectSupportTool.DAL;
using Uno.GroupProjectSupportTool.BAL;



public partial class TeamMemberView : System.Web.UI.Page
{
    private GroupProjectDataContext _dataContext;
    protected GroupProjectDataContext DbContext
    {
        get
        {
            if (_dataContext == null)
            {
                _dataContext = new GroupProjectDataContext();
            }
            return _dataContext;
        }
    }

    public override void Dispose()
    {
        if (_dataContext != null)
        {
            _dataContext.Dispose();
        }
        base.Dispose();
    }




    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            GroupProjectDataContext ctx = new GroupProjectDataContext();

        }

    }

    protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {

        TeamMemberBAL objTeamMemberBAL = new TeamMemberBAL();
        List<GetAllTeamMemberResult> listTeamMember = objTeamMemberBAL.GetAllTeamMembers();
        RadGrid1.DataSource = listTeamMember; // DbContext.Projects;
    }


    protected void RadGrid1_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {

        var editableItem = ((Telerik.Web.UI.GridEditableItem)e.Item);
        var teammemberID = (int)editableItem.GetDataKeyValue("TeamMemberID");
        //retrive entity form the Db         
        var mytask = DbContext.TeamMembers.Where(n => n.TeamMemberID == teammemberID).FirstOrDefault();
        if (mytask != null)
        {
            //update entity's state             
            editableItem.UpdateValues(mytask);
            try
            {
                //submit chanages to Db     

                DbContext.SubmitChanges();
            }
            catch (System.Exception)
            {
                ShowErrorMessage();
            }
        }



    }


    private void ShowErrorMessage()
    {
        RadAjaxManager1.ResponseScripts.Add(string.Format("window.radalert(\"Please enter valid data!\")"));
    }



    protected void RadGrid1_DeleteCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {

    }
}