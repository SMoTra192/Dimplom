using UnityEngine;
using UnityEngine.Events;

public class GiveTime : MonoBehaviour
{
    [SerializeField] private float timeValue = 15f;
    public UnityEvent timePicked = new();

    public float getTimeValue()
    {
        return timeValue;
    }
}
