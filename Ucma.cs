using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ucma : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public GameObject oyuncu;
    Vector3 yenikoord,eskikoord;
    void Start()
    {
        
    }

    IEnumerator ucsaniyebekle()
    {
       
        anim.SetBool("ucma", true);
        yenikoord = new Vector3(transform.position.x, 10f, transform.position.z);
        eskikoord = new Vector3(0,0,0);

        yield return new WaitForSecondsRealtime(3f);
        anim.SetBool("ucma", false);
        transform.position = Vector3.MoveTowards(transform.position, eskikoord, .5f);
    }


    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            StartCoroutine(ucsaniyebekle());
            transform.position = Vector3.MoveTowards(transform.position, yenikoord, .5f);

        }

    }
}
