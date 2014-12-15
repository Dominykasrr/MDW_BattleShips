using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BattleShipService
{
    [ServiceContract(CallbackContract = typeof(PlayerLogInCallback))]
    public interface IPortal
    {
        [OperationContract]
        bool Login(string name, string password);
    }
    [ServiceContract]
    public interface PlayerLogInCallback
    {
        [OperationContract]
        void playerLoggedIn(string name);
    }

}