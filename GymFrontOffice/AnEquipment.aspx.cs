using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class AnEquipment : System.Web.UI.Page
{ Int32 EquipmentNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        EquipmentNo = Convert.ToInt32(Session["EquipmentNo"]);
        if(IsPostBack == false)
        {
            if(EquipmentNo != -1)
            {
                DisplayEquipment();
            }
        }
    }

    private void DisplayEquipment()
    {
        clsEquipmentCollection Addressbook = new clsEquipmentCollection();
        Addressbook.ThisEquipment.Find(EquipmentNo);
        txtEquipmentNo.Text = Addressbook.ThisEquipment.EquipmentNo.ToString();
        txtDateAdded.Text = Addressbook.ThisEquipment.EquipmentDateAdded.ToString();
        txtEquipmentColour.Text = Addressbook.ThisEquipment.EquipmentColour;
        txtEquipmentPrice.Text = Addressbook.ThisEquipment.EquipmentPrice.ToString();
        chkAvailable.Checked = Addressbook.ThisEquipment.EquipmentAvailable;

    }

    protected void tbnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsEquipment
        clsEquipment AnEquipment = new clsEquipment();
        string EquipmentDescription = txtEquipmentDescription.Text;
        string EquipmentColour = txtEquipmentColour.Text;
        string EquipmentDateAdded = txtDateAdded.Text;
        Int32 EquipmentPrice = Convert.ToInt32(txtEquipmentPrice.Text);
        string Error = "";
        Error = AnEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
        if (Error == "")
        {
            AnEquipment.EquipmentNo = EquipmentNo;

            AnEquipment.EquipmentDescription = EquipmentDescription;
            AnEquipment.EquipmentColour = EquipmentColour;
            AnEquipment.EquipmentDateAdded = Convert.ToDateTime(EquipmentDateAdded);
            AnEquipment.EquipmentPrice = Convert.ToInt32(EquipmentPrice);
            AnEquipment.EquipmentAvailable = chkAvailable.Checked;
            clsEquipmentCollection EquipmentList = new clsEquipmentCollection();

            if (EquipmentNo == -1)
            {
                EquipmentList.ThisEquipment = AnEquipment;
                EquipmentList.Add();
            }
            else
            {
                EquipmentList.ThisEquipment.Find(EquipmentNo);
                EquipmentList.ThisEquipment = AnEquipment;
                EquipmentList.Update();
            }

            Response.Redirect("EquipmentViewer.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
       

    }

    protected void tbnCancel_Click(object sender, EventArgs e)
    {

    }
 
    protected void tbnFind_Click(object sender, EventArgs e)
    {
        clsEquipment AnEquipment = new clsEquipment();
        Int32 EquipmentNo;
        
        Boolean Found = false;
        EquipmentNo = Convert.ToInt32(txtEquipmentNo.Text);
        
        Found = AnEquipment.Find(EquipmentNo);
        if (Found == true)
        {
            txtEquipmentPrice.Text = AnEquipment.EquipmentPrice.ToString();
            txtDateAdded.Text = AnEquipment.EquipmentDateAdded.ToString();
            txtEquipmentColour.Text = AnEquipment.EquipmentColour;
            txtDateAdded.Text = AnEquipment.EquipmentDateAdded.ToString();
            txtEquipmentDescription.Text = AnEquipment.EquipmentDescription;

        }
    }
}

