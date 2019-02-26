using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressTestHelper
{
    public  class Tools
    {
        /// <summary>
        /// Returns a random category of the specified depth
        /// </summary>
        /// <param name="depth"></param>
        /// <returns></returns>
        public static string GetCategory(string RootCategory,ref string subCategory, ref string Url)
        {
            string category = string.Empty;
            using (SqlConnection cnx = new SqlConnection(Parameters.Default.ConnectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetCategory";

                    Random i = new Random();

                    SqlParameter p = cmd.Parameters.AddWithValue("@Category", RootCategory);                 

                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Url = reader[2] as string;
                            subCategory = reader[3] as string;
                        }
                    }
                }
            }

            return subCategory;

        }

    }
}
