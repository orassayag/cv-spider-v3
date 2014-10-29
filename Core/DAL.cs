using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace JumboMail.Core
{
    public class DAL
    {
        #region /* BANNERS */

        internal static void UpdateBannerStats(long banner_id, string type)
        {
            using (SqlConnection con = DbUtilsDal.OpenConnection(DbUtilsDal.MainDB))
            {
                DbUtilsDal.ExecuteNonQuery(con, "dbo.UpdateBannerStats",
                           new string[] { "@banner_id", "@type" },
                           new SqlDbType[] { SqlDbType.BigInt, SqlDbType.VarChar },
                           new object[] { banner_id, type });
            }
        }

        internal static DataTable GetBannersByLocationId1(long location_Id, string cul)
        {
            DataTable T = null;
            using (SqlConnection con = DbUtilsDal.OpenConnection(DbUtilsDal.MainDB))
            {
                T = DbUtilsDal.ExecuteDataTable(con, "dbo.GetBannersByLocationId1",
                               new string[] { "@location_Id", "@cul" },
                               new SqlDbType[] { SqlDbType.BigInt, SqlDbType.Char },
                               new object[] { location_Id, cul });
            }
            return T;
        }

        #endregion
    }
}