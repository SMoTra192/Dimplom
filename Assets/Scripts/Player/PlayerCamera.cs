using UnityEngine;
public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset = new Vector3(0, -10, 0);
    [SerializeField] private float _smooth = 1f;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.transform.position + _offset, _smooth);
    }
}
