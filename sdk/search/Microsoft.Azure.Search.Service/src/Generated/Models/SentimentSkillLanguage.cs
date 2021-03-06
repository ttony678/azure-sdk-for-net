// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SentimentSkillLanguage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SentimentSkillLanguage
    {
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "el")]
        El,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt-PT")]
        PtPT,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "tr")]
        Tr
    }
    internal static class SentimentSkillLanguageEnumExtension
    {
        internal static string ToSerializedValue(this SentimentSkillLanguage? value)
        {
            return value == null ? null : ((SentimentSkillLanguage)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SentimentSkillLanguage value)
        {
            switch( value )
            {
                case SentimentSkillLanguage.Da:
                    return "da";
                case SentimentSkillLanguage.Nl:
                    return "nl";
                case SentimentSkillLanguage.En:
                    return "en";
                case SentimentSkillLanguage.Fi:
                    return "fi";
                case SentimentSkillLanguage.Fr:
                    return "fr";
                case SentimentSkillLanguage.De:
                    return "de";
                case SentimentSkillLanguage.El:
                    return "el";
                case SentimentSkillLanguage.It:
                    return "it";
                case SentimentSkillLanguage.No:
                    return "no";
                case SentimentSkillLanguage.Pl:
                    return "pl";
                case SentimentSkillLanguage.PtPT:
                    return "pt-PT";
                case SentimentSkillLanguage.Ru:
                    return "ru";
                case SentimentSkillLanguage.Es:
                    return "es";
                case SentimentSkillLanguage.Sv:
                    return "sv";
                case SentimentSkillLanguage.Tr:
                    return "tr";
            }
            return null;
        }

        internal static SentimentSkillLanguage? ParseSentimentSkillLanguage(this string value)
        {
            switch( value )
            {
                case "da":
                    return SentimentSkillLanguage.Da;
                case "nl":
                    return SentimentSkillLanguage.Nl;
                case "en":
                    return SentimentSkillLanguage.En;
                case "fi":
                    return SentimentSkillLanguage.Fi;
                case "fr":
                    return SentimentSkillLanguage.Fr;
                case "de":
                    return SentimentSkillLanguage.De;
                case "el":
                    return SentimentSkillLanguage.El;
                case "it":
                    return SentimentSkillLanguage.It;
                case "no":
                    return SentimentSkillLanguage.No;
                case "pl":
                    return SentimentSkillLanguage.Pl;
                case "pt-PT":
                    return SentimentSkillLanguage.PtPT;
                case "ru":
                    return SentimentSkillLanguage.Ru;
                case "es":
                    return SentimentSkillLanguage.Es;
                case "sv":
                    return SentimentSkillLanguage.Sv;
                case "tr":
                    return SentimentSkillLanguage.Tr;
            }
            return null;
        }
    }
}
