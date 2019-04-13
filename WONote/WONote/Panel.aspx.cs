using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WONote
{
    public partial class Panel : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        private string login = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected async void LoginClick(object sender, EventArgs e)
        {
            var response = client.GetAsync("http://localhost:53409/api/users/" + username.Text);
            
        }
    }
}