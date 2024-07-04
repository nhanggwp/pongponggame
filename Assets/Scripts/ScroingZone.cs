using UnityEngine.EventSystems;
using UnityEngine;

public class ScroingZone : MonoBehaviour
{
  public EventTrigger.TriggerEvent ScoreTrigger;
   private void OnCollisionEnter2D(Collision2D collision){
    Ball ball=collision.gameObject.GetComponent<Ball>();
    if(ball!=null){
        BaseEventData eventData=new BaseEventData(EventSystem.current);
        this.ScoreTrigger.Invoke(eventData);
    }
    }
}
