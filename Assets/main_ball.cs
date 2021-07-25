using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("스페이스 키 누르고 있음");
            Vector3 vector = new Vector3(0, 0.0001f, 0);
            transform.Translate(vector);
        }

    }
}
