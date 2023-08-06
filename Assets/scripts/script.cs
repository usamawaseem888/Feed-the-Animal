using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class script : MonoBehaviour
{
    public TextMeshProUGUI sss;
    public TextMeshProUGUI lyf;
    public TextMeshProUGUI Game;
    public static int game_status = 1;
    // Start is called before the first frame update
    void Start()
    {
        sss.text = ss.score.ToString();
        lyf.text = ss.life.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        sss.text="score: "+ ss.score.ToString();
        lyf.text = "life:"+ ss.life.ToString();
        if(game_status==0)
        {
            Endgame();
        }
    }
    void Endgame()
    {
        int a = 0;
        Game.text = "Game Over";

        lyf.text = "life:" + a.ToString();
    }
}
