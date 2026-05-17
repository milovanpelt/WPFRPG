using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public World CurrentWorld { get; set; }

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

            CurrentLocation = CurrentWorld.LocationAt(new Vector2(0, 0));
        }
    }
}
