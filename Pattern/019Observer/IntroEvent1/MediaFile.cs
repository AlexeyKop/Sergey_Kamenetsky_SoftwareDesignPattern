namespace IntroEvent1
{
    // Есть сущность порождающая события
    // Есть сущности, которые хотят получать уведомления об этих событиях
    class MediaFile 
    {
        public MediaFile(string fileName) => FileName = fileName;
        public string FileName { get; set; }
    }
}
