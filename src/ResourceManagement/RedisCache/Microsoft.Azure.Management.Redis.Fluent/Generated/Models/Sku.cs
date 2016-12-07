// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// SKU parameters supplied to the create Redis operation.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The type of Redis cache to deploy. Valid
        /// values: (Basic, Standard, Premium). Possible values include:
        /// 'Basic', 'Standard', 'Premium'</param>
        /// <param name="family">The SKU family to use. Valid values: (C, P).
        /// (C = Basic/Standard, P = Premium). Possible values include: 'C',
        /// 'P'</param>
        /// <param name="capacity">The size of the Redis cache to deploy.
        /// Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5,
        /// 6), for P (Premium) family (1, 2, 3, 4).</param>
        public Sku(string name, string family, int capacity)
        {
            Name = name;
            Family = family;
            Capacity = capacity;
        }

        /// <summary>
        /// Gets or sets the type of Redis cache to deploy. Valid values:
        /// (Basic, Standard, Premium). Possible values include: 'Basic',
        /// 'Standard', 'Premium'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the SKU family to use. Valid values: (C, P). (C =
        /// Basic/Standard, P = Premium). Possible values include: 'C', 'P'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Gets or sets the size of the Redis cache to deploy. Valid values:
        /// for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P
        /// (Premium) family (1, 2, 3, 4).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (Family == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Family");
            }
        }
    }
}
