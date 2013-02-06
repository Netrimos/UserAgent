using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_UserAgent
{
    public partial class Tracy1 : System.Web.UI.Page
    {
        public TracysRow tr = new TracysRow();
        protected Tracy t = new Tracy();
        protected void Page_Load(object sender, EventArgs e)
        {
            tr = t.tracyAgent(Request.UserAgent);
            string erik = "";
        }
    }
}