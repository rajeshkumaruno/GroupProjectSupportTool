using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.GroupProjectSupportTool.DAL;

namespace Uno.GroupProjectSupportTool.BAL
{
    public class ProjectBAL
    {

        public bool Insert(ProjectInsertInput insertProjectInput)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();
                if (string.IsNullOrEmpty(insertProjectInput.ProjectName))
                {
                    throw new ArgumentOutOfRangeException("Project name not provided");
                }


                if (!insertProjectInput.projectStartDate.HasValue)
                    throw new ArgumentOutOfRangeException("Project start date not provided");

                if (!insertProjectInput.projectStartDate.HasValue)
                    throw new ArgumentOutOfRangeException("Project end date not provided");



                // Create a new project  
                Project objProject = new Project();
                objProject.ProjectName = insertProjectInput.ProjectName;
                objProject.ProjectStartDate = insertProjectInput.projectStartDate;
                objProject.ProjectEndDate = insertProjectInput.projectEndDate;
                objProject.ManagerID = insertProjectInput.ManagerID;
                objProject.IsRetired = false;
                //Add the created project object to the context.  
                context.Projects.InsertOnSubmit(objProject);
                context.SubmitChanges();
                return objProject.ProjectID >= 0; ;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(ProjectUpdInput updProjectInput)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();


                Project result = (from p in context.Projects
                                 where p.ProjectID == updProjectInput.ProjectID
                                  select p).SingleOrDefault();



                // Create a new project  


                updProjectInput.ProjectID = updProjectInput.ProjectID;

                if (string.IsNullOrEmpty(updProjectInput.ProjectName))
                    result.ProjectName = updProjectInput.ProjectName;

                if(updProjectInput.projectStartDate.HasValue)
                    result.ProjectStartDate = updProjectInput.projectStartDate;

                if (updProjectInput.projectEndDate.HasValue)
                    result.ProjectEndDate = updProjectInput.projectEndDate;


                if (updProjectInput.ManagerID.HasValue )
                    result.ManagerID = updProjectInput.ManagerID;

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


                Project result = (from p in context.Projects
                                  where p.ProjectID == Id
                                  select p).SingleOrDefault();

                result.IsRetired = true;

                context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<GetAllProjectsResult> GetAllProject()
        {
            try
            {

                List<GetAllProjectsResult> listProject = new List<GetAllProjectsResult>();

                GroupProjectDataContext context = new GroupProjectDataContext();

                 listProject =
                    (from prj in context.GetAllProjects()
                    select prj).ToList<GetAllProjectsResult>();

                // Create a table from the query.
                return listProject;


            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public List<GetAllProjectTeamAssignmentResult> GetAllProjectTeamAssignment()
        {
            try
            {

                List<GetAllProjectTeamAssignmentResult> listProjectTeamAssignment = new List<GetAllProjectTeamAssignmentResult>();

                GroupProjectDataContext context = new GroupProjectDataContext();

                listProjectTeamAssignment =
                   (from prj in context.GetAllProjectTeamAssignment()
                    select prj).ToList<GetAllProjectTeamAssignmentResult>();

                // Create a table from the query.
                return listProjectTeamAssignment;


            }
            catch (Exception ex)
            {
                return null;
            }
        }




        public Project GetProjectByID(int Id)
        {
            try
            {
                GroupProjectDataContext context = new GroupProjectDataContext();

                Project result =
                   (from prj in context.Projects
                    where prj.IsRetired == false
                    select prj).FirstOrDefault<Project>();

                // Create a table from the query.
                return result;


            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public double calculateDiscount(double SalesAmnt)
        {
            double DiscountPrice = 0.0;
            if (SalesAmnt == 0 || SalesAmnt < 0)
            {
                throw new ArgumentException(" Sales Amount should not be 'Zero/Negative'");
            }
            else if (SalesAmnt >= 1000 && SalesAmnt < 2000)
            {
                // 5% Discount  
                DiscountPrice = SalesAmnt - (SalesAmnt * 0.05);
            }
            else if (SalesAmnt >= 2000 && SalesAmnt < 5000)
            {
                // 10% Discount  
                DiscountPrice = SalesAmnt - (SalesAmnt * 0.1);
            }
            else if (SalesAmnt >= 5000 && SalesAmnt < 20000)
            {
                // 50% Discount  
                DiscountPrice = SalesAmnt - (SalesAmnt * 0.5);
            }
            else
            {
                // No Discount  
                DiscountPrice = SalesAmnt - 0.0;
            }
            return DiscountPrice;
        }






    }
}
