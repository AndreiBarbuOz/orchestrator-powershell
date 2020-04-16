// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebhookProcessScheduleDtoStartStrategy.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookProcessScheduleDtoStartStrategy
    {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Specific")]
        Specific,
        [EnumMember(Value = "RobotCount")]
        RobotCount,
        [EnumMember(Value = "JobsCount")]
        JobsCount
    }
    internal static class WebhookProcessScheduleDtoStartStrategyEnumExtension
    {
        internal static string ToSerializedValue(this WebhookProcessScheduleDtoStartStrategy? value)
        {
            return value == null ? null : ((WebhookProcessScheduleDtoStartStrategy)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookProcessScheduleDtoStartStrategy value)
        {
            switch( value )
            {
                case WebhookProcessScheduleDtoStartStrategy.All:
                    return "All";
                case WebhookProcessScheduleDtoStartStrategy.Specific:
                    return "Specific";
                case WebhookProcessScheduleDtoStartStrategy.RobotCount:
                    return "RobotCount";
                case WebhookProcessScheduleDtoStartStrategy.JobsCount:
                    return "JobsCount";
            }
            return null;
        }

        internal static WebhookProcessScheduleDtoStartStrategy? ParseWebhookProcessScheduleDtoStartStrategy(this string value)
        {
            switch( value )
            {
                case "All":
                    return WebhookProcessScheduleDtoStartStrategy.All;
                case "Specific":
                    return WebhookProcessScheduleDtoStartStrategy.Specific;
                case "RobotCount":
                    return WebhookProcessScheduleDtoStartStrategy.RobotCount;
                case "JobsCount":
                    return WebhookProcessScheduleDtoStartStrategy.JobsCount;
            }
            return null;
        }
    }
}