//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.AspNetCore.Mvc.Infrastructure;

//namespace MVCDemo.Filters
//{
//    public class MyLog:ActionFilterAttribute
//    {
//        public override void OnActionExecuting(ActionExecutedContext context )
//        {
//            Console.WriteLine($"-{nameof(MyLog)}.{nmaeof(OnActionExecuting)}");
//            base.OnActionExecuting(context);

//        }
//        public override void OnActionExecuted(ActionExceptedContext context)
//        {
//            Console.WriteLine($"- {nameof(MyLog)}).{ nameof(OnActionExecuted)"});
//                base.OnActionExecuted(context);
//        }
//    }
//}
