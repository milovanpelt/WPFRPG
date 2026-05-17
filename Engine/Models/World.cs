using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(Location location) 
        {
            _locations.Add(location);
        }

        public Location? LocationAt(Vector2 position) 
        {
            Debug.Assert(_locations != null, "{World}: Attempted to search unitialized locations list");
            Debug.Assert(_locations.Any(), "{World}: Attempted to access empty locations list");

            foreach (var location in _locations) 
            {
                if (location.Position == position) 
                { 
                    return location;
                }
            }

            return null;
        }
    }
}
