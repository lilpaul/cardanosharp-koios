using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class Asset
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }

        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }

        [DataMember]
        [JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }
    }
}
