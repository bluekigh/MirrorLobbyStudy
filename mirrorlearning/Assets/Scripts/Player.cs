using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

namespace MirrorBasics
{
    public class Player : NetworkBehaviour
    {
        public static Player localPlayer;

        private void Start()
        {
            if (isLocalPlayer)
            {
                localPlayer = this;
            }
        }
        public void HostGame()
        {
            string matchID = MatchMaker.GetRandomMatchID();
            CmdHostGame(matchID);

        }

        [Command]
        void CmdHostGame(string _matchID)
        {
            if (MatchMaker.instance.HostGame(_matchID, gameObject))
            {
                Debug.Log($"<color=green>game hosted successfully</color>");
                

            }
            else
            {
                Debug.Log($"<color=red>game hosted failed</color> ");
            }
        }
    }
}