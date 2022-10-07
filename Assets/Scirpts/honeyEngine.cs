using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class honeyEngine : MonoBehaviour
{
    public int targetNumber = 100;
    public float maxDif = 40.0f;

    public GameObject honeyReference;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < 99; ++ i)
        {
            CreateRandomHoney();
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateRandomHoney()
    {
        honeyBlob newBlob = new honeyBlob();
        newBlob.posX = Random.Range(-maxDif, maxDif);
        newBlob.posY = Random.Range(-maxDif, maxDif);
        newBlob.score = 1;
        CreateHoneyBlob(newBlob);
    }

    public void CreateHoneyBlob(honeyBlob newBlob)
    {
        GameObject honeyBlobInstance = Instantiate(honeyReference, this.transform);
        honeyBlobInstance.GetComponent<honeyHitDetection>().assignValues(newBlob);
        honeyBlobInstance.SetActive(true);
    }

}
