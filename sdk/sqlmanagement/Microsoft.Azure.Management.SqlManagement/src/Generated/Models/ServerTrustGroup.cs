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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A server trust group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerTrustGroup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerTrustGroup class.
        /// </summary>
        public ServerTrustGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerTrustGroup class.
        /// </summary>
        /// <param name="groupMembers">Group members information for the server
        /// trust group.</param>
        /// <param name="trustScopes">Trust scope of the server trust
        /// group.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public ServerTrustGroup(IList<ServerInfo> groupMembers, IList<string> trustScopes, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            GroupMembers = groupMembers;
            TrustScopes = trustScopes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets group members information for the server trust group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupMembers")]
        public IList<ServerInfo> GroupMembers { get; set; }

        /// <summary>
        /// Gets or sets trust scope of the server trust group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trustScopes")]
        public IList<string> TrustScopes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (GroupMembers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupMembers");
            }
            if (TrustScopes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TrustScopes");
            }
            if (GroupMembers != null)
            {
                foreach (var element in GroupMembers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}