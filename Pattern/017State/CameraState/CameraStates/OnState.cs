using CameraState.Interface;
using static System.Console;
namespace CameraState.CameraStates
{
    class OnState : ICameraState
    {
        public void TakePictures(Camera camera)
        {
            WriteLine("Переходим в режим фото");
            camera.SetState(new FotoState());
        }
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
