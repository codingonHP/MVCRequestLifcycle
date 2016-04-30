using System;
using System.Diagnostics;
using System.Web;
using MVCRequestLifeCycle;
using MVCRequestLifeCycle.Modules;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "PreApplicationStartLogMdl")]
namespace MVCRequestLifeCycle.Modules
{
    public class LogModule : IHttpModule
    {

        HttpApplication _context;

        public LogModule()
        {
            Debug.WriteLine("LogModule() : Logging module created");
        }
        public void Init(HttpApplication context)
        {
            Debug.WriteLine("public void Init(HttpApplication context) : Logging module init called");
            _context = context;
            context.MapRequestHandler += context_MapRequestHandler;
        }

        void context_MapRequestHandler(object sender, EventArgs e)
        {
            Debug.WriteLine(" void context_MapRequestHandler(object sender, EventArgs e) : Logging module called");
      
        }

        public void Dispose()
        {
            Debug.WriteLine("LogModule() Dispose() : Logging module disposed");
        }
    }

   
}