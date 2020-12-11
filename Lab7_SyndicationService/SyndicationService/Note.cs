using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyndicationService
{
    public class Note
    {
        [JsonProperty("subject")]
        public string subject { get; set; }
        [JsonProperty("note1")]
        public int note1 { get; set; }
    }

    class NoteResponse
    {
        public Note[] Value { get; set; }
    }
}
