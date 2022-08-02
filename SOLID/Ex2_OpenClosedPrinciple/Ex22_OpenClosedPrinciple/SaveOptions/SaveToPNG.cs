namespace Ex23_OpenClosedPrinciple.SaveOptions
{
    public class SaveToPNG : ISave
    {
        public void Save(string path, Image image)
        {
            string tempPath = $"{path}.png";
            return;
        }
    }
}