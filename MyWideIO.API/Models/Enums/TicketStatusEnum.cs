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
using WideIO.API.Converters;
using System.Text.Json.Serialization;

namespace MyWideIO.API.Models.Enums
{
    /// <summary>
    /// Gets or Sets TicketStatus
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TicketStatusEnum
    {

        /// <summary>
        /// Enum SubmittedEnum for Submitted
        /// </summary>
        [EnumMember(Value = "Submitted")]
        Submitted = 1,

        /// <summary>
        /// Enum ResolvedEnum for Resolved
        /// </summary>
        [EnumMember(Value = "Resolved")]
        Resolved = 2
    }
}