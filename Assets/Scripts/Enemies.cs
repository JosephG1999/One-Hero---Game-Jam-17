using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/Create new enemy")]
public class Enemies : ScriptableObject
{
     GameObject GO;

    [SerializeField] string title;
    [SerializeField] Weakness weakness1, weakness2, weakness3, weakness4;
    [SerializeField] int numberOfWeaknesses;

    public enum Weakness { None, Slash, Pierce, Bludgeon, Distraction, Sleep }

    public Weakness getWeakness1 {  get { return weakness1; } }
    public Weakness getWeakness2 { get { return weakness2; } }
    public Weakness getWeakness3 { get { return weakness3; } }
    public Weakness getWeakness4 { get { return weakness4; } }
    public int getNumberOfWeaknesses { get { return numberOfWeaknesses; } }
    public string getTitle { get { return title; } }
}
