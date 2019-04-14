using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DB;

namespace WONote
{
    public partial class Panel : System.Web.UI.Page
    {
        NoteEnity client = new NoteEnity();
        public string login = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void LoginClick(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
            if (client.Users.Any(u => u.uLogin == username.Text))
            {
                login = username.Text;
                submit.Attributes.Add("href", "Calendar.aspx");
            }
            }
        }
    }
}