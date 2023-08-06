using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        //when animal collide with player 
        ss.life--;
     if(ss.life == 0)
        {
            script.game_status--;
        }
    }
}
