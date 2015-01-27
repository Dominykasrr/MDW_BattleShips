﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BattleShipClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="BattleShipService", ConfigurationName="ServiceReference1.IPortal", CallbackContract=typeof(BattleShipClient.ServiceReference1.IPortalCallback))]
    public interface IPortal {
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/UserRegister", ReplyAction="BattleShipService/IPortal/UserRegisterResponse")]
        bool UserRegister(int Id, string name, string passwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/UserRegister", ReplyAction="BattleShipService/IPortal/UserRegisterResponse")]
        System.Threading.Tasks.Task<bool> UserRegisterAsync(int Id, string name, string passwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/Login", ReplyAction="BattleShipService/IPortal/LoginResponse")]
        bool Login(int Id, string name, string passwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/Login", ReplyAction="BattleShipService/IPortal/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(int Id, string name, string passwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/ResetPassword", ReplyAction="BattleShipService/IPortal/ResetPasswordResponse")]
        bool ResetPassword(string name, string passwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/ResetPassword", ReplyAction="BattleShipService/IPortal/ResetPasswordResponse")]
        System.Threading.Tasks.Task<bool> ResetPasswordAsync(string name, string passwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/GetOnlinePlayer", ReplyAction="BattleShipService/IPortal/GetOnlinePlayerResponse")]
        BattleShipService.Player[] GetOnlinePlayer();
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/GetOnlinePlayer", ReplyAction="BattleShipService/IPortal/GetOnlinePlayerResponse")]
        System.Threading.Tasks.Task<BattleShipService.Player[]> GetOnlinePlayerAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IPortal/InvitePlayer")]
        void InvitePlayer(string p1, string p2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IPortal/InvitePlayer")]
        System.Threading.Tasks.Task InvitePlayerAsync(string p1, string p2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IPortal/AcceptInvitation")]
        void AcceptInvitation(string p1, string p2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IPortal/AcceptInvitation")]
        System.Threading.Tasks.Task AcceptInvitationAsync(string p1, string p2);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/GetPlayer", ReplyAction="BattleShipService/IPortal/GetPlayerResponse")]
        BattleShipService.Player GetPlayer(string playerusername);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/GetPlayer", ReplyAction="BattleShipService/IPortal/GetPlayerResponse")]
        System.Threading.Tasks.Task<BattleShipService.Player> GetPlayerAsync(string playerusername);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IPortal/Update")]
        void Update();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IPortal/Update")]
        System.Threading.Tasks.Task UpdateAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPortalCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IPortal/NotifyChallenge")]
        void NotifyChallenge(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IPortal/NotifyResponce", ReplyAction="BattleShipService/IPortal/NotifyResponceResponse")]
        void NotifyResponce(BattleShipService.Game game);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IPortal/PlayerLoggedIn")]
        void PlayerLoggedIn(BattleShipService.Player[] playerlists);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPortalChannel : BattleShipClient.ServiceReference1.IPortal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PortalClient : System.ServiceModel.DuplexClientBase<BattleShipClient.ServiceReference1.IPortal>, BattleShipClient.ServiceReference1.IPortal {
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool UserRegister(int Id, string name, string passwd) {
            return base.Channel.UserRegister(Id, name, passwd);
        }
        
        public System.Threading.Tasks.Task<bool> UserRegisterAsync(int Id, string name, string passwd) {
            return base.Channel.UserRegisterAsync(Id, name, passwd);
        }
        
        public bool Login(int Id, string name, string passwd) {
            return base.Channel.Login(Id, name, passwd);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(int Id, string name, string passwd) {
            return base.Channel.LoginAsync(Id, name, passwd);
        }
        
        public bool ResetPassword(string name, string passwd) {
            return base.Channel.ResetPassword(name, passwd);
        }
        
        public System.Threading.Tasks.Task<bool> ResetPasswordAsync(string name, string passwd) {
            return base.Channel.ResetPasswordAsync(name, passwd);
        }
        
        public BattleShipService.Player[] GetOnlinePlayer() {
            return base.Channel.GetOnlinePlayer();
        }
        
        public System.Threading.Tasks.Task<BattleShipService.Player[]> GetOnlinePlayerAsync() {
            return base.Channel.GetOnlinePlayerAsync();
        }
        
        public void InvitePlayer(string p1, string p2) {
            base.Channel.InvitePlayer(p1, p2);
        }
        
        public System.Threading.Tasks.Task InvitePlayerAsync(string p1, string p2) {
            return base.Channel.InvitePlayerAsync(p1, p2);
        }
        
        public void AcceptInvitation(string p1, string p2) {
            base.Channel.AcceptInvitation(p1, p2);
        }
        
        public System.Threading.Tasks.Task AcceptInvitationAsync(string p1, string p2) {
            return base.Channel.AcceptInvitationAsync(p1, p2);
        }
        
        public BattleShipService.Player GetPlayer(string playerusername) {
            return base.Channel.GetPlayer(playerusername);
        }
        
        public System.Threading.Tasks.Task<BattleShipService.Player> GetPlayerAsync(string playerusername) {
            return base.Channel.GetPlayerAsync(playerusername);
        }
        
        public void Update() {
            base.Channel.Update();
        }
        
        public System.Threading.Tasks.Task UpdateAsync() {
            return base.Channel.UpdateAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="BattleShipService", ConfigurationName="ServiceReference1.IChat", CallbackContract=typeof(BattleShipClient.ServiceReference1.IChatCallback))]
    public interface IChat {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IChat/StartChatSession")]
        void StartChatSession(string player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IChat/StartChatSession")]
        System.Threading.Tasks.Task StartChatSessionAsync(string player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IChat/PostChatMessage")]
        void PostChatMessage(string message, string postername, string opponent);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IChat/PostChatMessage")]
        System.Threading.Tasks.Task PostChatMessageAsync(string message, string postername, string opponent);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IChat/UpdateChatMessages", ReplyAction="BattleShipService/IChat/UpdateChatMessagesResponse")]
        void UpdateChatMessages(string message, string playername);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatChannel : BattleShipClient.ServiceReference1.IChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatClient : System.ServiceModel.DuplexClientBase<BattleShipClient.ServiceReference1.IChat>, BattleShipClient.ServiceReference1.IChat {
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void StartChatSession(string player) {
            base.Channel.StartChatSession(player);
        }
        
        public System.Threading.Tasks.Task StartChatSessionAsync(string player) {
            return base.Channel.StartChatSessionAsync(player);
        }
        
        public void PostChatMessage(string message, string postername, string opponent) {
            base.Channel.PostChatMessage(message, postername, opponent);
        }
        
        public System.Threading.Tasks.Task PostChatMessageAsync(string message, string postername, string opponent) {
            return base.Channel.PostChatMessageAsync(message, postername, opponent);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="BattleShipService", ConfigurationName="ServiceReference1.IBattle", CallbackContract=typeof(BattleShipClient.ServiceReference1.IBattleCallback))]
    public interface IBattle {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IBattle/StartGameSession")]
        void StartGameSession(string player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IBattle/StartGameSession")]
        System.Threading.Tasks.Task StartGameSessionAsync(string player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IBattle/ConfirmReady")]
        void ConfirmReady(BattleShipService.Ship[] ships, string playername);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IBattle/ConfirmReady")]
        System.Threading.Tasks.Task ConfirmReadyAsync(BattleShipService.Ship[] ships, string playername);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IBattle/MakeShot")]
        void MakeShot(int cellX, int cellY, int gameID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BattleShipService/IBattle/MakeShot")]
        System.Threading.Tasks.Task MakeShotAsync(int cellX, int cellY, int gameID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBattleCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IBattle/NotifyStartGame", ReplyAction="BattleShipService/IBattle/NotifyStartGameResponse")]
        void NotifyStartGame(string startingPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IBattle/NotifyShot", ReplyAction="BattleShipService/IBattle/NotifyShotResponse")]
        void NotifyShot(int cellx, int celly, bool hit);
        
        [System.ServiceModel.OperationContractAttribute(Action="BattleShipService/IBattle/NotifyGameEnded", ReplyAction="BattleShipService/IBattle/NotifyGameEndedResponse")]
        void NotifyGameEnded(string winningPlayer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBattleChannel : BattleShipClient.ServiceReference1.IBattle, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BattleClient : System.ServiceModel.DuplexClientBase<BattleShipClient.ServiceReference1.IBattle>, BattleShipClient.ServiceReference1.IBattle {
        
        public BattleClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public BattleClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public BattleClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BattleClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BattleClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void StartGameSession(string player) {
            base.Channel.StartGameSession(player);
        }
        
        public System.Threading.Tasks.Task StartGameSessionAsync(string player) {
            return base.Channel.StartGameSessionAsync(player);
        }
        
        public void ConfirmReady(BattleShipService.Ship[] ships, string playername) {
            base.Channel.ConfirmReady(ships, playername);
        }
        
        public System.Threading.Tasks.Task ConfirmReadyAsync(BattleShipService.Ship[] ships, string playername) {
            return base.Channel.ConfirmReadyAsync(ships, playername);
        }
        
        public void MakeShot(int cellX, int cellY, int gameID) {
            base.Channel.MakeShot(cellX, cellY, gameID);
        }
        
        public System.Threading.Tasks.Task MakeShotAsync(int cellX, int cellY, int gameID) {
            return base.Channel.MakeShotAsync(cellX, cellY, gameID);
        }
    }
}
