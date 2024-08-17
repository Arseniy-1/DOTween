using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private float _duration = 3f;
    private float _targletAngleY = 180;

    private void Start()
    {
        transform.DORotate(new Vector3(0, _targletAngleY, 0), _duration).SetLoops(_repeats, _loopType);
    }
}
