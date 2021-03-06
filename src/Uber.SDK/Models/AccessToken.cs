﻿using Newtonsoft.Json;

namespace Uber.SDK.Models
{
    public class AccessToken
    {
        [JsonProperty(PropertyName = "access_token")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
    }
}
