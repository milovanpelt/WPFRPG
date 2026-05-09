using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; private set; }

        public GameSession() 
        { 
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Snowy";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 0;
            CurrentPlayer.Gold = 0;
        }
    }
}
