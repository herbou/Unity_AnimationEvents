using UnityEngine ;

public static class AnimationEventsExtension {
   /// <summary>
   /// Add animation events to a clip at a given time.
   /// </summary>
   /// <param name="clip">Animation Clip.</param>
   /// <param name="time">Time in Seconds.</param>
   /// <param name="functionName">Function Name.</param>
   public static void AddAnimationEvent (this AnimationClip clip, float time, string functionName) {
      float clipDuration = clip.length ;

      if (time < 0f) {
         Debug.LogError ("Event time must be greater >= than <b><color=white>0.0</color>f</b> seconds") ;
         return ;

      } else if (time > clipDuration) {
         Debug.LogError ("Event time must be less <= than the clip's duration: <b><color=white>" + clipDuration + "</color>f</b> seconds") ;
         return ;
      }

      AnimationEvent animationEvent = new AnimationEvent {
         time = time,
         functionName = functionName
      } ;

      clip.AddEvent (animationEvent) ;
   }
}
