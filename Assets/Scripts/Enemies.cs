using UnityEditor.Animations;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

[CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/Create new enemy")]
public class Enemies : ScriptableObject
{
    //all of these stats will be used by the enemy prefabs using the getters and setters
    [SerializeField] string title;
    [SerializeField] Weakness weakness1, weakness2, weakness3, weakness4;
    [SerializeField] int numberOfWeaknesses;

    public enum Weakness { None, Slash, Pierce, Bludgeon, Distraction, Sleep }

    public Weakness getWeakness1 { get { return weakness1; } set { weakness1 = value; } }
    public Weakness getWeakness2 { get { return weakness2; } set { weakness2 = value; } }
    public Weakness getWeakness3 { get { return weakness3; } set { weakness3 = value; } }
    public Weakness getWeakness4 { get { return weakness4; } set { weakness4 = value; } }
    public int getNumberOfWeaknesses { get { return numberOfWeaknesses; } set { numberOfWeaknesses = value; } }
    public string getTitle { get { return title; } set { title = value; } }

}
