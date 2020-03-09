using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PedestrianTrigger : MonoBehaviour
{
    //public GameObject[] test;
    public GameObject pedestrian;
    public NavMeshAgent agent;
    public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
       
        var cubeRender = this.GetComponent<Renderer>();
        Color purple = new Color(0.33f, 0.15f, 0.43f);
        cubeRender.material.SetColor("_Color",purple);
        //pedestrian = GameObject.FindGameObjectWithTag("pedestrian");
        if (pedestrian == null)
        {
            Debug.Log("no peds found");
        }
        agent.speed = 0.0f;

        
    }
    void OnTriggerEnter(Collider other)
    {
        pedestrian.gameObject.SetActive(true);
        agent.destination = destination.position;
        agent.speed = 1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
