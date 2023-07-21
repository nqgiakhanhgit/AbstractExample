using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWeapon :MonoBehaviour
{
    public string weaponName;
    public int damage;

    public abstract void Attack(); // Abstract method - must be implemented by derived classes

    public void Swing()
    {
        Debug.Log(weaponName + " swings, causing " + damage + " damage!");
    }
}
