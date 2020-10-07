using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AssetCreation : MonoBehaviour
{
    public Transform prefab;
    int gameObjectLength = 4;
    public Transform[] cubes;
    int i = 0;
    int randomNumber = 0;
    float speed = 0.5f;

    public GameObject cubesParent;
    
    private void Awake()
    {
         cubesParent = GameObject.FindWithTag("Respawn");
    }
    private void Start()
    {
       
    }
    private void Update()
    {
        StartCoroutine("ChooseRandomElement");
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime; 
    }

    private IEnumerator ChooseRandomElement()
    {
        cubes = new Transform[4];
        while (true)
        {
            randomNumber = UnityEngine.Random.Range(0, 6);
            switch (randomNumber)
            {
                case 0: J(); break;
                case 1: I(); break;
                case 2: L(); break;
                case 3: O(); break;
                case 4: S(); break;
                case 5: T(); break;
                case 6: Z(); break;
                default: Debug.Log("Choice not possible"); break;
            }
            yield return null;
        }
    }
    private void J()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
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

    }
    private void I()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            cubes[i] = prefab;
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

            cubes[i] = prefab;
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
            cubes[i] = prefab;
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
            cubes[i] = prefab;
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
            cubes[i] = prefab;
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
            cubes[i] = prefab;
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
