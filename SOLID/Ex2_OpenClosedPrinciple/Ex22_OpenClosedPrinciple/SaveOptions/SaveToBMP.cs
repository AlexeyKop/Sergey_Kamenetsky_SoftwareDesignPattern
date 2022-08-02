namespace Ex23_OpenClosedPrinciple.SaveOptions
{
    public class SaveToBMP : ISave
    {
        public void Save(string path, Image image)
        {
            string tempPath = $"{path}.bmp";
            return;
        }
    }
}