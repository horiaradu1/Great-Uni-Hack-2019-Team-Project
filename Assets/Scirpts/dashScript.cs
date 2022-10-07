using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashScript : MonoBehaviour
{
    public int dashState;
    public float dashTimer;
    public float maxDash = 2.0f;

    public GameObject player;

    void Update()
    {
        switch (dashState)
        {
            case 0: // Ready
                var isDashKeyDown = Input.GetKeyDown(KeyCode.Space);
                bool enoughScore = player.GetComponent<playerControl>().score >= 10;
                if (isDashKeyDown && enoughScore)
                {
                    player.GetComponent<playerControl>().speed = 10f;
                    player.GetComponent<playerControl>().score -= 10;
                    dashState = 1; 
                }
                break;
            case 1: // Dashing
                dashTimer += Time.deltaTime * 3;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    dashState = 2;
                }
                break;
            case 2: // Cooldown
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = 0;
                }
                break;
        }
    }

}

