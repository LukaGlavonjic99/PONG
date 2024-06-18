
using UnityEngine;
using UnityEngine.EventSystems;

public class OdbitakOIvice : MonoBehaviour
{

    public float bounceStrength;
    


    public void OnCollisionEnter2D(Collision2D collision)
    {
        Lopta ball= collision.gameObject.GetComponent<Lopta>();

        if(ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }

    }
}
