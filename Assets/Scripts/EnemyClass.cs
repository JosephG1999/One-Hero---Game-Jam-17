using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    [SerializeField] Enemies enemyStats;
    [SerializeField] string enemyName;
    [SerializeField] Enemies.Weakness weakness1, weakness2;
    void Start()
    {
        enemyStats.getTitle = enemyName;
        enemyStats.getWeakness1 = weakness1;
        enemyStats.getWeakness2 = weakness2;
        
    }
    void Update()
    {
        
    }
}
