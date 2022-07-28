using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.GroupProjectSupportTool.DAL;

namespace Uno.GroupProjectSupportTool.BAL
{
    class RoleBAL
    {



        public bool Insert(RoleInsertInput insertRoleInput)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();

                // Create a new project  
                Role objInsert = new Role();
                if (string.IsNullOrEmpty(insertRoleInput.RoleName))
                    objInsert.RoleName = insertRoleInput.RoleName;

                //Add the created project object to the context.  
                context.Roles.InsertOnSubmit(objInsert);
                context.SubmitChanges();
                return objInsert.RoleID >= 0; ;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(RoleUpdateInput updRoleInput)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();


                Role result = (from p in context.Roles
                               where p.RoleID == updRoleInput.RoleID
                               select p).SingleOrDefault();



                // Create a new Task  



                if (string.IsNullOrEmpty(updRoleInput.RoleName))
                    result.RoleName = updRoleInput.RoleName;

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


                Role result = (from p in context.Roles
                               where p.RoleID == Id
                               select p).SingleOrDefault();
                context.Roles.DeleteOnSubmit(result);

                context.SubmitChanges();


                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<GetAllRolesResult> GetAllActiveTasks()
        {
            try
            {

                List<GetAllRolesResult> listRoles= new List<GetAllRolesResult>();

                GroupProjectDataContext context = new GroupProjectDataContext();

                listRoles =
                   (from rl in context.GetAllRoles()
                    select rl).ToList<GetAllRolesResult>();

                // Create a table from the query.
                return listRoles;


            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public Role GetRoleByID(int Id)
        {
            try
            {
                GroupProjectDataContext context = new GroupProjectDataContext();

                Role result =
                   (from obj in context.Roles
                    select obj).FirstOrDefault<Role>();

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
