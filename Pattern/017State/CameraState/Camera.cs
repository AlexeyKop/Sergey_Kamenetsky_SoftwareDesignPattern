using CameraState.CameraStates;
using CameraState.Interface;

namespace CameraState
{
    class Camera
    {
        ICameraState state;
        public Camera() => this.state = new OffState();
        public void SetState(ICameraState state) => this.state = state;
        public void TakePhoto() => state.TakePictures(this);
        public void TurnOff() => state.TurnOff(this);
        public void TurnOn() => state.TurnOn(this);
        public void RecordVideo() => state.ShootVideo(this);
    }
}