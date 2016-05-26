using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;
using System.Data;
using System.Web.Services;

namespace Contacts
{
	public partial class TestRouting : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
				BindDummyRow();
			//string path = Request.GetFriendlyUrlFileVirtualPath();
			//string ext = Request.GetFriendlyUrlFileExtension();
			//string friendlyurl = FriendlyUrl.Resolve("~/WebForm2.aspx");
			//string link = FriendlyUrl.Href("~/WebForm1", 2013, 03, 10, 1234);
			//Response.Write("Path " + path + " Friednly URl " + friendlyurl);
		}

		private void BindDummyRow()
		{
			DataTable dummy = new DataTable();
			dummy.Columns.Add("CustomerID");
			dummy.Columns.Add("ContactName");
			dummy.Columns.Add("City");
			dummy.Rows.Add();
			gvCustomers.DataSource = dummy;
			gvCustomers.DataBind();
		}

		[WebMethod]
		public static string GetCustomers()
		{
			DataTable dt = new DataTable();
			dt.TableName = "Customers";
			dt.Columns.Add("CustomerID", typeof(string));
			dt.Columns.Add("ContactName", typeof(string));
			dt.Columns.Add("City", typeof(string));
			DataRow dr1 = dt.NewRow();
			dr1["CustomerID"] = 1;
			dr1["ContactName"] = "Customer1";
			dr1["City"] = "City1";
			dt.Rows.Add(dr1);
			DataRow dr2 = dt.NewRow();
			dr2["CustomerID"] = 2;
			dr2["ContactName"] = "Customer2";
			dr2["City"] = "City2";
			dt.Rows.Add(dr2);
			DataRow dr3 = dt.NewRow();
			dr3["CustomerID"] = 3;
			dr3["ContactName"] = "Customer3";
			dr3["City"] = "City3";
			dt.Rows.Add(dr3);
			DataRow dr4 = dt.NewRow();
			dr4["CustomerID"] = 4;
			dr4["ContactName"] = "Customer4";
			dr4["City"] = "City4";
			dt.Rows.Add(dr4);
			DataRow dr5 = dt.NewRow();
			dr5["CustomerID"] = 5;
			dr5["ContactName"] = "Customer5";
			dr5["City"] = "City5";
			dt.Rows.Add(dr5);
			DataSet ds = new DataSet();
			ds.Tables.Add(dt);
			return ds.GetXml();
		}

	}
}