using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skorksayac : MonoBehaviour
{
    public float skor;
    public Text skorText;
     
    // Start is called before the first frame update
    void Start()
    {
        skorText.text = " " + (int)skor;
    }

    // Update is called once per frame
    void Update()
    {
        skor += Time.deltaTime;
        skorText.text = " " + (int)skor;

    }
}
