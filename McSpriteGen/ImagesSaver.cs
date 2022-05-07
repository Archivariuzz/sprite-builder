using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;




	public class ImagesSaver
	{
						
		public void SaveToFile(string fileName, List<ImageData> imageList)
		{					
	/*		FileStream fo=File.OpenWrite(fileName);
			if(fo.CanWrite) 
			{
				byte[] imgArray=makeBinaryArray(imageList[imageIndex].changedImage);
				
				switch(imageList[imageIndex].compressionType)
				{
					case CompressionType.RLE_Horisontal :
						byte[] outp=RLECompressionHorisontal(imgArray);
						fo.Write(outp,0,outp.Length);
						break;
						
					case CompressionType.Uncompressed :
						fo.Write(imgArray,0,imgArray.Length);
						break;
				}
			
			}
			fo.Close();
			//changedBMP.Save("BYBMP.bmp");*/
		}
		
		
		
				
		
		public void SaveAsCPPHeader(string fileName, List<ImageData> imageList)
		{
			string fname=Path.GetFileNameWithoutExtension(fileName).ToUpper();
			var sw=new StreamWriter(fileName);
			
				foreach(ImageData iData in imageList)
			{
			
			sw.WriteLine("#ifndef _"+iData.name+"_H_");
			sw.WriteLine("#define _"+iData.name+"_H_");
			sw.WriteLine("#define "+iData.name+"_LENGHT "+iData.exportArr.Length+"\n");
			sw.WriteLine("//Image size: "+ iData.changedImage.Width +"x"+iData.changedImage.Height);
			sw.WriteLine("const unsigned char "+iData.name.ToLower()+"["+iData.exportArr.Length+"] PROGMEM = {");
			
			int cnt=1;
			string line=String.Format("  0x{0:X}",iData.exportArr[0]);
			for(int a=1; a<iData.exportArr.Length ;a++) 
			{
				if(cnt++ == 16) 
				{
					cnt=1; 
					sw.WriteLine(line);
					line="";
				}
				line+=String.Format(", 0x{0:X}",iData.exportArr[a]);
				
			}
			
			sw.WriteLine(line+"};");
			sw.WriteLine("#endif    /* _"+fname+"_H_ */ \n\n");
			
			}
			sw.Close();
		}
	}
