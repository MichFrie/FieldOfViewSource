﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetCreation : MonoBehaviour
{
    public Transform prefab;
    int gameObjectLength = 4;
    public Transform[] cubes;
    int i = 0;
    private void Awake()
    {
        cubes = new Transform[4];
        while (i < gameObjectLength)
        {
            //J();
            //I();
            //L();
        }
    }

    private void J()
    {
        Transform prefabPosition = Instantiate(prefab);
        cubes[i] = prefab;
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
    private void I()
    {
        Transform prefabPosition = Instantiate(prefab);
        cubes[i] = prefab;
        prefabPosition.localPosition = (Vector3.right * i);
        prefabPosition.localScale = Vector3.one / 1.05f;
        i++;
    }

    private void L()
    {
        Transform prefabPosition = Instantiate(prefab);
        cubes[i] = prefab;
        prefabPosition.localPosition = (Vector3.right * i);
        if(i == 3)
        {
            prefabPosition.localPosition = (Vector3.right * (i - 1)) + (Vector3.forward * (i - 2));
        }
        prefabPosition.localScale = Vector3.one / 1.05f;
        i++;
    }
}
