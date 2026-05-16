using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

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

            CurrentLocation = new Location
            {
                Name = "Home",
                Position = new Vector2(0, -1),
                Description = "This is your house",
                ImageName = "pack://application:,,,/Engine;component/Images/Locations/Home.png"
            };
        }
    }
}
