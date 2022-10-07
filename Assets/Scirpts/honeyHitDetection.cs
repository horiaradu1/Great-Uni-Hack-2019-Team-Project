using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class honeyHitDetection : MonoBehaviour
{
    public GameObject player;
    public GameObject honeyEngine;

    public float posX;
    public float posY;
    public int score;

    private float minDist = 1f;

    private void Start()
    {

    }

    private void Update()
    {
        float dist = Vector3.Distance(this.transform.position, player.transform.position);
        if (dist < minDist)
        { 
            player.GetComponent<playerControl>().incrementScore(score);
            honeyEngine.GetComponent<honeyEngine>().CreateRandomHoney();
            Destroy(gameObject);
        }
    }

    public void assignValues(honeyBlob blob)
    {
        posX = blob.posX;
        posY = blob.posY;
        score = blob.score;

        this.transform.Translate(new Vector3(posX, posY, 0));
        this.transform.localScale = new Vector3(score * 2, score * 2, score * 2);
    }

}
