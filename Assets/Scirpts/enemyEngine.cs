using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyEngine : MonoBehaviour
{
    public int enemyCounter = 0;
    public float mapSize = 45.0f;
    public int enemyGoal = 2;

    public GameObject enemyReference;

    private Vector3[] spawnPoints;

    void Start()
    {
        spawnPoints = new Vector3[50];
           spawnPoints = new Vector3((23.0f, 35.0f, 0),(13.0f, -20.0f, 0),(-34.0f, -35.0f, 0),(35.0f, 35.0f, 0),(5.0f, 3.0f, 0),(-10.0f, 2.0f, 0),(-9f, 7.0f, 0),(-27f, 42f, 0),  (-13f, -13f, 0),  (-7f, 7.0f, 0),  (19f, 3.0f, 0),  (39f, -23f, 0),  (35f, 32f, 0));
}

void Update()
    {
        if (enemyCounter == 0)
        {
            replenishEnemys(enemyGoal);
            enemyGoal *= 2;
        }
    }

    void replenishEnemys(int number)
    {
        for (var i = 0; i < number; ++ i)
        {
            createEnemy();
        }
    }

    void createEnemy()
    {
        int negative;

        float posX, posY;
        posX=
        posY=
       

        GameObject enemyInstance = Instantiate(enemyReference, transform);
        enemyInstance.transform.position = new Vector3(posX, posY);
        enemyInstance.SetActive(true);
        enemyCounter += 1;
    }


}
