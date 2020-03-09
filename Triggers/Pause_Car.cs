

using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Pause_Car : MonoBehaviour

{

    public float pauseTime = 5;
    public float carSpeed = 60;
    public bool entered = false;

    Timer timer;





    void Start()

    {

        timer = gameObject.AddComponent<Timer>();

        timer.Duration = pauseTime;


    }

    // Update is called once per frame

    void Update()

    {

        if (timer.Finished)

        {

            GameObject aiCar = GameObject.FindWithTag("Car");

            var go = aiCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>();

            go.m_Topspeed = carSpeed;

        }



    }



    private void OnTriggerEnter(Collider other)

    {

        if (entered == false)

        {

            GameObject aiCar = GameObject.FindWithTag("Car");

            var go = aiCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>();

            go.m_Topspeed = (float)0.0;

            timer.Run();

            entered = true;

        }

    }



    private void OnTriggerExit(Collider other)

    {
        PauseCoroutine();
        entered = false;
       

    }

    IEnumerator PauseCoroutine()
    {
        yield return new WaitForSeconds(2);
    }


}
