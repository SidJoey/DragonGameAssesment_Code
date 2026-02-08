using UnityEngine;
using UnityEngine.UI;

public class HUDHealthBar : MonoBehaviour
{
    [SerializeField] private Image fillImage;
    [SerializeField] private Health targetHealth;

    void Update()
    {
        if (!targetHealth) return;

        fillImage.fillAmount =
            targetHealth.currentHealth / targetHealth.maxHealth;
    }
}