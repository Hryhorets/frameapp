using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ConnectData = FrameApp.DAL.PostgreConnectData;

namespace FrameApp
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            cbx_preset.SelectedIndex = 0;
        }

        ConnectData[] DefaultServers =
        {
            new ConnectData("178.20.156.164","5432","postgreadmin","kptfh","grand"),
            new ConnectData("194.126.183.52","5432","postgres","yfldshyf1yfanjufp","grand_db")
        };        

        private void cbx_preset_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool visible_fields = false;
            if (cbx_preset.SelectedIndex == 2) { visible_fields = true; }

            tbx_server.Visible = lbl_server.Visible =
            tbx_port.Visible = lbl_port.Visible =
            tbx_database.Visible = lbl_database.Visible =
            tbx_user.Visible = lbl_user.Visible =
            tbx_password.Visible = lbl_password.Visible = visible_fields;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            ConnectData MyConnection;
            if (cbx_preset.SelectedIndex != 2)
            {
                MyConnection = DefaultServers[cbx_preset.SelectedIndex];
            }
            else
            {
                MyConnection = new ConnectData(
                    tbx_server.Text,
                    tbx_port.Text,
                    tbx_user.Text,
                    tbx_password.Text,
                    tbx_database.Text
                    );
            }

            MessageBox.Show(MyConnection.ConnectionString);
        }
    }
}
