using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucmakodenyeni : MonoBehaviour
{
    public Vector3 yerkoordinat, ustkoordinat;
    private bool basildimi;
    public Animator anim;

    void Start()
    {
        yerkoordinat= new Vector3(transform.position.x, 0, transform.position.z);
        ustkoordinat = new Vector3(transform.position.x, 5, transform.position.z);
        anim.SetBool("ucma", false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            basildimi = true;
        }

        while (basildimi == true) 
        {
            anim.SetBool("ucma", true);
            transform.position = Vector3.Lerp(transform.position, ustkoordinat, 3f * Time.deltaTime);
            StartCoroutine(ucsaniyebekle());
            break;
        }

        //  anim.SetBool("ucma", false);


    }


    IEnumerator ucsaniyebekle()
    {
        yield return new WaitForSecondsRealtime(3f);
        anim.SetBool("ucma", false);
        transform.position = Vector3.Lerp(transform.position, yerkoordinat, 3f * Time.deltaTime);
        basildimi = false;

    }






}
