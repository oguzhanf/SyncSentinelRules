using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.RepresentationModel;

namespace YAMLImporterTester
{
    public partial class Form1 : Form
    {
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


        public Form1()
        {
            InitializeComponent();
        }
        string[] yamlfiles;
        private void Form1_Load(object sender, EventArgs e)
        {
            

            yamlfiles = Directory.GetFiles(@"C:\Users\su\Documents\GitHub\Azure-Sentinel\Detections", "*.yaml", SearchOption.AllDirectories);
            var input = new StringReader( File.ReadAllText(yamlfiles.First()));
            

            var yaml = new YamlStream();
            yaml.Load(input);
            var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
          
          
            Debug.WriteLine("id: " + mapping.Children["id"].ToString() );
            Debug.WriteLine("name: " + mapping.Children["name"].ToString());
            Debug.WriteLine("description" + mapping.Children["description"].ToString());

        }

    }
}
