/*
 * VideIO API
 *
 * VideIO project API specification.
 *
 * The version of the OpenAPI document: 1.0.6
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using WideIO.API.Converters;

namespace MyWideIO.API.Models.Dto_Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class VideoListDto : IEquatable<VideoListDto>
    {
        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name = "videos", EmitDefaultValue = false)]
        public List<VideoMetadataDto> Videos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoListDto {\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((VideoListDto)obj);
        }

        /// <summary>
        /// Returns true if VideoListDto instances are equal
        /// </summary>
        /// <param name="other">Instance of VideoListDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoListDto other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return

                    Videos == other.Videos ||
                    Videos != null &&
                    other.Videos != null &&
                    Videos.SequenceEqual(other.Videos)
                ;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Videos != null)
                    hashCode = hashCode * 59 + Videos.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(VideoListDto left, VideoListDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VideoListDto left, VideoListDto right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
