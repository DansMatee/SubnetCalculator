using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

// FUNCTIONS

namespace SubnetCalculator
{
    public partial class subnet_form_app : Form
    {
        private Subnet[] getSubnetInformation(int subnet, int networkid)
        {
            int subnetBuffer = subnet + 2;
            int IPRange = 0;
            int returnBitNetUses = 0;
            int subnetMask = 0;

            int rnetworkIP = 0;
            int rdefaultGateway = 0;
            int rfirstHostIP = 0;
            int rlastHostIP = 0;
            int rbroadcastIP = 0;


            List<int> bits = createBits();

            returnBitNetUses += networkid; // Sets the base returnBitNetUses to the value of networkid
            foreach (int i in bits) // Loops through List created above
            {
                if (IPRange < subnetBuffer) // If returnIPRange isn't allocated enough IPs
                {
                    IPRange += i; // Take returnIPRange and add the current bit selected in the loop
                }
                else if (IPRange >= subnetBuffer) // If returnIPRange has enough IPs
                {
                    subnetMask += i; // Add extra bits to returnSubMask
                    returnBitNetUses += 1; // Add 1 to returnBitNetUses for each bit that isn't used
                }
                else
                {
                    Debug.WriteLine("Error: foreach loop | getSubnetInformation"); // If things don't function properly
                }
            }

            Debug.WriteLine("Previous Gateway: " + defaultGateway);
            Debug.WriteLine("Previous Broadcast: " + broadcastIP);
            Debug.WriteLine("Previous Last Host: " + lastHostIP);
            Debug.WriteLine("Previous First Host: " + firstHostIP);
            Debug.WriteLine("Previous NetworkIP: " + networkIP);
            Debug.WriteLine("---");

            Debug.WriteLine("IPs Requested: " + subnet);
            Debug.WriteLine("subnet buffer: " + subnetBuffer + " IP Range: " + IPRange);
            Debug.WriteLine("Subnet Mask: 255.255.255." + subnetMask);


            // NETWORK IP
            if (firstSubnet || fourthOctet != 0)
            {
                rnetworkIP = fourthOctet;
                networkIP = rnetworkIP;
                fourthOctet = networkIP;
                Debug.WriteLine("NetworkIP Last Octet (First IP of Sub Network): " + rnetworkIP);
            }
            else
            {
                rnetworkIP = broadcastIP + 1;
                networkIP = rnetworkIP;
                fourthOctet = networkIP;
                Debug.WriteLine("Network IP Last Octect: " + rnetworkIP);
            }

            // BROADCAST IP
            if (firstSubnet || fourthOctet != 0)
            {
                rbroadcastIP = fourthOctet + IPRange;
                broadcastIP = rbroadcastIP;
                fourthOctet = broadcastIP + 1;
                Debug.WriteLine("Broadcast IP (First IP of Sub Network): " + rbroadcastIP);
            }
            else
            {
                rbroadcastIP = fourthOctet + IPRange;
                broadcastIP = rbroadcastIP;
                fourthOctet = broadcastIP + 1;
                Debug.WriteLine("Broadcast IP: " + rbroadcastIP);
            }

            // DEFAULT GATEWAY
            if (firstSubnet || fourthOctet != 0)
            {
                rdefaultGateway = rnetworkIP + 1;
                defaultGateway = rdefaultGateway;
                Debug.WriteLine("Default Gateway (First IP of Sub Network): " + rdefaultGateway);
            } else
            {
                rdefaultGateway = rnetworkIP + 1;
                defaultGateway = rdefaultGateway;
                Debug.WriteLine("Default Gateway: " + rdefaultGateway);
            }

            // LAST HOST IP
            if (firstSubnet)
            {
                rlastHostIP = rbroadcastIP - 1;
                lastHostIP = rlastHostIP;
                Debug.WriteLine("Last Host IP (First IP of Sub Network): " + rlastHostIP);
            } else
            {
                rlastHostIP += rbroadcastIP - 1;
                lastHostIP = rlastHostIP;
                Debug.WriteLine("Last Host IP: " + rlastHostIP);
            }

            // FIRST HOST IP | IF ELSE STATEMENT ISN'T NEEDED, JUST USED FOR DEBUG PRINTS TO TELL DIFFERENCE
            if (firstSubnet)
            {
                rfirstHostIP = rdefaultGateway + 1;
                firstHostIP = rfirstHostIP;
                Debug.WriteLine("First Host IP (First IP of Sub Network): " + rfirstHostIP);
            } else
            {
                rfirstHostIP = rdefaultGateway + 1;
                firstHostIP = rfirstHostIP;
                Debug.WriteLine("First Host IP: " + rfirstHostIP);
            }

            if (firstSubnet)
            {
                firstSubnet = false;
            }

            int rSubNetwork = returnBitNetUses;

            Debug.WriteLine("Current Network Address: " + firstOctet + "." + secondOctet + "." + thirdOctet + "." + fourthOctet);
            Debug.WriteLine("===============================================");






            Subnet[] result = new Subnet[] {
            new Subnet( rnetworkIP, subnetMask, rdefaultGateway, rfirstHostIP, rlastHostIP, rbroadcastIP, rSubNetwork, subnet, subnetBuffer, IPRange )
            };
            return result;
        }

        private void validateNumberKeypress(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Enter && e.KeyChar != (Char)Keys.Back && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool checkInputs()
        {
            if (!string.IsNullOrEmpty(currNetAddrOctet1.Text) && !string.IsNullOrEmpty(currNetAddrOctet2.Text) && !string.IsNullOrEmpty(currNetAddrOctet3.Text) && !string.IsNullOrEmpty(currNetAddrOctet4.Text) && !string.IsNullOrEmpty(currNetAddrSubnet.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> createBits()
        {
            List<int> bits = new List<int>();
            bits.Add(o1);
            bits.Add(o2);
            bits.Add(o4);
            bits.Add(o8);
            bits.Add(o16);
            bits.Add(o32);
            bits.Add(o64);
            bits.Add(o128);

            return bits;
        }

        // UPDATES OCTETS
        private void updateDefaultOctets()
        {
            firstOctet = Int32.Parse(currNetAddrOctet1.Text);
            secondOctet = Int32.Parse(currNetAddrOctet2.Text);
            thirdOctet = Int32.Parse(currNetAddrOctet3.Text);
            fourthOctet = Int32.Parse(currNetAddrOctet4.Text);
            subnetOctet = Int32.Parse(currNetAddrSubnet.Text);
        }
    }
}

