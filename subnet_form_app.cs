using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace SubnetCalculator
{
    public partial class subnet_form_app : Form
    {

        int o128 = 128, o64 = 64, o32 = 32, o16 = 16, o8 = 8, o4 = 4, o2 = 2, o1 = 1;

        int firstOctet = 0, secondOctet = 0, thirdOctet = 0, fourthOctet = 0, subnetOctet = 0;

        bool firstSubnet = true, firstAddedSubnet = true;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DansMatee");
        }

        int networkIP = 0;
        int defaultGateway = 0;
        int firstHostIP = 0;
        int lastHostIP = 0;
        int broadcastIP = 0;

        public subnet_form_app()
        {
            InitializeComponent();
            AddedSubnets.Items.Clear();
        }

        private void clearAddedSubnets_Click(object sender, EventArgs e)
        {
            if (AddedSubnets.Items.Count > 0)
            {
                AddedSubnets.Items.Clear();
                if (CreatedSubnets.Items.Count > 0)
                {
                    CreatedSubnets.Items.Clear();
                    CreatedSubnets.Visible = false;
                    selectedSubnetPanel.Visible = false;
                }
                currNetAddrOctet1.Enabled = true;
                currNetAddrOctet2.Enabled = true;
                currNetAddrOctet3.Enabled = true;
                currNetAddrOctet4.Enabled = true;
                currNetAddrSubnet.Enabled = true;
                setNetworkAddr.Enabled = true;
            }
            networkIP = 0;
            defaultGateway = 0;
            firstHostIP = 0;
            lastHostIP = 0;
            broadcastIP = 0;
            clearAddedSubnets.Visible = false;
            generateSubnets.Visible = false;
            firstAddedSubnet = true;
        }

        private void generateSubnets_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                CreatedSubnets.Items.Clear();
                var items = AddedSubnets.Items;

                if (items.Count > 0)
                {
                    updateDefaultOctets();
                    CreatedSubnets.Visible = true;
                    foreach (var item in items)
                    {
                        Subnet[] itemSubnet = getSubnetInformation(Int32.Parse(item.ToString()), subnetOctet);
                        CreatedSubnets.Items.Add(itemSubnet);
                    }
                }

            }
        }

        private void CreatedSubnets_Click(object sender, EventArgs e)
        {
            Subnet[] selectedSub = (Subnet[])CreatedSubnets.SelectedItem;
            var selSubDet = selectedSubnetListbox;
            var selReqInfo = RequestInfo;

            foreach (var item in selectedSub)
            {
                selSubDet.Items.Clear();
                selReqInfo.Items.Clear();
                selectedSubnetPanel.Visible = true;

                selSubDet.Items.Add("Network IP: " + firstOctet + "." + secondOctet + "." + thirdOctet + "." + item.NetworkIP + "/" + item.subNetwork);
                selSubDet.Items.Add("Subnet Mask: 255.255.255." + item.SubMask);
                selSubDet.Items.Add("Default Gateway: " + firstOctet + "." + secondOctet + "." + thirdOctet + "." + item.DefaultGateway);
                selSubDet.Items.Add("First Host IP: " + firstOctet + "." + secondOctet + "." + thirdOctet + "." + item.FirstHostIP);
                selSubDet.Items.Add("Last Host IP: " + firstOctet + "." + secondOctet + "." + thirdOctet + "." + item.LastHostIP);
                selSubDet.Items.Add("Broadcast IP: " + firstOctet + "." + secondOctet + "." + thirdOctet + "." + item.BroadcastIP);

                selReqInfo.Items.Add("IPs Requested: " + item.IPRequested);
                selReqInfo.Items.Add("Subnet Buffer: " + item.subBuffer);
                selReqInfo.Items.Add("IP Range: " + item.IPRange);
            }

            Debug.WriteLine(selectedSub.GetType());

        }

        private void AddSubnetButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(addSubnetTextbox.Text))
            {
                int subnetToAdd = Int32.Parse(addSubnetTextbox.Text);
                AddedSubnets.Items.Add(subnetToAdd);
                addSubnetTextbox.Text = "";
                if (firstAddedSubnet)
                {
                    clearAddedSubnets.Visible = true;
                    generateSubnets.Visible = true;
                    firstAddedSubnet = false;
                }
            }
        }

        private void setNetworkAddr_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                updateDefaultOctets();

                currNetAddrOctet1.Enabled = false;
                currNetAddrOctet2.Enabled = false;
                currNetAddrOctet3.Enabled = false;
                currNetAddrOctet4.Enabled = false;
                currNetAddrSubnet.Enabled = false;
                setNetworkAddr.Enabled = false;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (selectedSubnetListbox.Items.Count > 0)
            {
                string copyData = "";
                foreach (string subnet in selectedSubnetListbox.Items)
                {
                    copyData += subnet + "\n";
                }
                foreach (string subnet2 in RequestInfo.Items)
                {
                    copyData += subnet2 + "\n";
                }
                Clipboard.SetText(copyData);
            }
        }
    }  
}
