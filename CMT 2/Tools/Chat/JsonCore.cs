using System;
using System.Linq;

namespace CMT_2.Tools.Chat
{
    public class JsonCore
    {
        public string JsonToText(string Json)
        {
            string buffer = "";
            var Matches = Json.Replace("\\\\\\\"", "¬").Split('\"');
            for (int i = 0; i < Matches.Length; i++)
                if (i % 2 == 1 && Matches[i].Contains('>'))
                    buffer += Matches[i].Replace("¬", "\"").Replace("\\n", Environment.NewLine) + Environment.NewLine;
            return buffer;
        }
    }
}
