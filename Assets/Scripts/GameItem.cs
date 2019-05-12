using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "GameItem/GameItem")]
public class GameItem : ScriptableObject
{
    public string Name;
    public bool Usable;
    public bool Equipable;
    public int Value;
    public Sprite Icon;
}
