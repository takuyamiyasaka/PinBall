using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrightnessRegulator : MonoBehaviour
{
    //materialを入れる
    Material myMaterial;
    private float minEmission = 0.3f;
    private float magEmission = 2.0f;
    private int degree = 0;
    private int speed = 10;
    Color defaultColor = Color.white;
    private int realpoint = 0;



    // Use this for initialization
    void Start()
    {
        if (tag == "SmallStarTag")
        {
            this.defaultColor = Color.white;
            this.realpoint = 5;
        }
        else if (tag == "LargeStarTag")
        {
            this.defaultColor = Color.yellow;
            this.realpoint = 15;
        }
        else if (tag == "SmallClouTag" || tag == "LargeCloudTag")
        {
            this.defaultColor = Color.cyan;
            this.realpoint = 20;

        }
        this.myMaterial = GetComponent<Renderer>().material;
        myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);



    }

    // Update is called once per frame
    void Update()
    {
        if (this.degree >= 0)
        {
            Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);
            myMaterial.SetColor("_EmissionColor", emissionColor);
            this.degree -= this.speed;
        }

    }
    void OnCollisionEnter(Collision other)
    {
        this.degree = 180;
    }
}



