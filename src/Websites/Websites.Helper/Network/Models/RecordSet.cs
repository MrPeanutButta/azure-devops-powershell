// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.Network.Models
{
    using System.Linq;

    /// <summary>
    /// A collective group of information about the record set information.
    /// </summary>
    public partial class RecordSet
    {
        /// <summary>
        /// Initializes a new instance of the RecordSet class.
        /// </summary>
        public RecordSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecordSet class.
        /// </summary>

        /// <param name="recordType">Resource record type.
        /// </param>

        /// <param name="recordSetName">Recordset name.
        /// </param>

        /// <param name="fqdn">Fqdn that resolves to private endpoint ip address.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the recordset.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;</param>

        /// <param name="ttl">Recordset time to live.
        /// </param>

        /// <param name="ipAddresses">The private ip address of the private endpoint.
        /// </param>
        public RecordSet(string recordType = default(string), string recordSetName = default(string), string fqdn = default(string), string provisioningState = default(string), int? ttl = default(int?), System.Collections.Generic.IList<string> ipAddresses = default(System.Collections.Generic.IList<string>))

        {
            this.RecordType = recordType;
            this.RecordSetName = recordSetName;
            this.Fqdn = fqdn;
            this.ProvisioningState = provisioningState;
            this.Ttl = ttl;
            this.IPAddresses = ipAddresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resource record type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recordType")]
        public string RecordType {get; set; }

        /// <summary>
        /// Gets or sets recordset name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recordSetName")]
        public string RecordSetName {get; set; }

        /// <summary>
        /// Gets or sets fqdn that resolves to private endpoint ip address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fqdn")]
        public string Fqdn {get; set; }

        /// <summary>
        /// Gets the provisioning state of the recordset. Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets recordset time to live.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ttl")]
        public int? Ttl {get; set; }

        /// <summary>
        /// Gets or sets the private ip address of the private endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipAddresses")]
        public System.Collections.Generic.IList<string> IPAddresses {get; set; }
    }
}