using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private float _duration = 3f;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration).SetLoops(_repeats, _loopType);
    }
}
