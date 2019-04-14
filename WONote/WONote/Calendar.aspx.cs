using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DB;


namespace WONote
{
    public partial class Calender : System.Web.UI.Page
    {
        private NoteEnity enity;
        Panel panel = new Panel();
        DateTime time = new DateTime();
        protected void Page_Load(object sender, EventArgs e)
        {
            enity = new NoteEnity();
            TextBox1.Visible = false;
            Button1.Visible = false;
            
                GridView1.Visible = false;
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            Button1.Visible = true;
            time = Calendar1.SelectedDate;
            if (enity.Trening.Any(t => t.uLogin == panel.login)&&enity.Trening.Any(t=>t.Id==Calendar1.SelectedDate.Day))
            {
                GridView1.Visible = true;
                GridView1.DataSource = enity.Trening.Any(t => t.Id == Calendar1.SelectedDate.Day);
                GridView1.DataBind();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (TextBox1.Text != null)
            {
                Trening trening = new Trening();
                trening.Id = time.Day;
                trening.uLogin = panel.login;
                trening.csv = TextBox1.Text;
                enity.Trening.Add(trening);
            }
        }
    }
}