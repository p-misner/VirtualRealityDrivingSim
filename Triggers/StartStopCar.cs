using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopCar : MonoBehaviour

{

    public float carSpeed = 25;
    public bool start = true;



    void Start()
    {
        GameObject aiCar = GameObject.FindWithTag("Leading");
        var go = aiCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>();
        go.m_Topspeed = 0;
        aiCar.gameObject.SetActive(false);
        var cubeRender = this.GetComponent<Renderer>();
        cubeRender.material.SetColor("_Color", Color.green);
    }

    private void OnTriggerEnter(Collider other)
    {
       
        Debug.Log(start);
        if (start == true)
        {
            GameObject aiCar = GameObject.FindWithTag("Leading");
            aiCar.gameObject.SetActive(true);
            var go = aiCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>();
            go.m_Topspeed = carSpeed;
        }
        else
        {
            GameObject aiCar = GameObject.FindWithTag("Leading");
            var go = aiCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>();
            go.m_Topspeed = 0;
        }
        



    }


}