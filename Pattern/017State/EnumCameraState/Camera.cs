using System;
using static System.Console;
using static System.Convert;

namespace EnumCameraState
{
    class Camera
    {
        private State state;
        private readonly State endState;

        public Camera()
        {
            state = State.Photo;
            endState = State.PowerOff;
        }

        public void ButtonClick()
        {
            while (state != endState)
            {
                WriteLine($"Текущее состояние {state}");

                var currentState = Scripts.GetItem(state);

                foreach (var item in currentState) WriteLine($"{(int)item.Key} {item.Value}");
                int input = ToInt32(Console.ReadLine());

                var s = Scripts.GetItem(state)[(Selector)input];
                state = s;
            }  
            WriteLine("На этом камера всё");
        }
    }
}