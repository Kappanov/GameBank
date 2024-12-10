using GameBank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.Repository
{
    internal interface IPlayerRepository

    {
        Player createPlayer(Player player);
        Player getPlayerById(int id);

        Player updatePlayer(int id, Player updatedPlayer);
        Player deletePlayer(int id);
        Player getCurrentPlayer();
        Player getPlayerByName(string Name);
        void setCurrentPlayer(Player player);
    }
}
