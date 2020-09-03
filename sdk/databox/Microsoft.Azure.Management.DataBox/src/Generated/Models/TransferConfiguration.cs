// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Configuration for defining the transfer of data.
    /// </summary>
    public partial class TransferConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the TransferConfiguration class.
        /// </summary>
        public TransferConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransferConfiguration class.
        /// </summary>
        /// <param name="transferConfigurationType">Type of the configuration
        /// for transfer. Possible values include: 'TransferAll',
        /// 'TransferUsingFilter'</param>
        /// <param name="transferFilterDetails">Map of filter type and the
        /// details to filter. This field is required only if the
        /// TransferConfigurationType is given as TransferUsingFilter.</param>
        /// <param name="transferAllDetails">Map of filter type and the details
        /// to transfer all data. This field is required only if the
        /// TransferConfigurationType is given as TransferAll</param>
        public TransferConfiguration(TransferConfigurationType transferConfigurationType, TransferConfigurationTransferFilterDetails transferFilterDetails = default(TransferConfigurationTransferFilterDetails), TransferConfigurationTransferAllDetails transferAllDetails = default(TransferConfigurationTransferAllDetails))
        {
            TransferConfigurationType = transferConfigurationType;
            TransferFilterDetails = transferFilterDetails;
            TransferAllDetails = transferAllDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the configuration for transfer. Possible
        /// values include: 'TransferAll', 'TransferUsingFilter'
        /// </summary>
        [JsonProperty(PropertyName = "transferConfigurationType")]
        public TransferConfigurationType TransferConfigurationType { get; set; }

        /// <summary>
        /// Gets or sets map of filter type and the details to filter. This
        /// field is required only if the TransferConfigurationType is given as
        /// TransferUsingFilter.
        /// </summary>
        [JsonProperty(PropertyName = "transferFilterDetails")]
        public TransferConfigurationTransferFilterDetails TransferFilterDetails { get; set; }

        /// <summary>
        /// Gets or sets map of filter type and the details to transfer all
        /// data. This field is required only if the TransferConfigurationType
        /// is given as TransferAll
        /// </summary>
        [JsonProperty(PropertyName = "transferAllDetails")]
        public TransferConfigurationTransferAllDetails TransferAllDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TransferFilterDetails != null)
            {
                TransferFilterDetails.Validate();
            }
            if (TransferAllDetails != null)
            {
                TransferAllDetails.Validate();
            }
        }
    }
}