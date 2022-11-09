using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    //public Text nameTxT;
    public Text leveltxt;
    public Slider hpSlider;
    public int setHealth;
    
    // added 
    public Gradient gradient;
    public Image fill;



    public void SetHUD(Unit unit)
    {
        //nameTxT.text = unit.unitName;
        leveltxt.text = "Lvl: " + unit.unitLevel;
        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.CurrentHP;

        // added
        fill.color = gradient.Evaluate(1f);

    }

    public void SetHP(int hp)
    {
        hpSlider.value = hp;
        
        
    }

    //added
    public void SetHealth(int health)
    {
        hpSlider.value = health;

        fill.color = gradient.Evaluate(hpSlider.normalizedValue);
    }
}
