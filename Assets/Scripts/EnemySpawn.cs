using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Enemies enemy1, enemy2, enemy3, currentEnemy;
    [SerializeField] GameObject EnemySpawnLoaction;
    [SerializeField] Sprite enemySprite;
    [SerializeField] SpriteRenderer enemyRenderer;
    [SerializeField] int i = 0;
    void Start()
    {

    }

    void Update()
    {
        Enemies[] Enemies = { enemy1, enemy2, enemy3, currentEnemy };
        currentEnemy = Enemies[i];
        enemyRenderer.sprite = currentEnemy.getSprite;
        if (Input.GetKeyDown("space")) 
        { 
            i++; 
        }
        
    }
}
