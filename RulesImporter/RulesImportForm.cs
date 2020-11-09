using SentinelScheduledAlerts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;

namespace RulesImporter
{

    public partial class RulesImportForm : Form
    {
        public RulesImportForm()
        {
            InitializeComponent();
            dt = new DataTable();
            id = new DataColumn("id", typeof(string));
            name = new DataColumn("name", typeof(string));
            description = new DataColumn("description", typeof(string));
            severity = new DataColumn("severity", typeof(string));
            query = new DataColumn("query", typeof(string));
            dataconnectors = new DataColumn("dataconnectors", typeof(string));
            queryFrequency = new DataColumn("queryFrequency", typeof(string));
            queryPeriod = new DataColumn("queryPeriod", typeof(string));
            triggerOperator = new DataColumn("triggerOperator", typeof(string));
            triggerThreshold = new DataColumn("triggerThreshold", typeof(string));
            tactics = new DataColumn("tactics", typeof(string));
            relevantTechniques = new DataColumn("relevantTechniques", typeof(string));

            dt.Columns.Add(id);
            dt.Columns.Add(name);
            dt.Columns.Add(description);
            dt.Columns.Add(severity);
            dt.Columns.Add(query);
            dt.Columns.Add(dataconnectors);
            dt.Columns.Add(queryFrequency);
            dt.Columns.Add(queryPeriod);
            dt.Columns.Add(triggerOperator);
            dt.Columns.Add(triggerThreshold);
            dt.Columns.Add(tactics);
            dt.Columns.Add(relevantTechniques);
            
        }
        DataTable dt;
        DataColumn id, name, description, severity, query, 
            dataconnectors, queryFrequency, queryPeriod, triggerOperator, 
            triggerThreshold, tactics, relevantTechniques;

        private void SentinelGitHubRepo_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {

        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (Environment.MachineName == "DEKSTOP")
            {
                txtSubscriptionID.Text = "15230364-054e-4c9d-944d-352891ddcea0";
                txtTenantID.Text = "a46bfb0c-d90b-4f42-992d-532681d1f9eb";
                txtWorkspaceName.Text = "OzSentinel";
                txtResourceGroup.Text = "sentinelRG";
                txtClientID.Text = "46c225bb-13f6-4683-8e47-5e3ad3218b9f";
                txtClientSecret.Text = "bURYc31b2ff178W_ssI4-ZOW_ApP6h2_fV";
                txtLocalRepoPath.Text = @"C:\Users\su\Documents\GitHub\Azure-Sentinel\Detections";
            }
        }

        private async void SentinelGitHubRepo_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            int successfullyimported = 0;
            int errors = 0;
            if (MessageBox.Show("Are you ready to write all " + dt.Rows.Count.ToString() + " rules?", "Write rules", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                SentinelLAWClient sentinelClient = new SentinelLAWClient(txtSubscriptionID.Text, txtResourceGroup.Text, txtWorkspaceName.Text, txtTenantID.Text, txtClientID.Text, txtClientSecret.Text);

                foreach ( DataRow row in dt.Rows)
                {
                    try
                    {
                        AlertRule rule = new AlertRule((string)row["name"], true, "PT4H", true);
                        rule.properties.description = (string)row["description"];
                        rule.properties.query = (string)row["query"];
                        rule.properties.severity = AlertSeverity.Medium;
                        rule.properties.queryFrequency = "PT4H";
                        rule.properties.queryPeriod = "PT24H";
                        System.Threading.Thread.Sleep(1000);
                        HttpResponseMessage response = await sentinelClient.WriteAnalyticsRule(rule, (string)row["id"]);
                        if (response.IsSuccessStatusCode)
                        {
                            txtImportProgress.AppendText("Imported successfully: " + rule.properties.displayName + "\r\n");
                            successfullyimported++;
                        }
                        else
                        {
                            string errorContent = await response.Content.ReadAsStringAsync();
                            txtImportProgress.AppendText("Import error: " + response.ReasonPhrase + ":\r\n\t" + errorContent + " \r\n");
                        }

                    }
                    catch (Exception err)
                    {
                        txtImportProgress.AppendText("Error with: " + (string)row["name"] + "\r\n" + err.Message + "\r\n");
                        errors++;
                    }
                }
                txtImportProgress.AppendText("Imported " + successfullyimported.ToString() + " items successfully. " + errors.ToString() + " items have failed. \r\n ");

            }
            else 
            {

                wizardControl1.NextPage(ParseLocalRepo);
            }
        }

