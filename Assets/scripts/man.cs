using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class man : MonoBehaviour
{
    ///  data variables-------- <summary>

    public float s = 10f;
    float horizon;
    public GameObject pizza_pre;


    //----------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(" score:  "+ss.score + "   ");
        Debug.Log("  life: " + ss.life+"  ");
        horizon =Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizon*s*Time.deltaTime);
        
        if(transform.position.x< -15)
        {
            transform.position=new Vector3(-15,transform.position.y,transform.position.z);  
        }
        if (transform.position.x > 15)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pizza_pre, new Vector3(transform.position.x,0.7f,transform.position.z), pizza_pre.transform.rotation);
        }
        if (ss.life == 0)
        {
            Destroy(gameObject);
        }
    }
}
