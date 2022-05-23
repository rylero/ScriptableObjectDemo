using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="cardData", menuName ="Card Data", order = 1)]
public class CardData : ScriptableObject
{
    public Sprite img;
    public string name;
    public int hp;
}
