using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialMove : MonoBehaviour
{
    Player p;
    public float speed;
    void Start()
    {
        p = GetComponent<Player>();
        speed = 15;   
    }

    
    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
        if (transform.position.z <= -90)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
    }
}
