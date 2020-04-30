﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitForScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WaitForScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
