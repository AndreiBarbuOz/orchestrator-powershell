// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RemoveUserFromFolderParameters
    {
        /// <summary>
        /// Initializes a new instance of the RemoveUserFromFolderParameters
        /// class.
        /// </summary>
        public RemoveUserFromFolderParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RemoveUserFromFolderParameters
        /// class.
        /// </summary>
        public RemoveUserFromFolderParameters(long userId)
        {
            UserId = userId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public long UserId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}