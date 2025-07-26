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
        CurrentEnemy = Instantiate(prefabEnemies[i], transform.position, transform.rotation);
        nametag.text = enemyStats.getTitle;
    }

    void Update()
    {

    }

    public void Defeat()
    {
        Debug.Log("Inside Defeat");
        Destroy(CurrentEnemy);
        i++;
        CurrentEnemy = Instantiate(prefabEnemies[i], transform.position, transform.rotation);
        nametag.text = enemyStats.getTitle;
    }
}
