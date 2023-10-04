using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTaget : MonoBehaviour
{
    private int id = 0;

    public void ShowDone(int i)
    {
        transform.GetChild(i).gameObject.SetActive(true);
        transform.GetChild(i).GetComponent<SpriteRenderer>().enabled = true;
        transform.GetChild(i).GetChild(0).gameObject.SetActive(false);
    }
    public void ShowBoxCollier()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        gameObject.tag = "b1";
    }

    public void RandomValue()
    {
        foreach (Transform tr in transform)
        {
            tr.gameObject.SetActive(false);
        }
        id = Random.Range(0, 3);
        GetComponent<BoxCollider2D>().enabled = false;
        gameObject.tag = "NotUse";
        transform.GetChild(id).gameObject.SetActive(true);
        transform.GetChild(id).GetComponent<SpriteRenderer>().enabled = true;
        transform.GetChild(id).GetChild(0).gameObject.SetActive(false);
    }

    public void ShowUse( int i)
    {
        foreach (Transform tr in transform)
        {
            tr.gameObject.SetActive(false);
        }
        id = i;
        transform.GetChild(id).gameObject.SetActive(true);
        transform.GetChild(id).GetComponent<SpriteRenderer>().enabled = false;
        transform.GetChild(id).GetChild(0).gameObject.SetActive(true);
    }
}
