using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IDamageable
{
    [SerializeField] private int health;
    public AbstractWeapon equippedWeapon;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Player takes " + amount + " damage. Health: " + health);
    }
    public void AttackWithEquippedWeapon()
    {
        if (equippedWeapon != null) // Check if equippedWeapon is not null before using it
        {
            equippedWeapon.Attack();
        }
        else
        {
            Debug.Log("No weapon equipped!");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttackWithEquippedWeapon();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        AbstractWeapon newWeapon = collision.gameObject.GetComponent<AbstractWeapon>();
        if (newWeapon != null)
        {
            equippedWeapon = newWeapon;
            Debug.Log("Equipped new weapon: " + equippedWeapon.weaponName);
        }
    }
  }

