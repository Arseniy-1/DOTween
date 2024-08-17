using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;

    private SpriteRenderer _spriteRenderer;
    private float _duration = 10;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(_targetColor, _duration);
    }
}
