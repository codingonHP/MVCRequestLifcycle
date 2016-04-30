using System.Web;

namespace MVCRequestLifeCycle.Handlers
{
    public class SimpleHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("Hello from process request");
        }

        public bool IsReusable
        {
            get
            {
                return true;
            } 
        }
    }
}