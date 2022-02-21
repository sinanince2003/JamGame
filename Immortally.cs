using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortally : MonoBehaviour
{
    public MaterialSpawner ms;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            StartCoroutine(ucsaniyebekle());
        }
    }

    IEnumerator ucsaniyebekle()
    {
        gameObject.GetComponent<CapsuleCollider>().isTrigger = true;
        yield return new WaitForSecondsRealtime(10);
        gameObject.GetComponent<CapsuleCollider>().isTrigger = false;
    }
}
