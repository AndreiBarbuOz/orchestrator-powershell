// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SimpleUserEntityDto
    {
        /// <summary>
        /// Initializes a new instance of the SimpleUserEntityDto class.
        /// </summary>
        public SimpleUserEntityDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleUserEntityDto class.
        /// </summary>
        public SimpleUserEntityDto(string userName = default(string), bool? isInherited = default(bool?), IList<long?> assignedToFolderIds = default(IList<long?>), long? id = default(long?))
        {
            UserName = userName;
            IsInherited = isInherited;
            AssignedToFolderIds = assignedToFolderIds;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsInherited")]
        public bool? IsInherited { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssignedToFolderIds")]
        public IList<long?> AssignedToFolderIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}