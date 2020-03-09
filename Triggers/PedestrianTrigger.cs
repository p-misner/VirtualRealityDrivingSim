using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PedestrianTriggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pedestrian;
    public NavMeshAgent agent;
    void Start()
    {
        pedestrian = GameObject.FindGameObjectWithTag("pedestrian");
        if(pedestrian == null)
        {
            print("that's too bad");
        }
        pedestrian.gameObject.SetActive(false);
        agent.speed = 0.0f;
       
  
    }

    void OnTriggerEnter(Collider other)
    {
        print("you hit the trigger!");
        pedestrian.gameObject.SetActive(true);
        agent.speed = 1.0f;
        
    }
}
