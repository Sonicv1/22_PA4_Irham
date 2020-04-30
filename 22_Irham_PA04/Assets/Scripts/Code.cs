using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private Vector3 dudu = new Vector3(-0.094f, 0.157f, -4.909f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(dudu, Vector3.up, 500);
    }
}
