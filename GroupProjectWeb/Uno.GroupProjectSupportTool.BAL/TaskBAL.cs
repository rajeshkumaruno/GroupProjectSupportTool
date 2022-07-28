using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.GroupProjectSupportTool.DAL;
using Task = Uno.GroupProjectSupportTool.DAL.Task;

namespace Uno.GroupProjectSupportTool.BAL
{
    public class TaskBAL
    {



        public bool Insert(TaskInsertInput insertTaskInput)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();


                if (string.IsNullOrEmpty(insertTaskInput.TaskName))
                {
                    throw new ArgumentOutOfRangeException("TaskName not provided");
                }



                // Create a new project  
                Task objInsert = new Task();
                if (!string.IsNullOrEmpty(insertTaskInput.TaskName))
                    objInsert.TaskName = insertTaskInput.TaskName;

                if (!string.IsNullOrEmpty(insertTaskInput.TaskNotes))
                    objInsert.TaskNotes = insertTaskInput.TaskNotes;

                if (insertTaskInput.Iteration!=null)
                    objInsert.Iteration = insertTaskInput.Iteration;

                if (insertTaskInput.StartDate != null)
                    objInsert.StartDate = insertTaskInput.StartDate;


                if (insertTaskInput.EndDate != null)
                    objInsert.EndDate = insertTaskInput.EndDate;

                if (insertTaskInput.CompletionPercent != null)
                    objInsert.CompletionPercent = insertTaskInput.CompletionPercent;

                if (!string.IsNullOrEmpty(insertTaskInput.Status))
                    objInsert.Status = insertTaskInput.Status;

                objInsert.IsRemoved = false;

                if (insertTaskInput.ProjectID != null)
                    objInsert.ProjectID = insertTaskInput.ProjectID;


                if (insertTaskInput.IsMileStone)
                    objInsert.IsMileStone = true;

                //Add the created project object to the context.  
                context.Tasks.InsertOnSubmit(objInsert);
                context.SubmitChanges();
                return objInsert.TaskID >= 0; ;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(TaskUpdateInput updTaskInput)
        {
            try
            {
                //Here Model1 is the class
                GroupProjectDataContext context = new GroupProjectDataContext();


                Task result = (from p in context.Tasks
                                     where p.TaskID == updTaskInput.TaskID
                                     select p).SingleOrDefault();



                // Create a new Task  



                if (string.IsNullOrEmpty(updTaskInput.TaskName))
                    result.TaskName = updTaskInput.TaskName;

                if (string.IsNullOrEmpty(updTaskInput.TaskNotes))
                    result.TaskNotes = updTaskInput.TaskNotes;

                if (updTaskInput.Iteration.HasValue)
                    result.Iteration = updTaskInput.Iteration;

                if (updTaskInput.StartDate.HasValue)
                    result.StartDate = updTaskInput.StartDate;

                if (updTaskInput.EndDate.HasValue)
                    result.EndDate = updTaskInput.EndDate;

                if (updTaskInput.CompletionPercent.HasValue)
                    result.CompletionPercent = updTaskInput.CompletionPercent;

                if (string.IsNullOrEmpty(updTaskInput.Status))
                    result.Status = updTaskInput.Status;

                result.IsRemoved= updTaskInput.IsRemoved;

                if (updTaskInput.ProjectID.HasValue)
                    result.ProjectID = updTaskInput.ProjectID;

                result.IsMileStone = updTaskInput.IsMileStone;


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


                Task result = (from p in context.Tasks
                                     where p.TaskID == Id
                                     select p).SingleOrDefault();
                context.Tasks.DeleteOnSubmit(result);

                context.SubmitChanges();


                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<GetAllActiveTasksResult> GetAllActiveTasks()
        {
            try
            {

                List<GetAllActiveTasksResult> listTasks = new List<GetAllActiveTasksResult>();

                GroupProjectDataContext context = new GroupProjectDataContext();

                listTasks =
                   (from tmem in context.GetAllActiveTasks()
                    select tmem).ToList<GetAllActiveTasksResult>();

                // Create a table from the query.
                return listTasks;


            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public Task GetTaskByID(int Id)
        {
            try
            {
                GroupProjectDataContext context = new GroupProjectDataContext();

                Task result =
                   (from obj in context.Tasks
                    select obj).FirstOrDefault<Task>();

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
