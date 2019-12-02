using Assets.Scripts.settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Settings
    {
        // In app language
        public string Language { get; set; }

        // Range in KM
        public string Range { get; set; }

        public Settings(string language, string range)
        {
            Language = language;
            Range = range;
        }
    }
}
