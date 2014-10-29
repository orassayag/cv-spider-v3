using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace JumboMail.Core
{
    public class BLL
    {
        public static List<JMBanner> GetBannersByLocationId1(long location_Id, string cul)
        {
            List<JMBanner> BS = new List<JMBanner>();
            DataTable BannersList = DAL.GetBannersByLocationId1(location_Id, cul);
            if (BannersList != null)
            {
                foreach (DataRow R in BannersList.Rows)
                {
                    BS.Add(JMConvert.GetJMBanner(R, true, true, true, true));
                }
            }
            return BS;
        }
    }
}