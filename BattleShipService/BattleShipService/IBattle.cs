using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BattleShipService
{
    [ServiceContract(Namespace = "BattleShipService", CallbackContract = typeof(IGameCallback))]
    public interface IBattle
    {
        [OperationContract(IsOneWay = true)]
        void StartGameSession(string player);

        [OperationContract(IsOneWay = true)]
        void ConfirmReady(List<Ship> ships, string playername); 

        [OperationContract(IsOneWay = true)]
        void MakeShot(int cellX, int cellY, int gameID);
    
    }
    [ServiceContract(Namespace = "BattleShipService")]
    public interface IGameCallback
    {
        [OperationContract]
        void NotifyStartGame(string startingPlayer);

        [OperationContract]
        void NotifyShot(int cellx, int celly, bool hit);

        [OperationContract]
        void NotifyGameEnded(string winningPlayer);
    }

}
