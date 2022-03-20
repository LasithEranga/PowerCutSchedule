using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Net;

namespace PowerCutSchedule
{
    public partial class PowerCutSchedule : Form
    {
        public  PowerCutSchedule()
        {
            InitializeComponent();
            WebClient client = new WebClient();

            // Add a user agent header in case the
            // requested URI contains a query.

            client.Headers.Add("user-agent", "PostmanRuntime/7.29.0");
            client.Headers.Add("Cookie", ".AspNetCore.Antiforgery.ThOcTlhnrMo=CfDJ8DRug-ybtbxAjw2fB8wdOCNFI98Jv_Jwb7v7LVad84zXCqypz2plALDzqEPkKUB8OMjniOAj80fiZA0fy-Ld9uzzmApq5TmqWYyJHib5ajckBJ1_GPh4euVbSDvSODNzdAaP8N4CxqWvuxNj5ftu9Zc");
            client.Headers.Add("RequestVerificationToken", "CfDJ8DRug-ybtbxAjw2fB8wdOCOVCtuvvGJqobQz-1nkU3ndefl5UgXmsO5OGq3FR30MbhT0cdB_NrbdhSfqrNaA-LbqTJRd2-fbDStpFxQagsrt0p2VHa4no5UjFwv6T-JwogQGhA4zMSpducoqFz8GVP8");
            String data = client.UploadString("https://cebcare.ceb.lk/Incognito/GetLoadSheddingEvents","");
            
            Console.WriteLine(data);


        }

       

    }
}
