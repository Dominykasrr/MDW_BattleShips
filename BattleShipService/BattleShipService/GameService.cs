using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BattleShipService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class GameService : IPortal, IChat, IBattle
    {
        static Action<List<Player>> PlayerLogIn_Event = delegate { };
        static Action<String> Invitation_Send_Event = delegate { };
        static Action<Game> Game_Start_Event = delegate { };


        public List<Player> onlinePlayers;
        public List<Player> registeredPlayers;
        List<Game> gamesLists;

        public GameService()
        {
            onlinePlayers = new List<Player>();
            registeredPlayers = new List<Player>();
            gamesLists = new List<Game>();


            registeredPlayers.Add(new Player(1,"tool", "bar"));
            registeredPlayers.Add(new Player(2,"bar", "tool"));
            registeredPlayers.Add(new Player(3,"aa", "bb"));
        }

<<<<<<< HEAD
        public GameService(InstanceContext instanceContext)
        {
            // TODO: Complete member initialization
            this.instanceContext = instanceContext;
        }

        /// <summary>
        /// This logIn methods is going to call "CheckLogin" methods from the DB class.
        /// If there is player found with that username and password from the parameter, 
        /// than i am adding the player to the online player, 
        /// and  i am calling the PlayerLoggedIn callback methods and firing event to it.
        ///</summary>
        /// <param name="Id">Player ID</param>
        /// <param name="name">Player name</param>
        /// <param name="passwd">Player password</param>
        /// <returns>true or false</returns>
        public bool Login(int Id, string name, string passwd)
=======
        public bool Login(string name, string passwd)
>>>>>>> origin/master
        {
            DB dbhelper = new DB();

            if (dbhelper.CheckLogin(name, passwd) == 1)
            {
                Player tempPlayer;
                tempPlayer = new Player(1, name, passwd);
                tempPlayer.IPortal_Callback = OperationContext.Current.GetCallbackChannel<IPortalCallback>();
                onlinePlayers.Add(tempPlayer);
                PlayerLogIn_Event += tempPlayer.IPortal_Callback.PlayerLoggedIn;
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method will call the "UserRegister" method form class DB.
        /// And pass the data to the database from the parameter.
        /// </summary>
        /// <param name="Id">Player ID</param>
        /// <param name="name">Player name</param>
        /// <param name="passwd">Player password</param>
        /// <returns></returns>
        public bool UserRegister(int Id, string name, string passwd)
        {
            DB dbhelper = new DB();
            return dbhelper.UserRegister(name, passwd);
        }

        /// <summary>
        /// This method will call the "CheckResetPassword" method form class DB.
        /// And pass the data to the database from the parameter.
        /// </summary>
        /// <param name="Id">Player name</param>
        /// <param name="name">Player password</param>
        /// <returns></returns>
        public bool ResetPassword(string name, string passwd)
        {
            DB dbhelper = new DB();
            return dbhelper.CheckResetPassword(name, passwd);
        }

        /// <summary>
        /// This method will return the all online players.
        /// </summary>
        /// <returns>onlinePlayers</returns>
        public List<Player> GetOnlinePlayer()
        {
            return onlinePlayers;
        }

        /// <summary>
        /// I am creating playerinvitee and i am passing the paramenter p1 to it, 
        /// and aclling the event Invitation_Send_Event to IPortal_Callback NotifyChallenge 
        /// and add the parameter p2(other palyer) to invite.
        /// </summary>
        /// <param name="p1">Player1</param>
        /// <param name="p2">Player2</param>
        public void InvitePlayer(string p1, string p2)
        {
            Player playerinvitee = GetPlayer(p1);
            Invitation_Send_Event += playerinvitee.IPortal_Callback.NotifyChallenge;
            Invitation_Send_Event(p2);
        }

        /// <summary>
        /// Here i am creating two temporary players player1 and player2, and i am passing the parameter to it.
        /// And also i am crating new game, and i am paiing the player1 and player2 to the game.
        /// And firing the event "Game_Start_Event" to notify the challenge Callback. To player1 and player2.
        /// And i have fire "Game_Start_Event" to game.
        /// </summary>
        /// <param name="p1">Player1</param>
        /// <param name="p2">Player2</param>
        public void AcceptInvitation(string p1, string p2)
        {
            Player player1 = GetPlayer(p1);
            Player player2 = GetPlayer(p2);
            Game game = new Game(1, player1, player2);

            Game_Start_Event += player1.IPortal_Callback.NotifyResponce;
            Game_Start_Event += player2.IPortal_Callback.NotifyResponce;
            Game_Start_Event(game);

        }

        /// <summary>
        /// If the player is equal to playername give parameter, than returns the player.
        /// </summary>
        /// <param name="playerusername">Player username</param>
        /// <returns>null</returns>
        public Player GetPlayer(string playerusername)
        {
            foreach (Player players in this.onlinePlayers)
            {
                if (players.name == playerusername)
                {
                    return players;
                }
            }
            return null;
        }

        /// <summary>
        /// This update methods will fire the(PlayerLogIn_Event) PlayerLogIn Event.
        /// </summary>
        public void Update()
        {
            PlayerLogIn_Event(onlinePlayers);
        }


        /// <summary>
        /// This method is for posting the chat message between two players.
        /// I ma creating instance of Type player, and assign it to the opponent from the parameter.
        /// And here i am calling the UpdateChatMessages method and attaching IchatCallBack to it.
        /// </summary>
        /// <param name="message">Message type by player.</param>
        /// <param name="postername">Invitee player</param>
        /// <param name="opponent">Opponent Player</param>
        public void PostChatMessage(string message, string postername, string opponent)
        {
            Player p = GetPlayer(opponent);
            p.IchatCallBack.UpdateChatMessages(message, postername);
        }

        /// <summary>
        /// This method is for star chat session.
        /// In this method i ma calling "Start" method, and i have pass the parameter player to it.
        /// </summary>
        /// <param name="player">Player to start</param>
        public void StartChatSession(string player)
        {
            Start(player);
        }

        /// <summary>
        /// This method is to Subscribe the chat funcation.
        /// Here i have created the object p1 of Type Player. And passing the player from the parameter.
        /// After that i have called the callbak IchatCallBack to it.
        /// </summary>
        /// <param name="player"></param>
        public void Start(string player)
        {
            Player p1 = GetPlayer(player);
            p1.IchatCallBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
        }

        public void ConfirmShips(List<Ship> ships)
        {
            throw new NotImplementedException();
        }

        public void Shoot(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}



