using GameBank.model;
using GameBank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.Services.Impl
{
    internal class PLayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PLayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public Player changeName(int playerId, string newName)
        {
            Player player = _playerRepository.getPlayerById(playerId);
            player.Name = newName;
            return _playerRepository.updatePlayer(playerId, player);
        }

        public Player changePassword(int playerId, string oldPassword, string newPassword)
        {
            Player player = _playerRepository.getPlayerById(playerId);
            if (!player.Password.Equals(oldPassword))
            {
                return null;
            }
            player.Password = newPassword;
            return _playerRepository.updatePlayer(playerId, player);
        }

        public Player changeWork(int playerId, Work newWork)
        {
            throw new NotImplementedException();
        }

        public Player createBank()
        {
            throw new NotImplementedException();
        }

        public Player getStatistic()
        {
            throw new NotImplementedException();
        }

        public Player quitWork()
        {
            throw new NotImplementedException();
        }
    }
}
