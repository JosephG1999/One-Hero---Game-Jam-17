using UnityEngine;

public class WeaponClass : MonoBehaviour
{
    [SerializeField] Weapons weaponStats;
    [SerializeField] Tooltip tooltip;
    public string weaponName, condition, description;

    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
        tooltip.ShowTooltip(description);
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
        tooltip.HideTooltip();
    }
}
