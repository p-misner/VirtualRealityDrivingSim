using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFog : MonoBehaviour
{
   
    public ParticleSystem Fog;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        Fog.Play();

    }
}
