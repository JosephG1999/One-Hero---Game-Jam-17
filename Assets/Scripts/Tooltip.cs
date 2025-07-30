using TMPro;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    [SerializeField] GameObject tooltip;
    [SerializeField] TextMeshProUGUI message;
    void Start()
    {
        tooltip.SetActive(false);
    }

    public void ShowTooltip(string description) 
    {
        tooltip.SetActive(true);
        message.text = description;
    }

    public void HideTooltip() 
    {
        tooltip.SetActive(false);
    }
}
