// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// HDInsight streaming activity properties.
    /// </summary>
    public partial class HDInsightStreamingActivityTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightStreamingActivityTypeProperties class.
        /// </summary>
        public HDInsightStreamingActivityTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightStreamingActivityTypeProperties class.
        /// </summary>

        /// <param name="storageLinkedServices">Storage linked service references.
        /// </param>

        /// <param name="arguments">User specified arguments to HDInsightActivity.
        /// </param>

        /// <param name="getDebugInfo">Debug info option.
        /// Possible values include: &#39;None&#39;, &#39;Always&#39;, &#39;Failure&#39;</param>

        /// <param name="mapper">Mapper executable name. Type: string (or Expression with resultType
        /// string).
        /// </param>

        /// <param name="reducer">Reducer executable name. Type: string (or Expression with resultType
        /// string).
        /// </param>

        /// <param name="input">Input blob path. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="output">Output blob path. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="filePaths">Paths to streaming job files. Can be directories.
        /// </param>

        /// <param name="fileLinkedService">Linked service reference where the files are located.
        /// </param>

        /// <param name="combiner">Combiner executable name. Type: string (or Expression with resultType
        /// string).
        /// </param>

        /// <param name="commandEnvironment">Command line environment values.
        /// </param>

        /// <param name="defines">Allows user to specify defines for streaming job request.
        /// </param>
        public HDInsightStreamingActivityTypeProperties(object mapper, object reducer, object input, object output, System.Collections.Generic.IList<object> filePaths, System.Collections.Generic.IList<LinkedServiceReference> storageLinkedServices = default(System.Collections.Generic.IList<LinkedServiceReference>), System.Collections.Generic.IList<object> arguments = default(System.Collections.Generic.IList<object>), string getDebugInfo = default(string), LinkedServiceReference fileLinkedService = default(LinkedServiceReference), object combiner = default(object), System.Collections.Generic.IList<object> commandEnvironment = default(System.Collections.Generic.IList<object>), System.Collections.Generic.IDictionary<string, object> defines = default(System.Collections.Generic.IDictionary<string, object>))

        {
            this.StorageLinkedServices = storageLinkedServices;
            this.Arguments = arguments;
            this.GetDebugInfo = getDebugInfo;
            this.Mapper = mapper;
            this.Reducer = reducer;
            this.Input = input;
            this.Output = output;
            this.FilePaths = filePaths;
            this.FileLinkedService = fileLinkedService;
            this.Combiner = combiner;
            this.CommandEnvironment = commandEnvironment;
            this.Defines = defines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageLinkedServices")]
        public System.Collections.Generic.IList<LinkedServiceReference> StorageLinkedServices {get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.IList<object> Arguments {get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: &#39;None&#39;, &#39;Always&#39;, &#39;Failure&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "getDebugInfo")]
        public string GetDebugInfo {get; set; }

        /// <summary>
        /// Gets or sets mapper executable name. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mapper")]
        public object Mapper {get; set; }

        /// <summary>
        /// Gets or sets reducer executable name. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reducer")]
        public object Reducer {get; set; }

        /// <summary>
        /// Gets or sets input blob path. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "input")]
        public object Input {get; set; }

        /// <summary>
        /// Gets or sets output blob path. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "output")]
        public object Output {get; set; }

        /// <summary>
        /// Gets or sets paths to streaming job files. Can be directories.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "filePaths")]
        public System.Collections.Generic.IList<object> FilePaths {get; set; }

        /// <summary>
        /// Gets or sets linked service reference where the files are located.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fileLinkedService")]
        public LinkedServiceReference FileLinkedService {get; set; }

        /// <summary>
        /// Gets or sets combiner executable name. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "combiner")]
        public object Combiner {get; set; }

        /// <summary>
        /// Gets or sets command line environment values.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commandEnvironment")]
        public System.Collections.Generic.IList<object> CommandEnvironment {get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for streaming job request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defines")]
        public System.Collections.Generic.IDictionary<string, object> Defines {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Mapper == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Mapper");
            }
            if (this.Reducer == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Reducer");
            }
            if (this.Input == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Input");
            }
            if (this.Output == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Output");
            }
            if (this.FilePaths == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "FilePaths");
            }
            if (this.StorageLinkedServices != null)
            {
                foreach (var element in this.StorageLinkedServices)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }







            if (this.FileLinkedService != null)
            {
                this.FileLinkedService.Validate();
            }



        }
    }
}