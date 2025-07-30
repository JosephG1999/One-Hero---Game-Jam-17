using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    [SerializeField] Enemies enemyStats;
    [SerializeField] string enemyName, description;
    [SerializeField] Enemies.Weakness weakness1, weakness2;
    [SerializeField] Tooltip tooltip;
    void Start()
    {
        enemyStats.getTitle = enemyName;
        enemyStats.getWeakness1 = weakness1;
        enemyStats.getWeakness2 = weakness2;
        
    }

    private void Update()
    {
        //OnMouseEnter();
        //OnMouseExit();
    }

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
