using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    //public Animator anim;
    //public GameObject oyuncu;
    Vector3 yenikoord, eskikoord;

    IEnumerator ucsaniyebekle()
    {

        //anim.SetBool("ucma", true);
        yenikoord = new Vector3(transform.position.x, 10f, transform.position.z);
        eskikoord = new Vector3(0, 0, 0);
        transform.position = Vector3.MoveTowards(transform.position, yenikoord, .6f);
        yield return new WaitForSecondsRealtime(10f);
        //anim.SetBool("ucma", false);
        transform.position = Vector3.MoveTowards(transform.position, eskikoord, .6f);
    }


    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            StartCoroutine(ucsaniyebekle());
           

        }

    }
}
