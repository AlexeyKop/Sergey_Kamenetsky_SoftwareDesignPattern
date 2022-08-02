

namespace CameraState
{
    class Program
    {
        static void Main()
        {

            // Видео https://youtu.be/oraxX9MTliQ

            var camera = new Camera();

            camera.TurnOn(); // Нажата кнопка включения
            camera.RecordVideo(); // Переходим в режим видео
            camera.TurnOff(); // Выключение камеры
            camera.RecordVideo(); // Камера ещё выключена
            camera.TakePhoto(); // Камера ещё выключена
            camera.TakePhoto(); // Камера ещё выключена
            camera.TurnOff(); // Камера ещё выключена
            camera.TurnOff(); // Камера ещё выключена
            camera.TurnOn(); // Нажата кнопка включения
            camera.RecordVideo(); // Переходим в режим видео
            camera.TakePhoto(); // Переходим в режим фото
        }
    }
}