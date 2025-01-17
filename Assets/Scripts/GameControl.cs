﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [Header("Prefabs")]
    [SerializeField]
    private GameObject blower;
    [SerializeField]
    private GameObject human;
    public Transform prefab;

    private GameObject tempBlower;
    float x;
    float y;
    float z;
    Vector3 pos;

    private void Awake()
    {


      for (int i = 0; i < 10; i++)
        {
            //Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }

      x = Random.Range(-5, 5);
      y = Random.Range(-5, 5);
      z = 5 ;
        Physics.gravity = new Vector3(0, -2, 0);
        pos = new Vector3(x, y, z);
        //GameObject.FindGameObjectWithTag ("Star").transform.position = pos;
        StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        while(true)
        {
            Vector3 instPoint = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Screen.width, 0));
            GameObject throwable = Instantiate(human, instPoint, Quaternion.identity);
            throwable.transform.position = new Vector3(throwable.transform.position.x, throwable.transform.position.y, 0);
            yield return new WaitForSeconds(5);
        }
    }



    public void OnPointerDown(PointerEventData data)
    {
        Vector3 instPoint = Camera.main.ScreenToWorldPoint(new Vector3(data.position.x, data.position.y, 0));

        tempBlower = Instantiate(blower, instPoint, Quaternion.identity);
        tempBlower.transform.position = new Vector3(tempBlower.transform.position.x, tempBlower.transform.position.y, 0);
    }

    public void OnPointerUp (PointerEventData data)
    {
        Destroy(tempBlower);
    }

}
