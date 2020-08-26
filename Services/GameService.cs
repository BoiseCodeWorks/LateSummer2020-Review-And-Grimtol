using System;
using System.Collections.Generic;
using Grimtol.Models;

namespace Grimtol.Services
{
    internal class GameService
    {
        public GameState GameState { get; private set; } = new GameState();
        public List<Message> Messages { get; private set; } = new List<Message>();
        public int count { get; private set; }

        internal void CreatePlayer(string playerName)
        {
            Player player = new Player(playerName);
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
            Messages.Add(new Message("Guard", $"Welcome to the castle, {player.Name}"));
        }

        internal void AddMessage()
        {
            count++;
            Messages.Add(new Message("System", $"User took action number {count}"));
        }
    }
}