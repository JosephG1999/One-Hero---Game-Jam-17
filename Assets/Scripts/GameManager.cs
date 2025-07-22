using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] static GameManager instance;
    [SerializeField] EnemySpawn EnemySpawn;
    [SerializeField] GameObject EnemySpawnLoaction;
    void Start()
    {
        GameObject enemySpace = EnemySpawn.GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
