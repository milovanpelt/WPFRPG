using Engine.Models;
using Engine.ViewModels;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFUI.Controls
{
    /// <summary>
    /// Interaction logic for MovementControls.xaml
    /// </summary>
    public partial class MovementControls : UserControl
    {
        public MovementControls()
        {
            InitializeComponent();
        }

        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            GameSession? _gameSession = this.DataContext as GameSession;
            _gameSession?.MovePlayer(Direction.North);
        }

        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            GameSession? _gameSession = this.DataContext as GameSession;
            _gameSession?.MovePlayer(Direction.South);
        }

        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            GameSession? _gameSession = this.DataContext as GameSession;
            _gameSession?.MovePlayer(Direction.East);
        }

        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            GameSession? _gameSession = this.DataContext as GameSession;
            _gameSession?.MovePlayer(Direction.West);
        }
    }
}
