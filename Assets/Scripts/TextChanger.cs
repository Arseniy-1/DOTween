using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private float _duration = 10f;
    private Color _targetColor = Color.green;

    private void Start()
    {
        _text.DOText("Привет, хорошего тебе дня!", _duration, true, ScrambleMode.All);
        _text.DOColor(_targetColor, _duration);
    }
}
