using CommunityToolkit.Mvvm.ComponentModel;
using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Engine.ViewModels
{
    public partial class GameSession : ObservableObject
    {
        public Player CurrentPlayer { get; set; }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(HasLocationNorth))]
        [NotifyPropertyChangedFor(nameof(HasLocationSouth))]
        [NotifyPropertyChangedFor(nameof(HasLocationEast))]
        [NotifyPropertyChangedFor(nameof(HasLocationWest))]
        private Location currentLocation;

        public World CurrentWorld { get; set; }

        public bool HasLocationNorth => CurrentWorld.CanMoveInDirection(CurrentLocation, Direction.North);
        public bool HasLocationSouth => CurrentWorld.CanMoveInDirection(CurrentLocation, Direction.South);
        public bool HasLocationEast => CurrentWorld.CanMoveInDirection(CurrentLocation, Direction.East);
        public bool HasLocationWest => CurrentWorld.CanMoveInDirection(CurrentLocation, Direction.West);

        public GameSession() 
        {
            CurrentPlayer = new Player()
            {
                Name = "Snowy",
                CharacterClass = "Fighter",
                HitPoints = 10,
                ExpPoints = 0,
                Level = 0,
                Gold = 0
            };

            WorldFactory worldFactory = new WorldFactory();
            CurrentWorld = worldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.GetLocationAt(0, 0);
        }

        public void MovePlayer(Direction direction)
        {
            Debug.Assert(CurrentLocation != null, $"[{nameof(GameSession)}]: Current location is uninitialized");

            Location nextLocation = CurrentWorld.GetNextLocation(currentLocation, direction);

            if (nextLocation != null)
            {
                CurrentLocation = nextLocation;
            }
        }
    }
}
