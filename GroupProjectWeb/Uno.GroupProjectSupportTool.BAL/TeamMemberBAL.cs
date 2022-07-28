using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.GroupProjectSupportTool.DAL;


namespace Uno.GroupProjectSupportTool.BAL
{
    public class TeamMemberBAL
    {


        public bool Insert(TeamMemberInsertInput insertTeamMemberInput)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();


                if (string.IsNullOrEmpty(insertTeamMemberInput.FirstName))
                {
                    throw new ArgumentOutOfRangeException("FirstName not provided");
                }

                if (string.IsNullOrEmpty(insertTeamMemberInput.LastName))
                {
                    throw new ArgumentOutOfRangeException("LastName not provided");
                }

                if (string.IsNullOrEmpty(insertTeamMemberInput.Initials))
                {
                    throw new ArgumentOutOfRangeException("Initials not provided");
                }

                if (string.IsNullOrEmpty(insertTeamMemberInput.SSN))
                {
                    throw new ArgumentOutOfRangeException("SSN not provided");
                }






                if (!insertTeamMemberInput.RoleID.HasValue)
                    throw new ArgumentOutOfRangeException("Role ID not provided");




                // Create a new project  
                TeamMember objInsert = new TeamMember();
                objInsert.FirstName = insertTeamMemberInput.FirstName;
                objInsert.LastName = insertTeamMemberInput.LastName;
                objInsert.Initials = insertTeamMemberInput.Initials;
                objInsert.SSN = insertTeamMemberInput.SSN;
                objInsert.RoleID = insertTeamMemberInput.RoleID;

                //Add the created project object to the context.  
                context.TeamMembers.InsertOnSubmit(objInsert);
                context.SubmitChanges();
                return objInsert.TeamMemberID >= 0; ;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(TeamMemberUpdateInput updTeamMemberInput)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();


                TeamMember result = (from p in context.TeamMembers
                                  where p.TeamMemberID == updTeamMemberInput.TeamMemberID
                                  select p).SingleOrDefault();



                // Create a new project  



                if (string.IsNullOrEmpty(updTeamMemberInput.FirstName))
                    result.FirstName = updTeamMemberInput.FirstName;

                if (string.IsNullOrEmpty(updTeamMemberInput.LastName))
                    result.LastName = updTeamMemberInput.LastName;

                if (string.IsNullOrEmpty(updTeamMemberInput.Initials))
                    result.Initials = updTeamMemberInput.Initials;

                if (string.IsNullOrEmpty(updTeamMemberInput.SSN))
                    result.SSN = updTeamMemberInput.SSN;


                if (updTeamMemberInput.RoleID.HasValue)
                    result.RoleID = updTeamMemberInput.RoleID;

                context.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int Id)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();


                TeamMember result = (from p in context.TeamMembers
                                  where p.TeamMemberID == Id
                                  select p).SingleOrDefault();
                context.TeamMembers.DeleteOnSubmit(result);

                context.SubmitChanges();
                

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<GetAllTeamMemberResult> GetAllTeamMembers()
        {
            try
            {

                List<GetAllTeamMemberResult> listTeamMember = new List<GetAllTeamMemberResult>();

                GroupProjectDataContext context = new GroupProjectDataContext();

                listTeamMember =
                   (from tmem in context.GetAllTeamMember()
                    select tmem).ToList<GetAllTeamMemberResult>();

                // Create a table from the query.
                return listTeamMember;


            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public TeamMember GetTeamMemberByID(int Id)
        {
            try
            {
                GroupProjectDataContext context = new GroupProjectDataContext();

                TeamMember result =
                   (from obj in context.TeamMembers
                    select obj).FirstOrDefault<TeamMember>();

                // Create a table from the query.
                return result;


            }
            catch (Exception ex)
            {
                return null;
            }
        }



    }
}
