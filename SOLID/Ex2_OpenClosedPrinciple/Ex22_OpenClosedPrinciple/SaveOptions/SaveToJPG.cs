namespace Ex23_OpenClosedPrinciple.SaveOptions
{
    public class SaveToJPG : ISave
    {
        public void Save(string path, Image image)
        {
            string tempPath = $"{path}.jpg";
            return;
        }
    }
}