        public class YAMLRule
        {
            public Guid id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string severity { get; set; }
            public string queryPeriod { get; set; }
            public string queryFrequency { get; set; }
            public string triggerOpeator { get; set; }
            public string triggerThreshold { get; set; }
            public string query { get; set; }
            public requiredDataConnectors requiredDataConnectors { get; set; }

        }
        public class requiredDataConnectors
        {
            public string connectorId { get; set; }
            public string dataTypes { get; set; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (folderBrowserDialog1.ShowDialog())
            {
                case DialogResult.OK:
                    txtLocalRepoPath.Text = folderBrowserDialog1.SelectedPath;
                    break;

                default:
                    break;
            }

        }

        private string[] yamlfiles;
        private void ParseLocalRepo_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            int imported = 0;
            int errorred = 0;

            yamlfiles = Directory.GetFiles(txtLocalRepoPath.Text, "*.yaml", SearchOption.AllDirectories);
            dt.Rows.Clear();
            foreach (var yamlfile in yamlfiles)
            {
                //if (yamlfile == @"C:\Users\su\Documents\GitHub\Azure-Sentinel\Detections\yamlFiles\05fcb779-394e-47d5-8807-b6ae83cf31b5.yaml")
                //    Debugger.Break();
                try
                {

                    var input = new StringReader(File.ReadAllText(yamlfile));
                    var yaml = new YamlStream();
                    yaml.Load(input);
                    var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;

                    DataRow row = dt.NewRow();
                    try { row["id"] = mapping.Children["id"].ToString(); } catch (Exception) { row["id"] = ""; }
                    try { row["name"] = mapping.Children["name"].ToString(); } catch (Exception) { row["name"] = ""; }
                    try { row["description"] = mapping.Children["description"].ToString(); } catch (Exception) { row["description"] = ""; }
                    try { row["severity"] = mapping.Children["severity"].ToString();}catch (Exception) { row["severity"] = ""; }
                    try { row["query"] = mapping.Children["query"].ToString();}catch (Exception) { row["query"] = ""; }
                    try { row["dataconnectors"] = mapping.Children["requiredDataConnectors"].ToString(); } catch(Exception) { row["dataconnectors"] = ""; }
                    try { row["queryFrequency"] = mapping.Children["queryFrequency"].ToString();}catch (Exception) { row["queryFrequency"] = ""; }
                    try { row["queryPeriod"] = mapping.Children["queryPeriod"].ToString();}catch (Exception) { row["queryPeriod"] = ""; }
                    try { row["triggerOperator"] = mapping.Children["triggerOperator"].ToString();}catch (Exception) { row["triggerOperator"] = ""; }
                    try { row["triggerThreshold"] = mapping.Children["triggerThreshold"].ToString();}catch (Exception) { row["triggerThreshold"] = ""; }
                    try { row["tactics"] = mapping.Children["tactics"].ToString();}catch (Exception) { row["tactics"] = ""; }
                    try { row["relevantTechniques"] = mapping.Children["relevantTechniques"].ToString();}catch (Exception) { row["relevantTechniques"] = ""; }

                    dt.Rows.Add(row);
                    imported++;
                }
                catch (Exception err)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = "Error in path: " + yamlfile;
                    row["name"] = "Exception details: " + err.ToString();
   
                    dt.Rows.Add(row);
                    errorred++;
                }

                    
            }
            lblRulesImported.Text = "# of parsed without errors: " + imported.ToString() + "# of rules with local parsing errors: " + errorred.ToString() ;

            dataGridView1.DataSource = dt;
                
           






        }
    }
}
