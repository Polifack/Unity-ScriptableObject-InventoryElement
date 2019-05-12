using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Healing Item", menuName ="GameItem/Healing")]
public class GameItemHealing : GameItem
{
    public int HealthRestored;
    public int ManaRestored; 
}
