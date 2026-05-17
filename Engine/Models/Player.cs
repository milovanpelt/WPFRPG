using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
namespace Engine.Models
{
    public partial class Player : ObservableObject
    {
        [ObservableProperty]
        public string? name;

        [ObservableProperty]
        public string? characterClass;

        [ObservableProperty]
        public int hitPoints;

        [ObservableProperty]
        public int expPoints;

        [ObservableProperty]
        public int level;

        [ObservableProperty]
        public int gold;
    }
}
