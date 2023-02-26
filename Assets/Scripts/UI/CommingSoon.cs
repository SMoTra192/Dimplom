using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CommingSoon : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField] private Button _button;
    private bool isClicked = false;


    private void Update()
    {
        
        _button.onClick.AddListener(()=>
        {
            if(isClicked == false)StartCoroutine(delay());
        });
    }

    private IEnumerator delay()
    {
        isClicked =  true;
        text.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        isClicked = false;
        text.gameObject.SetActive(false);
    }
}
