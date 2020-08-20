// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> A CNAME record. </summary>
    public partial class CnameRecord
    {
        /// <summary> Initializes a new instance of CnameRecord. </summary>
        public CnameRecord()
        {
        }

        /// <summary> Initializes a new instance of CnameRecord. </summary>
        /// <param name="cname"> The canonical name for this CNAME record. </param>
        internal CnameRecord(string cname)
        {
            Cname = cname;
        }

        /// <summary> The canonical name for this CNAME record. </summary>
        public string Cname { get; set; }
    }
}