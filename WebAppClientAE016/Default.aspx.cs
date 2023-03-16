using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppClientAE016
{
    public partial class _Default : Page
    {
        WSClientAE016.WS_Client_Invoice_AE016 WS = new WSClientAE016.WS_Client_Invoice_AE016();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = WS.Customers(Id.Text, Name.Text, Adress.Text, Age.Text, 
            Phone.Text, NIE.Text, "2", true);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = WS.Customers(Id.Text, Name.Text, Adress.Text, Age.Text,
            Phone.Text, NIE.Text, "4", true);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = WS.Customers(Id.Text, Name.Text, Adress.Text, Age.Text,
            Phone.Text, NIE.Text, "4", true);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = WS.Customers(Id.Text, Name.Text, Adress.Text, Age.Text,
            Phone.Text, NIE.Text, "3", true);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnViewListClient_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = WS.Customers("0", "0", "0", "0", "0", "0", "1", true);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}