using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ucma : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    void Start()
    {
       
    }
    IEnumerator ucsaniyebekle()
    {
        anim.SetBool("ucma", true);
        yield return new WaitForSecondsRealtime(3f);
        anim.SetBool("ucma", false);

    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            StartCoroutine(ucsaniyebekle());
        }
    }
}
