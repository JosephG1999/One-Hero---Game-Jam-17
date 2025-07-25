using TMPro;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject EnemySpawnLoaction, MurderFrog, CurrentEnemy;
    [SerializeField] TextMeshProUGUI nametag;
    [SerializeField] Enemies enemyStats;
    [SerializeField] int i = 0;
    void Start()
    {
        GameObject[] prefabEnemies = {MurderFrog};
        CurrentEnemy = prefabEnemies[i];
        Instantiate(CurrentEnemy, transform.position, transform.rotation); //spawns in first enemy

    }

    void Update()
    {
        nametag.text = enemyStats.getTitle;

        if (Input.GetKeyDown("space")) { i++; }
        
    }
}
