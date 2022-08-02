using ImageFileView.Helper;

namespace ImageFileView.Proxy
{
    class ProxyPaint : Drawing
    {
        Paint realImg;

        public ProxyPaint(string fileName)
        {
            base.imgPath = fileName;

            Img = DefaultImage.Source;
        }

        public override void Init()
        {
            if (realImg == null) realImg = new Paint(imgPath);
            realImg.Init();
            Img = realImg.Img;
        }
    }
}
