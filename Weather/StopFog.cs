using UnityEngine;

public class StopFog : MonoBehaviour
{

    public ParticleSystem Fog;

    void OnTriggerEnter(Collider other)
    {
        Fog.Stop(); //Stops emission, so fog gradually dissipates
        Fog.Clear(); //Clears all particles, so fog abruptly disappears

    }
}