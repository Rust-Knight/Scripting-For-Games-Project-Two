using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public int damage;

    public int maxHP;
    public int CurrentHP;

    public bool TakeDamge(int dmg)
    {
        CurrentHP -= dmg;


        if (CurrentHP <= 0)
            return true;
        else
            return false;

    }
    
    public void Heal(int amount)
    {
        CurrentHP += amount;
        if (CurrentHP > maxHP)
            CurrentHP = maxHP;
    }


}
