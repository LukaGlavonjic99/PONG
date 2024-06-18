using UnityEngine;
using UnityEngine.EventSystems;

public class ZonaPogodaka : MonoBehaviour

   
{
    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Lopta ball = collision.gameObject.GetComponent<Lopta>();

        if (ball != null)
        {
            BaseEventData eventData =new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }


    }
}
