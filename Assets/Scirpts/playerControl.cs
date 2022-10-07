using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControl : MonoBehaviour
{
    public float growthFactor = 300f;
    public int score = 0;
    public float speed;
    public float mapSize = 45.0f;

    public GameObject scoreTextBox;

    public void incrementScore(int scoreGain)
    {
        score += scoreGain;
    }

    private void speedUpate()
    {
        //if (GetComponent<dashScript>().dashState != 1) 
        //    speed = Vector2.Distance(Camera.main.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        speed = 3.0f;
    }

    private void sizeUpdate()
    {
        //transform.localScale = new Vector3(score / growthFactor + 0.25f, score / growthFactor + 0.25f, score / growthFactor + 0.25f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextBox.GetComponent<Text>().text = "Score: " + score.ToString();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(this.gameObject);
        }

        speedUpate();

        sizeUpdate();

        //FOR MOUSE AND FINGER POSITION
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x <= mapSize && mousePos.x >= - mapSize && mousePos.y <= mapSize && mousePos.y >= -mapSize)
            transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), speed * Time.deltaTime);


        //ROTATION
        mousePos = Input.mousePosition;
        mousePos.z = 0;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

    }

}
