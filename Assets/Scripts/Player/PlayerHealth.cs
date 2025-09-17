using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public Animator healthtextanim;
    public TextMeshProUGUI healthText;

    void Start()
    {
        healthText.text = "HP:" + currentHealth + "/" + maxHealth.ToString();
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthtextanim.Play("HealthUI");
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            // player dead
        }
    }

    void Update()
    {
        healthText.text = "HP:" + currentHealth + "/" + maxHealth.ToString();
    }
}
