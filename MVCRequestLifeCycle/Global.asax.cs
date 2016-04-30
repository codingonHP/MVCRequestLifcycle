using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCRequestLifeCycle
{
    public class MvcApplication : HttpApplication
    {
        //http://www.dotnetcurry.com/aspnet/747/http-request-lifecycle-events-iis-pipeline-aspnet
        protected void Application_AuthenticateRequest()
        {
            Debug.WriteLine("Application_AuthenticateRequest");
        }

        protected void Application_PostAuthenticateRequest()
        {
            Debug.WriteLine("Application_PostAuthenticateRequest");
        }

        protected void Application_AuthorizeRequest()
        {
            Debug.WriteLine("Application_AuthorizeRequest");
        }


        protected void Application_PostAuthorizeRequest()
        {
            Debug.WriteLine("Application_PostAuthorizeRequest");
        }

        protected void Application_ResolveRequestCache()
        {
            Debug.WriteLine("Application_ResolveRequestCache");
        }

        protected void Application_PostResolveRequestCache()
        {
            Debug.WriteLine("Application_PostResolveRequestCache");
        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Application_MapRequestHandler");
        }

        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Application_PostMapRequestHandler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Application_AcquireRequestState");
        }

        protected void Application_PostAcquireRequestState()
        {
            Debug.WriteLine("Application_PostAcquireRequestState");
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Application_PreRequestHandlerExecute");
        }

        protected void Application_ExecuteRequestHandler()
        {
            Debug.WriteLine("Application_ExecuteRequestHandler");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("Application_PostRequestHandlerExecute");
        }

        protected void Application_ReleaseRequestState()
        {
            Debug.WriteLine("Application_ReleaseRequestState");
        }

        protected void Application_PostReleaseRequestState()
        {
            Debug.WriteLine("Application_PostReleaseRequestState");
        }

        protected void Application_UpdateRequestCache()
        {
            Debug.WriteLine("Application_UpdateRequestCache");
        }

        protected void Application_PostUpdateRequestCache()
        {
            Debug.WriteLine("Application_PostUpdateRequestCache");
        }

        protected void Application_LogRequest()
        {
            Debug.WriteLine("Application_LogRequest");
        }

        protected void Application_PostLogRequest()
        {
            Debug.WriteLine("Application_PostLogRequest");
        }

        protected void Application_PreSendRequestHeaders()
        {
            Debug.WriteLine("Application_PreSendRequestHeaders");
        }

        protected void Application_PreSendRequestContent()
        {
            Debug.WriteLine("Application_PreSendRequestContent");
        }


        public static void PreApplicationStartLogMdl()
        {
            Debug.WriteLine("public static void PreApplicationStartLogMdl() : Pre - Application_StartConfiguration can be done here");
        }

        //Only executed once when application loads.
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        //Executes for every request
        protected void Application_BeginRequest()
        {
            Debug.WriteLine("BeginRequest");
        }

        protected void Application_EndRequest()
        {
            Debug.WriteLine("End Request");
        }
    }
}
