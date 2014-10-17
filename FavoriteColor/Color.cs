using System;

namespace FavoriteColor
{
    public class Color
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Color(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}