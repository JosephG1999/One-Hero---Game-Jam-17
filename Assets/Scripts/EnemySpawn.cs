using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Enemies enemy1, enemy2, enemy3, currentEnemy;
    [SerializeField] GameObject EnemySpawnLoaction, MurderFrog, CurrentEnemy;
    [SerializeField] int i = 0;
    void Start()
    {
        GameObject[] prefabEnemies = {MurderFrog};
        CurrentEnemy = prefabEnemies[i];
        Instantiate(CurrentEnemy, transform.position, transform.rotation); //spawns in first enemy

    }

    void Update()
    {

        Enemies[] Enemies = { enemy1, enemy2, enemy3, currentEnemy };
        currentEnemy = Enemies[i];

        if (Input.GetKeyDown("space"))
        {
            i++;
        }
        
    }
}
