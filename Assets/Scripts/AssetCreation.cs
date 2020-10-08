﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AssetCreation : MonoBehaviour
{
    public Transform[] cubes;
    public Transform prefab;
    public float xRotation;
    
    int gameObjectLength = 4;
    int i = 0;
    
    float speed = 0.5f;
    float xRot, yRot, zRot;

    public GameObject cubesParent;
    
    private void Awake()
    {
         cubesParent = GameObject.FindWithTag("Respawn");
    }
    private void Start()
    {
       InvokeRepeating("ChooseRandomElement", 0f, 2f);
    }
    private void Update()
    {
        GameObjectMovement();
    }

    private void GameObjectMovement()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.CompareTag("Sphere"))
        {
            xRot += 90;
            transform.eulerAngles = new Vector3(xRot, 0, 0);
            other.gameObject.SetActive(false);
        }
    }

    private void ChooseRandomElement()
    {
        var randomNumber = UnityEngine.Random.Range(0,0);
        switch (randomNumber)
        {
            case 0: J(); break;
            case 1: I(); break;
            case 2: L(); break;
            case 3: O(); break;
            case 4: S(); break;
            case 5: T(); break;
            case 6: Z(); break;
            default: Debug.Log("invalid case"); break;
        }
        Debug.Log(randomNumber);
    }
    private void J()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            if (i == 0)
            {
                prefabPosition.localPosition = Vector3.right * i;
            }
            else if (i == 1)
            {
                prefabPosition.localPosition = Vector3.forward * i;
            }
            else
            {
                prefabPosition.localPosition = Vector3.right * (i - 1);
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }

    }
    private void I()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            prefabPosition.localPosition = (Vector3.right * i);
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
    }

    private void L()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);

            //cubes[i] = prefab;
            prefabPosition.localPosition = (Vector3.right * i);
            if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.right * (i - 1)) + (Vector3.forward * (i - 2));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
    }
    private void O()
    {
        while (i < 4)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            if (i == 0)
            {
                prefabPosition.localPosition = Vector3.right * i;
            }
            else if (i == 1)
            {
                prefabPosition.localPosition = Vector3.forward * i;
            }
            else if (i == 2)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 1)) + (Vector3.right * (i - 1));
            }
            else
            {
                prefabPosition.localPosition = (Vector3.right * (i - 2));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }

    }
    void S()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            prefabPosition.localPosition = Vector3.right * i;
            if (i == 2)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 1)) + (Vector3.right * (i - 1));
            }
            else if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 2) + Vector3.right * (i - 1));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }

    }

    private void T()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            prefabPosition.localPosition = Vector3.right * i;
            if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 2) + Vector3.right * (i - 2));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }

    }
    private void Z()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            if (i == 0)
            {
                prefabPosition.localPosition = Vector3.forward * (i + 1);
            }
            else if (i == 1)
            {
                prefabPosition.localPosition = (Vector3.forward * i + Vector3.right * i);
            }
            else if (i == 2)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 2) + Vector3.right * (i - 1));
            }
            else if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 3) + Vector3.right * (i - 1));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
    }
}
