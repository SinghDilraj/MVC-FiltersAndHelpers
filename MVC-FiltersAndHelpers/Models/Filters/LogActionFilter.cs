using System.Diagnostics;
using System.Web.Mvc;

namespace MVC_FiltersAndHelpers.Models.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public Stopwatch Timer { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Timer.Stop();

            ApplicationDbContext context = new ApplicationDbContext();

            ActionLog log = new ActionLog
            {
                ActionName = filterContext
                .ActionDescriptor
                .ActionName,

                ControllerName = filterContext
                .ActionDescriptor
                .ControllerDescriptor
                .ControllerName,

                ExecutionTime = Timer.ElapsedMilliseconds
            };

            context.ActionLogs.Add(log);
            context.SaveChanges();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Timer = Stopwatch.StartNew();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }
    }
}