using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float scaleDuration = .1f;

    private Vector3 _defaultScale;
    private Tween _currentTween;

    private void Awake()
    {
        _defaultScale = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        _currentTween  = transform.DOScale(_defaultScale * finalScale, scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _currentTween.Kill();
        transform.localScale = _defaultScale;
    }
}
