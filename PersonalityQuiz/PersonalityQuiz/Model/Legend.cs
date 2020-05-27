using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PersonalityQuiz
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Legend
    {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public String name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public String description { get; set; }
    }
}
