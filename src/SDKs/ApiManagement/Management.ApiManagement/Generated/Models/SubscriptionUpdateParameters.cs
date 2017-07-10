// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Subscription update details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SubscriptionUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionUpdateParameters
        /// class.
        /// </summary>
        public SubscriptionUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionUpdateParameters
        /// class.
        /// </summary>
        /// <param name="userId">User identifier path: /users/{uid}</param>
        /// <param name="productId">Product identifier path:
        /// /products/{productId}</param>
        /// <param name="expirationDate">New subscription expiration
        /// date.</param>
        /// <param name="displayName">Subscription name.</param>
        /// <param name="primaryKey">Primary subscription key.</param>
        /// <param name="secondaryKey">Secondary subscription key.</param>
        /// <param name="state">Subscription state. Possible states are *
        /// active – the subscription is active, * suspended – the subscription
        /// is blocked, and the subscriber cannot call any APIs of the product,
        /// * submitted – the subscription request has been made by the
        /// developer, but has not yet been approved or rejected, * rejected –
        /// the subscription request has been denied by an administrator, *
        /// cancelled – the subscription has been cancelled by the developer or
        /// administrator, * expired – the subscription reached its expiration
        /// date and was deactivated. Possible values include: 'suspended',
        /// 'active', 'expired', 'submitted', 'rejected', 'cancelled'</param>
        /// <param name="stateComment">Comments describing subscription state
        /// change by the administrator.</param>
        public SubscriptionUpdateParameters(string userId = default(string), string productId = default(string), System.DateTime? expirationDate = default(System.DateTime?), string displayName = default(string), string primaryKey = default(string), string secondaryKey = default(string), SubscriptionState? state = default(SubscriptionState?), string stateComment = default(string))
        {
            UserId = userId;
            ProductId = productId;
            ExpirationDate = expirationDate;
            DisplayName = displayName;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            State = state;
            StateComment = stateComment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user identifier path: /users/{uid}
        /// </summary>
        [JsonProperty(PropertyName = "properties.userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets product identifier path: /products/{productId}
        /// </summary>
        [JsonProperty(PropertyName = "properties.productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets new subscription expiration date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets subscription name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets primary subscription key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets secondary subscription key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// Gets or sets subscription state. Possible states are * active – the
        /// subscription is active, * suspended – the subscription is blocked,
        /// and the subscriber cannot call any APIs of the product, * submitted
        /// – the subscription request has been made by the developer, but has
        /// not yet been approved or rejected, * rejected – the subscription
        /// request has been denied by an administrator, * cancelled – the
        /// subscription has been cancelled by the developer or administrator,
        /// * expired – the subscription reached its expiration date and was
        /// deactivated. Possible values include: 'suspended', 'active',
        /// 'expired', 'submitted', 'rejected', 'cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public SubscriptionState? State { get; set; }

        /// <summary>
        /// Gets or sets comments describing subscription state change by the
        /// administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.stateComment")]
        public string StateComment { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PrimaryKey != null)
            {
                if (PrimaryKey.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PrimaryKey", 256);
                }
                if (PrimaryKey.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "PrimaryKey", 1);
                }
            }
            if (SecondaryKey != null)
            {
                if (SecondaryKey.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "SecondaryKey", 256);
                }
                if (SecondaryKey.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SecondaryKey", 1);
                }
            }
        }
    }
}
