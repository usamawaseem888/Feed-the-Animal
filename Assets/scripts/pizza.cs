using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza : MonoBehaviour
{

    ///  data variables-------- <summary>
    public float speed = 10f;



    //----------------------------

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
        //useless since prefab is created where the object is
        // transform.position =new Vector3(man.transform.position.x, transform.position.y,transform.position.z);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //moving outof boundaries
        if (transform.position.z < -4)
        {
            Destroy(gameObject);
        }


    }
}
