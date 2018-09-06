// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A sensitivity label.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SensitivityLabel : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SensitivityLabel class.
        /// </summary>
        public SensitivityLabel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SensitivityLabel class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="labelName">The label name.</param>
        /// <param name="informationType">The information type.</param>
        public SensitivityLabel(string id = default(string), string name = default(string), string type = default(string), string labelName = default(string), string informationType = default(string))
            : base(id, name, type)
        {
            LabelName = labelName;
            InformationType = informationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the label name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labelName")]
        public string LabelName { get; set; }

        /// <summary>
        /// Gets or sets the information type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.informationType")]
        public string InformationType { get; set; }

    }
}