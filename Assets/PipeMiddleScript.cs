using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pipe middle script");
        GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");
        if (logicObject != null)
        {
            logic = logicObject.GetComponent<LogicScript>(); // adds reference to game object in runtime

            Debug.Log("Pipe found");
        }
        else
        {
            Debug.Log("No Object with \"logic\" tag found");
        }
            

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void OnTriggerEnter2D(Collider2D collision) // anything in here will run anytime an object hits a trigger
    {
        Debug.Log("Trigger");
        logic.addScore();
   

 
    }
}
