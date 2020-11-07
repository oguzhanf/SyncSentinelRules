using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            dataTable = new DataTable();
            id = new DataColumn("id", typeof(string));
            name = new DataColumn("name", typeof(string));
            description = new DataColumn("description", typeof(string));
            severity = new DataColumn("severity", typeof(string));
            query = new DataColumn("query", typeof(string));
            dataTable.Columns.Add(id);
            dataTable.Columns.Add(name);
            dataTable.Columns.Add(description);
            dataTable.Columns.Add(severity);
            dataTable.Columns.Add(query);

        }
        DataTable dataTable;
        DataColumn id, name, description, severity, query, dataconnectors, queryFrequency, queryPeriod, triggerOperator, triggerThreshold, tactics, relevantTechniques;

        private void SentinelGitHubRepo_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            if (MessageBox.Show("Are you ready to write all the rules?", "Write rules", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                    
                   
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

            foreach (var yamlfile in yamlfiles)
            {
                try
                {
                    var input = new StringReader(File.ReadAllText(yamlfile));
                    var yaml = new YamlStream();
                    yaml.Load(input);
                    var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;

                    DataRow row = dataTable.NewRow();
                    row["id"] = mapping.Children["id"].ToString();
                    row["name"] = mapping.Children["name"].ToString();
                    row["description"] = mapping.Children["description"].ToString();
                    row["severity"] = mapping.Children["severity"].ToString();
                    row["query"] = mapping.Children["query"].ToString();

                    dataTable.Rows.Add(row);
                    Debug.WriteLine("id: " + mapping.Children["id"].ToString());
                    Debug.WriteLine("name: " + mapping.Children["name"].ToString());
                    Debug.WriteLine("description" + mapping.Children["description"].ToString());
                    imported++;
                }
                catch (Exception err)
                {
                    DataRow row = dataTable.NewRow();
                    row["id"] = "Error in path: " + yamlfile;
                    row["name"] = "Exception details: " + err.ToString();
                    row["description"] = "";
                    row["severity"] = "";
                    row["query"] = "";
                    dataTable.Rows.Add(row);
                    errorred++;
                }

                    
            }
            lblRulesImported.Text = "# of parsed without errors: " + imported.ToString() + "# of rules with local parsing errors: " + errorred.ToString() ;

            dataGridView1.DataSource = dataTable;
                
           






        }
    }
}
