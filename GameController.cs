using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float gameSpeed;
    [Range(0, 5)]
    public float gameSpeedRegulator;
    public float speedRate = 0.5f;
    public float maxGameSpeed = 5;
    // Update is called once per frame
    void Update()
    {
        if (gameSpeedRegulator <= maxGameSpeed)
        {
            gameSpeedRegulator += speedRate * Time.deltaTime;
            gameSpeed = gameSpeedRegulator;
        }
    }
}
