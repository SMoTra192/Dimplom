using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GiveBoost : MonoBehaviour
{
    [SerializeField] private float boostValue = 1.5f, boostTime;
    public UnityEvent TakenBoost = new();
    

    public float getBoostValue()
    {
        return boostValue;
    }

    public float getTimeforboostout()
    {
        return boostTime;
    }

    public void timeForBoostOut()
    {
        while (boostTime > 0)
        {
            boostTime -= Time.deltaTime;
        }
        
    }
}
