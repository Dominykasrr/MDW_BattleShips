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
        void ConfirmReady(string opponent);

       //[OperationContract(IsOneWay = true)]
       // void ConfirmShips(List<Ship> ships);

       // [OperationContract(IsOneWay = true)]
       // void Shoot(int x, int y);
    
    }
    [ServiceContract(Namespace = "BattleShipService")]
    public interface IGameCallback
    {
        [OperationContract]
        void PlayerReady();

        [OperationContract]
        void NotifyShot(int x, int y);
    }

}
