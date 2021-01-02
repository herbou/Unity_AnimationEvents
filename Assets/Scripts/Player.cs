using UnityEngine ;

public class Player : MonoBehaviour {

   [SerializeField] private AnimationClip clip ;
   [SerializeField] private float eventTime ;
   

   private void Start () {
      clip.AddAnimationEvent (eventTime, "EventFunction") ;
   }

   private void EventFunction () {
      Debug.Log ("Event fired") ;
   }

}
