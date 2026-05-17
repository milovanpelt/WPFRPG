using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using System.Numerics;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld() 
        {  
            World newWorld = new World();

            newWorld.AddLocation(new Location()
            {
                PositionX = 0,
                PositionY = 0,
                Name = "Cozy Home", 
                Description = "This is your home", 
                ImageName= "pack://application:,,,/Engine;component/Images/Locations/Home.png"
            });

            newWorld.AddLocation(new Location()
            {
                PositionX = 0, 
                PositionY = -1,
                Name = "Jungle",
                Description = "This is the Jungle",
                ImageName = "pack://application:,,,/Engine;component/Images/Locations/Home.png"
            }); 

            return newWorld;
        }
    }
}
