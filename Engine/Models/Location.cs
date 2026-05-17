using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Engine.Models
{
    public partial class Location : ObservableObject
    {
        [ObservableProperty]
        public int positionX;

        [ObservableProperty]
        public int positionY;

        [ObservableProperty]
        public string? name;

        [ObservableProperty]
        public string? description;

        [ObservableProperty]
        public string? imageName;
    }
}
