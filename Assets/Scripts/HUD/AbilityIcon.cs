using UnityEngine;
using UnityEngine.UI;

public class AbilityIcon : MonoBehaviour
{
    [SerializeField] private Image iconImage;

    void Awake()
    {
        if (!iconImage)
            iconImage = GetComponent<Image>();
    }

    public void SetAvailable(bool available)
    {
        Color colour = iconImage.color;
        colour.a = available ? 1f : 0.35f;
        iconImage.color = colour;
    }
}