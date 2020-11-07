using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Rest;
using SentinelScheduledAlerts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncSentinel
{
    public partial class Form1 : Form
    {
        private const string NodeSentinelWorkspaces = "Sentinel workspaces";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    SentinelAPIClient.SentinelLAWClient client = new SentinelAPIClient.SentinelLAWClient();
        //    AlertRule alertRule = new AlertRule("Oz Display Alert", true, "PT4H", true);
        //    alertRule.properties.query = File.ReadAllText("text.txt");
        //    alertRule.properties.severity = AlertSeverity.Medium;
        //    //alertRule.displayName = "Ozrule01";
        //    //alertRule.enabled = true;
        //    //alertRule.query = File.ReadAllText("text.txt");
        //    alertRule.properties.queryFrequency = "PT4H";
        //    alertRule.properties.queryPeriod = "PT24H";
        //    ////P(n)Y(n)M(n)DT(n)H(n)M(n)S
        //    //alertRule.suppressionDuration = "P0Y0M0DT0H5M0S";
        //    //alertRule.suppressionEnabled = true;
        //    //alertRule.severity = AlertSeverity.Medium;
        //    //textBox1.Text = await client.WriteAnalyticsRule(alertRule); 
            
        //}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeNodeContextMenu_Opening(object sender, CancelEventArgs e)
        {
            switch (mainTree.SelectedNode.Text)
            {
                case NodeSentinelWorkspaces:
                    
                    break;
                default:
                    break;

            }
        }
        private void treeContextMenuStateChanger(string node)
        {
            switch (node)
            {
                case NodeSentinelWorkspaces:
                    
                    break;

                default:
                    break;
            }

        }

        private void toolStripMenuItemAddNewSentinelWorkspace_Click(object sender, EventArgs e)
        {

        }
    }
}
