using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength; // variable defined in unity
    // Start is called before the first frame update
    public LogicScript logic;

    public bool birdIsAlive = true;
    void Start(){
        

        GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");
        if (logicObject != null)
        {
            logic = logicObject.GetComponent<LogicScript>(); // adds reference to game object in runtime
   
        }
        else
        {
            Debug.Log("No Object with \"logic\" tag found");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive) 
        {
            myRigidbody.velocity = Vector2.up * flapStrength; // vector2.up means y component goes up 1 unit , (0,1)

        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
