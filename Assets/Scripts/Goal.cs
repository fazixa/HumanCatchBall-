﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject goal;


    public void OnCollisionEnter(Collision col)
    {

        if (col.rigidbody.velocity.magnitude < 1)
        {

            ScoreScript.score += 50;
        }
        else if (col.rigidbody.velocity.magnitude == 0 || col.rigidbody.velocity.magnitude >= 1){
            Destroy(col.gameObject); ScoreScript.score += 50;}
    }


    void Start()
    {

        Renderer rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.green);
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Ball":
//                Debug.Break();
                ScoreScript.score += 50;



                break;
        }
    }
}
