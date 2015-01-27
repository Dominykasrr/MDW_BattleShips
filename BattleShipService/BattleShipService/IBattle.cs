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
        [OperationContract]
        void ConfirmShips(List<Ship> ships);

        [OperationContract(IsOneWay = true)]
        void Shoot(int x, int y);
    
    }
    [ServiceContract(Namespace = "BattleShipService")]
    public interface IGameCallback
    {
        void PlayerReady();
        void NotifyShot(int x, int y);
    }

}
