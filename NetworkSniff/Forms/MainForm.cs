using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Analysis;
using PcapDotNet.Base;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using System.Threading;
using System.IO;

namespace NetworkSniff.Forms
{
    public partial class MainForm : Form
    {
        private int totalPacketLength = 0;
        private int broadcastPackets = 0;
        private IList<LivePacketDevice> interfacesList;
        private PacketDevice selectedInterface;
        private Thread sniffThread;
        private Thread statsThread;
        private FileStream file;
        private StreamWriter writer;

        private Dictionary<int, string> protocols = new Dictionary<int, string>
        {
            { 443, "HTTPS" },
            { 53, "DNS" },
            { 80, "HTTP" },
            { 21, "FTP" },
            { 67, "DHCP Server" },
            { 68, "DHCP Client" },
            { 25, "SMTP" },
            { 143, "IMAP" },
            { 110, "POP3" }
        };


        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            stopButton.Enabled = false;

            try
            {
                interfacesList = LivePacketDevice.AllLocalMachine; // Fetch all network adapters.
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing network interface(s). Try running this application as Administrator and/or installing WinPcap." + "\n\nDebug info: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            if (interfacesList.Count == 0)
            {
                MessageBox.Show("No network interfaces found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(2);
            }

            for (int i = 0; i < interfacesList.Count; i++) // Load all interfaces into the combobox.
            {
                if (interfacesList[i].Description != null)
                {
                    adapters.Items.Add(interfacesList[i].Description);
                }
                else
                {
                    adapters.Items.Add("Unknown");
                }
            }
        }

        private void PacketHandler(Packet packet)
        {
            ListViewItem item = new ListViewItem(new string[] {
                packet.Timestamp.ToString("dd-MM-yyyy hh:mm:ss.fff"),
                packet.Ethernet.IpV4.Source.ToString(),
                packet.Ethernet.IpV4.Destination.ToString(),
                protocols.ContainsKey((int)packet.Ethernet.IpV4.Tcp.DestinationPort) ? protocols[(int)packet.Ethernet.IpV4.Tcp.DestinationPort] : packet.Ethernet.IpV4.Protocol.ToString(), // If we have a match on port number - we display it. Else we print TCP/UDP only.
                packet.Ethernet.IpV4.Length.ToString(),
                packet.BytesSequenceToHexadecimalString(" "),
            });

            if (packet.BytesSequenceToHexadecimalString(" ").StartsWith("ff ff ff ff ff ff"))
            {
                broadcastPackets++;
            }


            totalPacketLength += packet.Ethernet.IpV4.Length;
            packetsListView.Items.Add(item);

            if (checkBox1.Checked == true)
            {
                writer.WriteLine(item.Text + " " + item.SubItems[0].Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text + " " + item.SubItems[3].Text + " " + item.SubItems[4].Text + " " + item.SubItems[5].Text);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectedInterface = interfacesList[adapters.SelectedIndex]; // Get selected adapter from combobox.
            }
            catch (Exception)
            {
                MessageBox.Show("You have to select the interface!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            adapters.Enabled = false;
            checkBox1.Enabled = false;
            startButton.Enabled = false;
            stopButton.Enabled = true;

            if (checkBox1.Checked)
            {
                file = new FileStream("out.dat", FileMode.Create);
                writer = new StreamWriter(file);
                writer.WriteLine("Timestamp Source Destination Protocol Length Contents\n");
            }

            sniffThread = new Thread(() =>
            {
                PacketCommunicator communicator = selectedInterface.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000);
                communicator.ReceivePackets(0, PacketHandler);
         });

            statsThread = new Thread(() =>
            {
                while (true)
                {
                    totalPacketsLabel.Text = packetsListView.Items.Count.ToString();
                    avgLengthLabel.Text = (totalPacketLength / (packetsListView.Items.Count == 0 ? 1 : packetsListView.Items.Count)).ToString();
                    broadcastLabel.Text = broadcastPackets.ToString();
                }
            });

            sniffThread.Start();
            statsThread.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            sniffThread.Suspend();
            statsThread.Suspend();

            if (checkBox1.Checked)
            {
                writer.Close();
                file.Close();
            }


            adapters.Enabled = true;
            checkBox1.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;

        }
    }
}
