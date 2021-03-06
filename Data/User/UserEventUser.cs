﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class UserEventUser {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("previousUsername")]
        public string PreviousUsername { get; set; }
    }
}
