using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeniucma : MonoBehaviour
{
    [SerializeField] private Vector3 endPosition;
    [SerializeField] private float Speed;
    [SerializeField] private bool goToPosition;
    public Animator anim;
    private bool sorgu=false;
    IEnumerator ucsaniyebekle()
    {

        anim.SetBool("ucma",true);
        anim.SetBool("kosma", false);
        endPosition = new Vector3(transform.position.x, 0, transform.position.z);
        yield return new WaitForSecondsRealtime(3f);
        goToPosition = false;
        this.transform.position = Vector3.Lerp(this.transform.position, endPosition, Speed * Time.deltaTime);
        anim.SetBool("kosma", true);
        anim.SetBool("ucma", false);
    }

    private void Start()
    {
        anim.SetBool("kosma", true);
        anim.SetBool("ucma", false);
    }

    void Update()
    {
        if (goToPosition==false)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                goToPosition = true;
            }
        }
        
       

        if (goToPosition)
        {
            endPosition = new Vector3(transform.position.x, 5, transform.position.z);
            this.transform.position = Vector3.Lerp(this.transform.position, endPosition, Speed * Time.deltaTime);
            StartCoroutine(ucsaniyebekle());

        }
        
    }
}
