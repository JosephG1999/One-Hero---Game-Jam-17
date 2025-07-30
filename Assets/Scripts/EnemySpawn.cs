using TMPro;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }

    void Update()
    {
        nametag.text = enemyStats.getTitle;

    }

    public void Defeat()
    {
        Debug.Log("Inside Defeat");
        Destroy(CurrentEnemy);
        if (i < 8)
        {
            i++;
        }
        else 
        {
            SceneManager.LoadSceneAsync("endscreen", LoadSceneMode.Single);
        }
        CurrentEnemy = Instantiate(prefabEnemies[i], transform.position, transform.rotation);
    }
}
