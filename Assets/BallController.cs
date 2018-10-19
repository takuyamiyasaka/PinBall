using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    GameObject realpoint;

   

    // Use this for initialization
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        realpoint = GameObject.Find("Point");


    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "GameOver Text";
        }
        if (point >= 0)
        {
            realpoint.GetComponent<Text>().text = point + "Point";
        }
        }
        
        

    
    int point = 0;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "LargeStarTag")
        {
            point += 10;
        }
        else if (collision.gameObject.tag == "SmallStarTag")
        {
            point += 1;
        }
        else if (collision.gameObject.tag == "LargeColoudTag")
        {
            point += 20;
        }
        
        else if (collision.gameObject.tag == "SmallColoudTag")
        {
            point += 15;
        }
        Debug.Log(point);
    }
}


