using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParaGuage : MonoBehaviour
{
    //public Text healthText;
    public Image healthBar;
    public Image[] healthPoints;

    float health, maxHealth = 100;

    //float lerpSpeed;


    public void Start()
    {
        health = 40;
    }

    public void Update()
    {
        //healthText.text = "Health: " + health + "%";
        if (health > maxHealth) health = maxHealth;

        //lerpSpeed = 3f * Time.deltaTime;

        HealthBarFiller();
        //ColorChanger();
    }

    void HealthBarFiller()
    {
        //healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, health / maxHealth, lerpSpeed);

        for (int i = 0; i < healthPoints.Length; i++)
        {
            healthPoints[i].enabled = !DisplayHealthPoint(health, i);
        }
    }

    //void ColorChanger()
    //{
    //    Color healthColor = Color.Lerp(Color.red, Color.green, (health / maxHealth));

    //    healthBar.color = healthColor;
    //}

    bool DisplayHealthPoint(float _health, int pointNumber)
    {
        return ((pointNumber * 10) >= _health);
    }

    public void Damage(float damagePoints)
    {
        if (health > 0)
            health -= damagePoints;
    }

    public void Heal(float healingPoints)
    {
        if (health < maxHealth)
            health += healingPoints;
    }

}
