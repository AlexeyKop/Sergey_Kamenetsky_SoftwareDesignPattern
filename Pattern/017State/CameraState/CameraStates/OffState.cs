using CameraState.Interface;
using static System.Console;
namespace CameraState.CameraStates
{
    class OffState : ICameraState
    {
        public void TakePictures(Camera camera) => WriteLine("Камера ещё выключена");
        public void TurnOff(Camera camera) => WriteLine("Камера уже выключена");
        public void ShootVideo(Camera camera) => WriteLine("Камера ещё выключена");
        public void TurnOn(Camera camera)
        {
            WriteLine("Нажата кнопка включения");
            camera.SetState(new OnState());
        }
    }
}
