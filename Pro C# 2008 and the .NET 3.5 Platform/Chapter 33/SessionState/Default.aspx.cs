using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    lblUserID.Text = string.Format("Here is your ID: {0}",
      Session.SessionID);
  }
  protected void btnSubmit_Click(object sender, EventArgs e)
  {
    // Set current user prefs.
    UserShoppingCart cart =
      (UserShoppingCart)Session["UserShoppingCartInfo"];
    cart.dateOfPickUp = myCalendar.SelectedDate;
    cart.desiredCar = txtCarMake.Text;
    cart.desiredCarColor = txtCarColor.Text;
    cart.downPayment = float.Parse(txtDownPayment.Text);
    cart.isLeasing = chkIsLeasing.Checked;
    lblUserInfo.Text = cart.ToString();
    Session["UserShoppingCartInfo"] = cart;
  }
}