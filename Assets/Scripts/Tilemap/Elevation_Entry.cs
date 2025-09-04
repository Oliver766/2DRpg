using UnityEngine;

public class Elevation_Entry : MonoBehaviour
{
    public Collider2D[] mountainCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (Collider2D mountain in mountainCollider)
            {
                mountain.enabled = false;
            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;

        }
    }
}
