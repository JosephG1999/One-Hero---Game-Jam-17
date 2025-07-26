using TMPro;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject EnemySpawnLoaction, CurrentEnemy;
    [SerializeField] TextMeshProUGUI nametag;
    [SerializeField] Enemies enemyStats;
    [SerializeField] GameObject[] prefabEnemies;
    [SerializeField] int i = 0;
    void Start()
    {
        CurrentEnemy = prefabEnemies[i];
        Instantiate(CurrentEnemy, transform.position, transform.rotation);
        nametag.text = enemyStats.getTitle;
    }

    void Update()
    {

    }

    public void Defeat() 
    {
        i++;
        CurrentEnemy = prefabEnemies[i];
        nametag.text = enemyStats.getTitle;
        Instantiate(CurrentEnemy, transform.position, transform.rotation);
    }
}
