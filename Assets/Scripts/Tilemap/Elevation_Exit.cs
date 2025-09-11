using UnityEngine;

public class Elevation_Exit : MonoBehaviour
{
     public Collider2D[] mountainCollider;
    public Collider2D[] BoundaryCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (Collider2D mountain in mountainCollider)
            {
                mountain.enabled = true;
            }
            foreach (Collider2D boundary in BoundaryCollider)
            {
                boundary.enabled = false;
            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;

        }
    }
}
