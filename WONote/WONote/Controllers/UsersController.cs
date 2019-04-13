using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DB;

namespace WONote.Controllers
{
    public class UsersController : ApiController
    {
       private NoteEnity client = new NoteEnity();
        

       public bool GetUsers(string Login)
        {
            if (client.Users.Any(u => u.uLogin == Login))
            {
                return true;
            }
            return false;
        }
    }
}
