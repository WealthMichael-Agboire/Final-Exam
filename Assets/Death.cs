using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
public Health pHealth;
public float damage;

void start ()
{

}


void update ()
{

}
 
 private void OnCollisionEnter2D(Collision2D other)
{
    if(other.gameObject.CompareTag("Player"))
    {
        pHealth.health -= damage;
    }

}



//    public GameObject startPoint;
//    public GameObject Player;

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     private void OnCollisionEnter2D(Collision2D other)
//     {

//    if(other.gameObject.CompareTag("Player"))

//    {
//     Player.transform.position = startPoint.transform.position;
//    }

//     }

}
