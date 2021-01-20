using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;
    
    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    //スコアを表示するテキスト
    private GameObject scoreText;
    void Start()
        
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
        if (tag == "SmallStarTag")
        {
            this.scoreText.GetComponent<Text>().text = "5";
        }
        else if (tag == "LargeStarTag")
        {
            this.scoreText.GetComponent<Text>().text = "10";
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.scoreText.GetComponent<Text>().text = "20";
        }
       
    }
    
}
