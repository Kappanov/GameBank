using GameBank.model;
using GameBank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.Services.Impl
{
    internal class AuthService : IAuthService
    {
        private readonly IPlayerRepository _playerRepository;

        public AuthService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public Player checkSession()
        {
            Player player= _playerRepository.getCurrentPlayer();
            return player;
        }

        public Player login(string login, string pass)
        {
            Player foundPlayer = _playerRepository.getPlayerByName(login);
            if (foundPlayer == null)
            {
                return null;
            }
            if (!foundPlayer.Password.Equals(pass)) 
            {
                return null;
            }
            _playerRepository.setCurrentPlayer(foundPlayer);
            return foundPlayer;
        }

        public Player registration(string login, string pass, string confirmPass)
        {
            if (!pass.Equals(confirmPass)) 
            {
                return null;
            }
            Player newPlayer = new Player { Name = login, Level = 1, Password = pass, Money = 0 };
            Player createdPlayer = _playerRepository.createPlayer(newPlayer);
            return createdPlayer;
        }
    }
}
