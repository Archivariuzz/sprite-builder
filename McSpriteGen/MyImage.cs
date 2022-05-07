using System;
using System.Drawing;


	[Serializable]
	public class ImageData
	{
		Compression cmpr = new Compression();
		
		public int brightness = 128;
		public Boolean R = true;
		public Boolean G = true;
		public Boolean B = true;
		public CompressionType compressionType = CompressionType.None;
		public Size size = new Size(320,240);
		
		
		public Bitmap originalImage;
		public Bitmap changedImage;
		public String name;
		
		public byte[] exportArr;
		
		public ImageData(String name, Bitmap image)
		{
			originalImage = image;
			this.name = name;
			UpdatePicture();
		}
	

		
		
		
		
		//преобразует цветную картинку (changedBMP) в черно-белую
		public void UpdatePicture()
		{			
			changedImage = new Bitmap(originalImage, size); //изменение размера
			
			int w=0,h=0, grayLevel=0, div=0;
			Color c;
			int hmax=size.Height-1;
			int wmax=size.Width;
			
			while(h<hmax)
			{
				if(++w==wmax)
				{
					w=0;
					++h;
				}
				c=changedImage.GetPixel(w,h);
				grayLevel=0;
				div=0;
				if(R) {grayLevel+=c.R; div++;}; //checkBoxR.Checked
				if(G) {grayLevel+=c.G; div++;};
				if(B) {grayLevel+=c.B; div++;};
				if(div!=0) grayLevel/=div;
				grayLevel=(grayLevel>brightness)? 255 : 0;
				c=Color.FromArgb(grayLevel,grayLevel,grayLevel);
				changedImage.SetPixel(w,h,c);
			}
			
			
			exportArr = cmpr.MakeExportArray(changedImage, compressionType);
		}
			
	}
		