using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private int _scene;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene().buildIndex;
    }

    public void onClick()
    {
        SceneManager.LoadScene(_scene);
    }
}
