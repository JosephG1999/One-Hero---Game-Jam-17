using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Enemies enemy1, enemy2, enemy3, currentEnemy;
    [SerializeField] GameObject EnemySpawnLoaction;
    [SerializeField] Sprite enemySprite;
    [SerializeField] SpriteRenderer enemyRenderer;
    [SerializeField] int i = 0;
    Animator animator;
    void Start()
    {

    }

    void Update()
    {
        animator = GetComponent<Animator>();
        Enemies[] Enemies = { enemy1, enemy2, enemy3, currentEnemy };
        currentEnemy = Enemies[i];
        enemyRenderer.sprite = currentEnemy.getSprite;
        i = 2;
        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("Dead");
        }
        
    }
}
