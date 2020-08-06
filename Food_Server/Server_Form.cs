using Food_Server.BusinessLogicLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Server
{
    public partial class Food_Server : Form
    {
        public Food_Server()
        {
            InitializeComponent();
            lblStatus.Text = "FOOD SERVER IS ...";
            cmbProtocol.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtPort.Enabled = false;
            cmbProtocol.Enabled = false;
            btnStart.Enabled = false;

            int port = int.Parse(txtPort.Text.Trim());
            if (cmbProtocol.SelectedIndex == 0) // tcp
                ChannelServices.RegisterChannel(new TcpChannel(port), false);
            else if (cmbProtocol.SelectedIndex == 1) // http
                ChannelServices.RegisterChannel(new HttpChannel(port), false);

            WellKnownObjectMode mode = WellKnownObjectMode.SingleCall;
            RemotingConfiguration.CustomErrorsMode = CustomErrorsModes.Off;

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(FoodBLL), "FoodBLL", mode);
            lblStatus.Text = "STATUS: SERVER is starting with PORT = " + port;
        }
    }
}
