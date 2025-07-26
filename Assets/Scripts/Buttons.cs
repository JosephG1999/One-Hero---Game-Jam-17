using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject Target, Button, Prefab;
    [SerializeField] GameManager Manager;
    [SerializeField] EnemySpawn EnemySpawn; [SerializeField] Enemies Enemy; //get EnemySpawn script and Enemy script so we can call their functions for weapon interaction
    [SerializeField] Weapons Weapon;
    [SerializeField] Transform Spawn; //get item spawn's position/rotation to use in Instantiate function

    public void weaponSelect() 
    {
        Debug.Log("weapon select");
        Instantiate(Prefab, Spawn.position, Spawn.rotation);
        Manager.enterInventory(); //takes us back to battle screen
        Destroy(Target);
        if (Enemy.getWeakness1.ToString() == Weapon.getCondition || Enemy.getWeakness2.ToString() == Weapon.getCondition) 
        {
            EnemySpawn.Defeat();
        }
    }
}
