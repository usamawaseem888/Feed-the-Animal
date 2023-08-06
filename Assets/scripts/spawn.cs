using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class spawn : MonoBehaviour
{
    ///  data variables--------
    public GameObject[] spawnGameObject;
    int animal;
    float index;



    //-------------------------------

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn_man", 1, 2f);
    }


   
    // Update is called once per frame
    void Update()
    {

        if (ss.life == 0)
        {
            CancelInvoke();
        }


    }
    void spawn_man()
    {
        animal = Random.Range(0, spawnGameObject.Length);
        index = Random.Range(-15, 15);

        Instantiate(spawnGameObject[animal], new Vector3(index, 0, -3f), spawnGameObject[animal].transform.rotation);


        
    }
}
