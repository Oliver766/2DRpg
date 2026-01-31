using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;

public class Enemy_Combat : MonoBehaviour
{
    public int Damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.ChangeHealth(-Damage);
        }

    }
}
