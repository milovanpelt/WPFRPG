using Engine.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Engine.Models
{
    public enum Direction
    {
        North,
        South,
        East,
        West
    }

    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(Location location) 
        {
            _locations.Add(location);
        }

        public Location? GetNextLocation(Location currentLocation, Direction direction)
        {
            Debug.Assert(_locations != null, $"[{nameof(World)}] Attempted to search unitialized locations list");
            Debug.Assert(_locations.Any(), $"[{nameof(World)}] Attempted to access empty locations list");

            int newXLocation = currentLocation.PositionX;
            int newYLocation = currentLocation.PositionY;

            switch (direction)
            { 
                case Direction.North:
                    newYLocation -= 1;
                    break;
                case Direction.South:
                    newYLocation += 1;
                    break;
                case Direction.East:
                    newXLocation += 1;
                    break;
                case Direction.West:
                    newXLocation -= 1;
                    break;
            }

            return GetLocationAt(newXLocation, newYLocation);
        }

        public Location? GetLocationAt(int xPosition, int yPosition) 
        {
            Debug.Assert(_locations != null, "{World}: Attempted to search unitialized locations list");
            Debug.Assert(_locations.Any(), "{World}: Attempted to access empty locations list");

            foreach(Location location in _locations)
            {
                if (location.PositionX == xPosition && location.PositionY == yPosition)
                {
                    return location;
                }
            }

            return null;
        }

        public bool CanMoveInDirection(Location currentLocation, Direction direction) 
        {
            Location validLocation = GetNextLocation(currentLocation, direction);

            if (validLocation != null) 
            {
                return true;
            }

            return false;
        }
    }
}
