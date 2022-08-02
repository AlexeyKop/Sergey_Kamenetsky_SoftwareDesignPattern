using CameraState.Interface;
using static System.Console;

namespace CameraState.CameraStates
{
    class FotoState : ICameraState
    {
        public void TakePictures(Camera camera) => WriteLine("Камера уже в режиме фото");
        public void TurnOff(Camera camera)
        {
            WriteLine("Нажата кнопка выключения");
            camera.SetState(new OffState());
        }
        public void ShootVideo(Camera camera)
        {
            WriteLine("Переходим в режим видео");
            camera.SetState(new VideoState());
        }
        public void TurnOn(Camera camera) => WriteLine("Камера уже включена");
    }
}
