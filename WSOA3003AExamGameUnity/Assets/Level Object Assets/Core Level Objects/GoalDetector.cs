﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetector : MonoBehaviour
{
    GameManager GM;

    private void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider Ball)
    {
        if (Ball.gameObject.tag == "TargetBall")
        {
            Destroy(Ball.gameObject);
            GM.Won();
        }
        if (Ball.gameObject.tag == "PowerBall")
        {
            Destroy(Ball.gameObject);
            GM.PowerInGoal();
        }
    }
}
