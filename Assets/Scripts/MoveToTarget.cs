using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;

    void Update()
    {
        transform.position = _target.position;
        transform.rotation = _target.rotation;
    }
}
