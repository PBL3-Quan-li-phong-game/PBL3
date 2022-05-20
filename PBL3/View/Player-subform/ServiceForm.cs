using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.Model.Context;
using PBL3.Component;
using PBL3.DTO;


namespace PBL3.View.Player_subform
{
    public partial class ServiceForm : Form
    {
        public delegate void SocketSend(object obj);
        public SocketSend socketSend;

        private List<cpnService> cpnList = new List<cpnService>();
        private USERS user;

        private int ReceiptID;
        public ServiceForm(USERS user, int ReceiptID)
        {
            this.user = user;
            this.ReceiptID = ReceiptID;
            InitializeComponent();
            initializeComponentList();
            foreach(cpnService c in cpnList)
            {
                c.txtAmount.TextChanged += txtAmount_onTextChange;
            }
            txtTotalCost.Text = "0";
        }

        private void txtAmount_onTextChange(object sender, EventArgs e)
        {
            txtTotalCost.Text = "0";
            foreach(cpnService c in cpnList)
            {
                txtTotalCost.Text = (Convert.ToInt32(txtTotalCost.Text) + Convert.ToInt32(c.lUnitPrice.Text) * Convert.ToInt32(c.txtAmount.Text)).ToString();
            }
        }

        private void initializeComponentList()
        {
            cpnList.Add(cpnMiTom);
            cpnMiTom.service = NetBLL.Instance.getServicebyID("MiTom");
            cpnMiTom.txtServiceName.Text = cpnMiTom.service.Name;
            cpnMiTom.lUnitPrice.Text = cpnMiTom.service.UnitPrice.ToString();
            cpnMiTom.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.MiTom;

            cpnList.Add(cpnMiTomTrung);
            cpnMiTomTrung.service = NetBLL.Instance.getServicebyID("MiTomTrung");
            cpnMiTomTrung.txtServiceName.Text = cpnMiTomTrung.service.Name;
            cpnMiTomTrung.lUnitPrice.Text = cpnMiTomTrung.service.UnitPrice.ToString();
            cpnMiTomTrung.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.MiTom;

            cpnList.Add(cpn7up);
            cpn7up.service = NetBLL.Instance.getServicebyID("7up");
            cpn7up.txtServiceName.Text = cpn7up.service.Name;
            cpn7up.lUnitPrice.Text = cpn7up.service.UnitPrice.ToString();
            cpn7up.pbDemo.BackgroundImage = global::PBL3.Properties.Resources._7up;

            cpnList.Add(cpnCoca);
            cpnCoca.service = NetBLL.Instance.getServicebyID("Coca");
            cpnCoca.txtServiceName.Text = cpnCoca.service.Name;
            cpnCoca.lUnitPrice.Text = cpnCoca.service.UnitPrice.ToString();
            cpnCoca.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.Coca;

            cpnList.Add(cpnMirinda);
            cpnMirinda.service = NetBLL.Instance.getServicebyID("Mirinda");
            cpnMirinda.txtServiceName.Text = cpnMirinda.service.Name;
            cpnMirinda.lUnitPrice.Text = cpnMirinda.service.UnitPrice.ToString();
            cpnMirinda.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.Mirinda;

            cpnList.Add(cpnPepsi);
            cpnPepsi.service = NetBLL.Instance.getServicebyID("Pepsi");
            cpnPepsi.txtServiceName.Text = cpnPepsi.service.Name;
            cpnPepsi.lUnitPrice.Text = cpnPepsi.service.UnitPrice.ToString();
            cpnPepsi.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.Pepsi;

            cpnList.Add(cpnRedSting);
            cpnRedSting.service = NetBLL.Instance.getServicebyID("RedSting");
            cpnRedSting.txtServiceName.Text = cpnRedSting.service.Name;
            cpnRedSting.lUnitPrice.Text = cpnRedSting.service.UnitPrice.ToString();
            cpnRedSting.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.redString;

            cpnList.Add(cpnYellowSting);
            cpnYellowSting.service = NetBLL.Instance.getServicebyID("ylSting");
            cpnYellowSting.txtServiceName.Text = cpnYellowSting.service.Name;
            cpnYellowSting.lUnitPrice.Text = cpnYellowSting.service.UnitPrice.ToString();
            cpnYellowSting.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.yellowSting;

            cpnList.Add(cpnSprite);
            cpnSprite.service = NetBLL.Instance.getServicebyID("Sprite");
            cpnSprite.txtServiceName.Text = cpnSprite.service.Name;
            cpnSprite.lUnitPrice.Text = cpnSprite.service.UnitPrice.ToString();
            cpnSprite.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.sprite;

            cpnList.Add(cpnAqua);
            cpnAqua.service = NetBLL.Instance.getServicebyID("Aqua");
            cpnAqua.txtServiceName.Text = cpnAqua.service.Name;
            cpnAqua.lUnitPrice.Text = cpnAqua.service.UnitPrice.ToString();
            cpnAqua.pbDemo.BackgroundImage = global::PBL3.Properties.Resources.Aqua;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            foreach(cpnService c in cpnList)
            {
                c.txtAmount.Text = "0";
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            if (txtTotalCost.Text == "0") return;
            DialogResult r = MessageBox.Show("Xác nhận đặt đơn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                foreach(cpnService c in cpnList)
                {
                    if(c.txtAmount.Text != "0")
                    {
                        socketSend(new MSGviaSocket
                        {
                            Title = "RECEIPT",
                            Message = user.UserName + "," + ReceiptID.ToString() + "," + c.service.ID + "," + c.txtAmount.Text  
                            // format "UserName,ReceiptID,ServiceID,Amount"
                        });
                    }
                }
                this.Close();
            }
        }
    }
}
