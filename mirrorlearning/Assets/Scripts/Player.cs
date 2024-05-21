using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

namespace MirrorBasics
{
    public class Player : NetworkBehaviour
    {
        public static Player localPlayer;

        private void Start() {
            if(isLocalPlayer){
                localPlayer = this;
            }
        }
        public void HostGame(){
            
        }
    }
}