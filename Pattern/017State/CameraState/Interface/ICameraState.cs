using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraState.Interface
{
    interface ICameraState
    {
        void TurnOn(Camera camera);
        void TurnOff(Camera camera);
        void TakePictures(Camera camera);
        void ShootVideo(Camera camera);
    }
}
