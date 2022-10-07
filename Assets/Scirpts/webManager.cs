using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webManager : MonoBehaviour
{

    public GameObject player;

    public void chooseBeeColor(int color)
    {
        switch (color)
        {
            case 0:
                print("Choose Blue");
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/beebluep");
                break;
            case 1:
                print("Choose Green");
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/beegreenp");
                break;
            case 2:
                print("Choose Red");
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/beeredp");
                break;
            case 3:
                print("Choose Yellow");
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/beeyellowp");
                break;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            chooseBeeColor(1);
        }
    }

}
