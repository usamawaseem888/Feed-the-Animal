using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dstroy : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 26)
        {
            ss.life--;
            if (ss.life == 0)
            {
                script.game_status--;
            }
            Destroy(gameObject);
        }
       
    }
}
