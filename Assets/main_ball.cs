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
        Vector3 v = new Vector3(0, 0.01f, 0);
        transform.Translate(v);
    }
}
