using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PedestrianWalk : MonoBehaviour
{
    // Start is called before the first frame update
   //public GameObject pedestrian;
   // public NavMeshAgent agent;
    public Transform destination;
    /* void Start()
     {
         pedestrian = GameObject.FindGameObjectWithTag("pedestrian");
         if(pedestrian == null)
         {
             Debug.Log("no peds found");
         }
         else
         {
             Debug.Log(pedestrian.transform.position);
         }
         //pedestrian.gameObject.SetActive(false);
         agent.speed = 0.0f;

        // agent = pedestrian.GetComponent<NavMeshAgent>();
         agent.SetDestination(destination.position);

     }

     // Update is called once per frame
     void OnTriggerEnter(Collider other)
     {
         pedestrian = GameObject.FindGameObjectWithTag("pedestrian");
         pedestrian.gameObject.SetActive(true);
         agent.speed = 1.0f;

     } */

    private void Update()
    {
        bool didEnter = TriggerEntered.entered;
        if (didEnter == true){
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = destination.position;
            agent.speed = 1.0f;
        }
        
    }
}
