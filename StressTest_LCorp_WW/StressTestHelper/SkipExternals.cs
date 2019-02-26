using Microsoft.VisualStudio.TestTools.WebTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StressTestHelper
{
    public class SkipExternals : WebTestRequestPlugin
    {

        public override void PreRequest(object sender, PreRequestEventArgs e)
        {
            EncodeUrl(e);
            ParseDependantRequest(e);
            base.PreRequest(sender, e);
        }

        private void EncodeUrl(PreRequestEventArgs e)
        {
            e.Request.Url =  HttpUtility.UrlPathEncode(e.Request.Url); 
        }
        private void ParseDependantRequest(PreRequestEventArgs e)
        {
            //e.Request.ParseDependentRequests = false;
        }
        public override void PostRequest(object sender, PostRequestEventArgs e)
        {
          
            SkipExternalsUrls(e);
            Skip404ResponseUrls(e);
        }

        private void Skip404ResponseUrls(PostRequestEventArgs e)
        {
            if (e.Request.Url.Contains(@"http://mysuperwebsite/images/user-print.ashx"))
            {
                if (e.ResponseExists && e.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    e.WebTest.Outcome = Outcome.Pass;
                }
            }
        }

        private void SkipExternalsUrls(PostRequestEventArgs e)
        {
            Uri baseUri = new Uri((string)e.WebTest.Context["targetServer"]);
            List<string> UrlToSkip = new List<string>();
            List<WebTestRequest> toRemove = new List<WebTestRequest>();
            foreach (WebTestRequest r in e.Request.DependentRequests)
            {
                Uri currentUri = new Uri(r.Url);
                if (baseUri.DnsSafeHost != currentUri.DnsSafeHost)
                {
                    toRemove.Add(r);
                }
                if (UrlToSkip.Where(u => r.Url.Contains(u)).Count() > 0)
                {
                    toRemove.Add(r);
                }
            }

            foreach (WebTestRequest wtr in toRemove)
            {
                e.Request.DependentRequests.Remove(wtr);
            }

        }
    }
}
