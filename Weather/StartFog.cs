using UnityEngine;

public class StartFog : MonoBehaviour
{
   
    public ParticleSystem Fog;

    void OnTriggerEnter(Collider other)
    {
        Fog.Play();

    }
}
