using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSpawner : MonoBehaviour
{
    public GameObject[] material = new GameObject[4];
    public float[] xPos = new float[3];
    int[] controller = new int[3];
    public Player p;
    int temp;
    int a = 0;
    int rand;
    int rand2;
    void Start()
    {
        StartCoroutine(spawner());
    }

    
    void Update()
    {
       
    }

    IEnumerator spawner()
    {
        while (!p.isDead)
        {
            rand = Random.Range(0, 4);
            rand2 = Random.Range(0, 3);
            controller[a] = rand2;
            a++;
            while (a == 2)
            {
                if (positionChacker())
                {
                    break;
                } else
                {
                    while (temp == rand2)
                    {
                        Debug.Log("girdi");
                        rand2 = Random.Range(0, 3);
                    }
                    controller[a] = rand2;
                    break;
                }
               
            }
            yield return new WaitForSeconds(1);
            Instantiate(material[rand], new Vector3(xPos[rand2], 1.2f, -10), Quaternion.Euler(0, 180, 0));
        }
    }

    bool positionChacker()
    {
        for (int i = 0; i < controller.Length - 1; i++)
        {
            if (controller[i] != controller[i + 1])
            {
                a = 0;
                return false;
            }
        }
        temp = controller[2];
        a = 0;
        return true;
    }
}

