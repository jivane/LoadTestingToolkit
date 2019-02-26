using Microsoft.VisualStudio.TestTools.WebTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressTestHelper
{
    public class GetCategoriesRequestPlugin : WebTestRequestPlugin
    {
        public override void PreRequest(object sender, PreRequestEventArgs e)
        {
            base.PreRequest(sender, e);

            //string Category = Tools.GetCategory(e.WebTest.Context["Category"].ToString());

            //e.WebTest.Context.Add("Category", cat1);
            //e.WebTest.Context.Add("CategoryDoubleEncoded", HttpUtility.UrlEncode(HttpUtility.UrlEncode(cat1)));
            //e.WebTest.Context.Add("SubCategory", cat2);
            //e.WebTest.Context.Add("SubCategoryDoubleEncoded", HttpUtility.UrlEncode(HttpUtility.UrlEncode(cat2)));
        }

    }
}
