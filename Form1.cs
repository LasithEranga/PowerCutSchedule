using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace PowerCutSchedule
{
    public partial class PowerCutSchedule : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public PowerCutSchedule()
        {
            InitializeComponent();
            var values = new Dictionary<string, string>
              {
                  { "RequestVerificationToken", "CfDJ8DRug-ybtbxAjw2fB8wdOCOVCtuvvGJqobQz-1nkU3ndefl5UgXmsO5OGq3FR30MbhT0cdB_NrbdhSfqrNaA-LbqTJRd2-fbDStpFxQagsrt0p2VHa4no5UjFwv6T-JwogQGhA4zMSpducoqFz8GVP8" },
                  { "Cookie", ".AspNetCore.Antiforgery.ThOcTlhnrMo=CfDJ8DRug-ybtbxAjw2fB8wdOCNFI98Jv_Jwb7v7LVad84zXCqypz2plALDzqEPkKUB8OMjniOAj80fiZA0fy-Ld9uzzmApq5TmqWYyJHib5ajckBJ1_GPh4euVbSDvSODNzdAaP8N4CxqWvuxNj5ftu9Zc" }
              };

            var content = new FormUrlEncodedContent(values);

            var response =  client.PostAsync("https://cebcare.ceb.lk/Incognito/GetLoadSheddingEvents", content);

            Console.WriteLine(response.Result);
        }

        
    }
}
