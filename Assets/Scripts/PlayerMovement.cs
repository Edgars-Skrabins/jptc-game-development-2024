using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // [SerializeField] private string m_myText = "Hello world!";

    // private void Start()
    // {
    //     LogMyText();
    // }
    //
    // private void LogMyText()
    // {
    //     Debug.Log(m_myText);
    // }

    [SerializeField] private float m_speed;

    private void Update()
    {
        MoveCubeForward();
    }

    private void MoveCubeForward()
    {
        Vector3 forwardVector = new Vector3(0.0f, 0.0f, 1f); // Can be replaced by Vector3.forward
        transform.Translate(forwardVector * (m_speed * Time.deltaTime));
    }
}