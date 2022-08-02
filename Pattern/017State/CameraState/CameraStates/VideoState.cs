using CameraState.Interface;
using static System.Console;

namespace CameraState.CameraStates
{

    class VideoState : ICameraState
    {
        public void TakePictures(Camera camera)
        {
            WriteLine("Переходим в режим фото");
            camera.SetState(new FotoState());
        }
        public void TurnOff(Camera camera)
        {
            WriteLine("Выключение камеры");
            camera.SetState(new OffState());
        }
        public void ShootVideo(Camera camera) => WriteLine("Камера уже в режиме видео");
        public void TurnOn(Camera camera) => WriteLine("Камера уже включена");
    }
}
