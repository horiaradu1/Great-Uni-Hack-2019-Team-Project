using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    public float speed = 3.5f;
    public int damp = 5;

    public GameObject player;
    public GameObject needle;

    public GameObject enemyEngine;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        Vector3 diff = Camera.main.ScreenToWorldPoint(player.transform.position) - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        if (Vector3.Distance(needle.transform.position, transform.position) < 0.5f)
        {
            enemyEngine.GetComponent<enemyEngine>().enemyCounter -= 1;
            Destroy(gameObject);
        }
        else if (Vector3.Distance(player.transform.position, transform.position) < 0.2f)
        {
            Destroy(player.gameObject);
        }
    }
}
