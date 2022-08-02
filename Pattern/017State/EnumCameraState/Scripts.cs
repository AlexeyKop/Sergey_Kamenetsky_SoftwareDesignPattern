using System.Collections.Generic;

namespace EnumCameraState
{
    class Scripts
    {
        public static Dictionary<Selector, State> GetItem(State s) => scripts[s];

        private static readonly Dictionary<State, Dictionary<Selector, State>> scripts = new()
         {
             [State.Photo] = new Dictionary<Selector, State>
             {
                  { Selector.ShootVideo, State.Video },
                  { Selector.ShootPortrait, State.Portrait },
                  { Selector.CameraOff, State.PowerOff }
             },

             [State.Video] = new Dictionary<Selector, State>
             {
                  { Selector.ShootSlowMotion, State.SlowMotion },
                  { Selector.TakePhoto, State.Photo },
                  { Selector.CameraOff, State.PowerOff }
             },

             [State.SlowMotion] = new Dictionary<Selector, State>
             {
                  { Selector.ShootVideo, State.Video },
                  { Selector.TakePhoto, State.Photo },
                  { Selector.CameraOff, State.PowerOff },
             },

             [State.Portrait] = new Dictionary<Selector, State>
             {
                  { Selector.TakePhoto, State.Photo },
                  { Selector.CameraOff, State.PowerOff },
             },

             [State.PowerOff] = new Dictionary<Selector, State>
             {
                  { Selector.TakePhoto, State.Photo },
                  { Selector.ShootVideo, State.Video },
                  { Selector.ShootPortrait, State.Portrait },
                  { Selector.ShootSlowMotion, State.SlowMotion },
             },
         };
    }
}