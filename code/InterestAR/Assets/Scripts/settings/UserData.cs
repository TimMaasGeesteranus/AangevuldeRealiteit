using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.settings
{
    public class UserData
    { 
        // In app language
        public string Language { get; set; }

        // Range in KM
        public string Range { get; set; }

        public UserData(string language, string range)
        {
            Language = language;
            Range = range;
        }

    }
}