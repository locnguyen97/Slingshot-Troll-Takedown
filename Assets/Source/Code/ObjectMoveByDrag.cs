using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectMoveByDrag : MonoBehaviour
{
    [SerializeField] List<GameObject> particleVFXs;

    private Vector3 startPos;
    private Transform target;

    private void OnEnable()
    {
        startPos = transform.position;
    }
    public void ShowData( int val)
    {
        foreach (Transform tr in transform)
        {
            tr.gameObject.SetActive(false);
        }
        transform.GetChild(val).gameObject.SetActive(true);
    }

    public void CheckOnMouseUp()
    {
        if (target)
        {
            GameObject explosion = Instantiate(particleVFXs[Random.Range(0,particleVFXs.Count)], transform.position, transform.rotation);
            Destroy(explosion, .75f);
            GameManager.Instance.CheckStep();
            Destroy(gameObject);
        }
        else
        {
            transform.position = startPos;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.CompareTag("NotUse")) return;
        if (gameObject.tag == collision.gameObject.tag)
        {
            target = collision.transform;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (transform.CompareTag("NotUse")) return;
        if (gameObject.tag == collision.gameObject.tag)
        {
            target = null;
        }
    }
}