using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _targetScale;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private float _duration = 3f;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration).SetLoops(_repeats, _loopType);
    }
}
