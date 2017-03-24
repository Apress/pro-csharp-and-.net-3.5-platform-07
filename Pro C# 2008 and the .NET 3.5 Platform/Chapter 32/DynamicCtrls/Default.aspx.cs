using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
  private void ListControlsInPanel()
  {
    string theInfo = String.Empty;
    theInfo = string.Format("Has controls? {0} <br/>", myPanel.HasControls());
    foreach (Control c in myPanel.Controls)
    {
      if (!object.ReferenceEquals(c.GetType(), typeof(System.Web.UI.LiteralControl)))
      {
        theInfo += "***************************<br/>";
        theInfo += string.Format("Control Name? {0} <br/>", c.ToString());
        theInfo += string.Format("ID? {0} <br>", c.ID);
        theInfo += string.Format("Control Visible? {0} <br/>", c.Visible);
        theInfo += string.Format("ViewState? {0} <br/>", c.EnableViewState);
      }
    }
    lblControlInfo.Text = theInfo;
  }

  protected void Page_Load(object sender, System.EventArgs e)
  {
    ListControlsInPanel();
  }

  protected void btnRemovePanelItems_Click(object sender, System.EventArgs e)
  {
    myPanel.Controls.Clear();
    ListControlsInPanel();
  }

  protected void btnAddWidgets_Click(object sender, System.EventArgs e)
  {
    for (int i = 0; i < 3; i++)
    {
      // Assign a name so we can get
      // the text value out later
      // using the incoming form data.
      TextBox t = new TextBox();
      t.ID = string.Format("newTextBox{0}", i);
      myPanel.Controls.Add(t);
      ListControlsInPanel();
    }
  }
  protected void btnGetTextBoxValues_Click(object sender, System.EventArgs e)
  {
    string textBoxValues = "";
    for (int i = 0; i < Request.Form.Count; i++)
    {
      textBoxValues += string.Format("<li>{0}</li><br/>", Request.Form[i]);
    }
    lblTextBoxText.Text = textBoxValues;
  }
}
