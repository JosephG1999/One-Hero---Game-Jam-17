using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class GameManager : MonoBehaviour
{
    /*
    [SerializeField] static GameManager instance;
    [SerializeField] EnemySpawn EnemySpawn;
    [SerializeField] GameObject EnemySpawnLoaction;
    */
    [SerializeField] Camera battleCam, inventoryCam;
    [SerializeField] GameObject nametag, weaponSpawn;

    void Start()
    {
        //GameObject enemySpace = EnemySpawn.GetComponent<GameObject>();
        battleCam.enabled = true; inventoryCam.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.I)) { enterInventory(); }
        Restart();
    }

    public void enterInventory() 
    {
        if (!inventoryCam.enabled)
        {
            battleCam.enabled = false; inventoryCam.enabled = true;
            nametag.SetActive(false);
        }
        else 
        {
            battleCam.enabled = true; inventoryCam.enabled = false;
            nametag.SetActive(true);
        }

    }

    public void Restart() 
    { 
        if (Input.GetKeyDown(KeyCode.R) )
        {
            SceneManager.LoadSceneAsync("mainmenu", LoadSceneMode.Single);
        }  
    }

}
