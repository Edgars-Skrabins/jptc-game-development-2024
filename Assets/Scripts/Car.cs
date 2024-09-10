using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float fuel = 5;
    private float speed = 0;
    private float maxSpeed = 190;

    private void Refuel()
    {
        fuel += 5;
    }

    private float GetFuel()
    {
        return fuel;
    }

    private void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    private float GetSpeed()
    {
        return speed;
    }

    public void Drive()
    {
        speed = 150;
    }
}


