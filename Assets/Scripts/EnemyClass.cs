using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    [SerializeField] Enemies enemyStats;
    [SerializeField] string enemyName;
    void Start()
    {
        enemyStats.getTitle = enemyName;
        
    }
    void Update()
    {
        
    }
}
