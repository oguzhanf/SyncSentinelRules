using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SentinelScheduledAlerts;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.ComponentModel;

namespace SentinelAPIClient
{
    public class SentinelLAWClient
    {
        private string WorkspaceId { get; }
        private string SharedKey { get; }
        private string RequestBaseUrl { get; set; }
        private string resourceGroupName { get; set; }
        private string subscriptionId { get; set; }
        private string workspaceName { get; set; }
        private string ruleId { get; set;    }
        public string tenantId { get; private set; }
        public string clientId { get; private set; }
        public string clientKey { get; private set; }
        private string authSignature; 
        private readonly HttpClient httpClient;

        public SentinelLAWClient
            (
                string _subscriptionID, 
                string _resourceGroupName, 
                string _workspaceName, 
                string _tenantID, 
                string _ruleID, 
                string _clientID, 
                string _clientKey
            )
        {
          
            //subscriptionId = "15230364-054e-4c9d-944d-352891ddcea0";
            //resourceGroupName = "sentinelrg";
            //workspaceName = "OzSentinel";
            //ruleId = "myfirstfusionrule";
            //tenantId = "a46bfb0c-d90b-4f42-992d-532681d1f9eb";
            //clientId = "46c225bb-13f6-4683-8e47-5e3ad3218b9f";
            //clientKey = "zwDWkz5.5r2PkPv3_Qq_nqQq4gtJ2Zd-u2";

            subscriptionId = _subscriptionID;
            resourceGroupName = _resourceGroupName;
            workspaceName = _workspaceName;
            tenantId = _tenantID;
            ruleId = _ruleID;
            clientId = _clientID;
            clientKey = _clientKey;

            //= $"https://{WorkspaceId}.ods.opinsights.azure.com/api/logs?api-version={Consts.ApiVersion}";
            
            httpClient = new HttpClient();
            createAuthSignature();
        }

        private async void createAuthSignature() { authSignature = await GetAuthSignature(); }
        private void generateRequestBaseURL()
        {
            RequestBaseUrl =
                    "https://management.azure.com/subscriptions/"
                    + subscriptionId
                    + "/resourceGroups/"
                    + resourceGroupName
                    + "/providers/Microsoft.OperationalInsights/workspaces/"
                    + workspaceName
                    + "/providers/Microsoft.SecurityInsights/alertRules/"
                    + ruleId
                    + "?api-version=2020-01-01";

        }
        public async Task<string> WriteAnalyticsRule(SentinelScheduledAlerts.AlertRule alertRule)
        {
            var dateTimeNow = DateTime.UtcNow.ToString("r");

            var entityAsJson = JsonConvert.SerializeObject(alertRule, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            






            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Remove("Authorization");

            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authSignature.ToString());
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + authSignature);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("x-ms-date", dateTimeNow);
            httpClient.DefaultRequestHeaders.Add("time-generated-field", ""); // if we want to extend this in the future to support custom date fields from the entity etc.

            HttpContent httpContent = new StringContent(entityAsJson, Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await httpClient.PutAsync(new Uri(RequestBaseUrl), httpContent).ConfigureAwait(false);
            
            string textresult = await response.Content.ReadAsStringAsync();
            // Bubble up exceptions if there are any, don't swallow them here. This lets consumers handle it better.
            return textresult;
            //response.EnsureSuccessStatusCode();


        }
        private async Task<string> GetAuthSignature()
        {
            
            string authContextURL = "https://login.windows.net/" + tenantId;
            var authenticationContext = new AuthenticationContext(authContextURL);
            var credential = new ClientCredential(clientId, clientKey);
            var result = await authenticationContext
                .AcquireTokenAsync("https://management.azure.com/", credential);
            
            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }
            string token = result.AccessToken;
            return token;

        }
    }
}
