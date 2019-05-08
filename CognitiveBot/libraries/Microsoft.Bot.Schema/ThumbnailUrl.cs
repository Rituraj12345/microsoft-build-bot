// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Thumbnail URL
    /// </summary>
    public partial class ThumbnailUrl
    {
        /// <summary>
        /// Initializes a new instance of the ThumbnailUrl class.
        /// </summary>
        public ThumbnailUrl()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThumbnailUrl class.
        /// </summary>
        /// <param name="url">URL pointing to the thumbnail to use for media
        /// content</param>
        /// <param name="alt">HTML alt text to include on this thumbnail
        /// image</param>
        public ThumbnailUrl(string url = default(string), string alt = default(string))
        {
            Url = url;
            Alt = alt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL pointing to the thumbnail to use for media content
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets HTML alt text to include on this thumbnail image
        /// </summary>
        [JsonProperty(PropertyName = "alt")]
        public string Alt { get; set; }

    }
}
