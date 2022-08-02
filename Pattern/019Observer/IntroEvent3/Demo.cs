using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEvent3
{
    class Demo
    {
        public int MyProperty { get; set; }
        public event Action MyAction;

        #region ToDo

        private int field;
        public int UserProperty 
        {
            get => field;
            //set => field = value;
        }


        private Action action;
        public event Action UserAction
        {
            add => action += value;
            remove => action -= value;
        }



        #endregion

    }
}
