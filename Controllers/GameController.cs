using System;
using System.Collections.Generic;
using Grimtol.Services;

namespace Grimtol.Controllers
{
    internal class GameController
    {
        private readonly GameService _gameService;
        public GameController()
        {
            _gameService = new GameService();
            Setup();
        }

        private void Setup()
        {
            System.Console.WriteLine("Welcome To Grimtol");
            System.Console.WriteLine("The guard at the door says \"HALT, who goes there?\"");
            string playerName = Console.ReadLine();
            _gameService.CreatePlayer(playerName);
            Run();
        }

        private void Run()
        {
            while (_gameService.GameState.Playing)
            {
                PrintMessages();
                HandleUserInput();
            }
        }

        private void HandleUserInput()
        {
            _gameService.AddMessage();
            string userInput = Console.ReadLine();
        }

        private void PrintMessages()
        {
            Console.Clear();
            List<Message> messages = _gameService.Messages;
            for (int i = messages.Count > 5 ? messages.Count - 5 : 0; i < messages.Count; i++)
            {
                Message m = messages[i];
                System.Console.WriteLine($"{m.From}: {m.Content}");
            }
        }
    }
}