
using System;

namespace SentinelScheduledAlerts
{
    public class AlertRule
    {
        public string etag { get; set; }

        public string kind = "Scheduled";

        public _properties properties;
        public class _properties
        {
            public string alertRuleTemplateName { get; set; }
            public string description { get; set; }
            public string displayName { get; set; }
            public bool enabled { get; set; }
            public string query { get; set; }
            public string queryFrequency { get; set; }
            public string queryPeriod { get; set; }
            public AlertSeverity severity { get; set; }
            public string suppressionDuration { get; set; }
            public bool suppressionEnabled { get; set; }
            public string[] tactics { get; set; }
            public TriggerOperator triggerOperator { get; set; }
            public int triggerThreshold { get; set; }

            public _properties(string _displayName, bool _enabled, string _suppressionDuration, bool _suppressionEnabled)
            {
                displayName = _displayName;
                enabled = _enabled;
                suppressionDuration = _suppressionDuration;
                suppressionEnabled = _suppressionEnabled;
            }
        }
       
        public AlertRule(string _displayName, bool _enabled, string _suppressionDuration, bool _suppressionEnabled) 
        {
            properties = new _properties(_displayName,  _enabled,  _suppressionDuration,  _suppressionEnabled);
        }
        

    }
}
