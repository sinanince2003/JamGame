using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ölümsüzlük : MonoBehaviour
{

    void Start()
    {
    }
    IEnumerator ucsaniyebekle()
    {
        GetComponent<BoxCollider>().isTrigger = true;
        yield return new WaitForSecondsRealtime(3f);
        GetComponent<BoxCollider>().isTrigger = false;
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            StartCoroutine(ucsaniyebekle());
        }
    }

}
