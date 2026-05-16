using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Engine.Models
{
    public class Location
    {
        public Vector2 Position { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageName { get; set; }
    }
}
