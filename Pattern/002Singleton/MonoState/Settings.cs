namespace MonoState
{
    //class Settings
    //{
    //    public int Colums { get; set; }
    //    public int Rows { get; set; }
    //}


    class Settings
    {

        private static int columns;
        private static int rows;


        public int Columns
        {
            get => columns;
            set => columns = value;
        }

        public int Rows
        {
            get => rows;
            set => rows = value;
        }
    }
}


