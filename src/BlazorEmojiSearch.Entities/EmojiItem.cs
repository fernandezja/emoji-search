using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorEmojiSearch.Entities
{
    public class EmojiItem
    {
        private const string UNDERSCORE = "_";
        private const string WHITESPACE = " ";

        [JsonPropertyName("chars")]
        public string Chars { get; set; }
        
        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("subgroup")]
        public string SubGroup { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("shortname")]
        public string ShortName { get; set; }

        
        public string Emoji { 
            get {
                return Chars;
            } 
        }


        private string[] _shortNameToArray = null;

        public string[] ShortNameToArray
        {
            get {
                if (_shortNameToArray == null)
                {
                    _shortNameToArray = ShortName.Split(WHITESPACE, StringSplitOptions.RemoveEmptyEntries);
                }
                return _shortNameToArray;
            }
        }
    }
}
