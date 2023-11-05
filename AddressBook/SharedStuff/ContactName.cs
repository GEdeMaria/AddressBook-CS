using System;
using System.Collections.Generic;
using System.Text;

namespace GEM.AddressBook
{
    internal class ContactName
    {
        public string TitleString 
        {
            get
            {
                string r = string.Empty;
                if (Last != string.Empty)
                    r += Last;

                if (Last != string.Empty && First != string.Empty)
                    r += ", " + First;
                else if (First != string.Empty)
                    r += First;

                if (First != string.Empty && Middle != string.Empty)
                    r += " " + Middle.ToUpper().First() + ".";
                else if (Middle != string.Empty)
                    r += Middle;

                if (Notes != string.Empty)
                    r += " (" + Notes + ")";

                return r;

            } // => $"{Last}, {First} {Middle.First()}. ({Notes})"; 
        }

        public string Prefix { get; set; }
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Suffix { get; set; }
        public string Notes { get; set; }

        public ContactName()
        {
            Prefix = string.Empty;
            First = string.Empty;
            Middle = string.Empty;
            Last = string.Empty;
            Suffix = string.Empty;
            Notes = string.Empty;
        }

        public ContactName(string data)
        {
            string[] parts = data.Split(',');
            Prefix = parts[0];
            First = parts[1];
            Middle = parts[2];
            Last = parts[3];
            Suffix = parts[4];
            Notes = parts[5];
        }

        public override string ToString()
        {
            return $"{Prefix},{First},{Middle},{Last},{Suffix},{Notes}";
        }
    }
}
