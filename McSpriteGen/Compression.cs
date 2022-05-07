using System;
using System.Collections.Generic;
using System.Drawing;

public enum CompressionType
{
    RLE_Vertical,
    RLE_Horisontal,
    None
};

[Serializable]
public class Compression
	{

	

	public byte[] MakeExportArray(Bitmap bmp, CompressionType compressionType)
	{
		
		Byte [] arr;
		switch (compressionType)
		{
				case CompressionType.None : 
					arr = makeBinaryArray(bmp);
					break;
				case CompressionType.RLE_Horisontal :
					arr = RLECompressionHorisontal(makeBinaryArray(bmp));
					break;
				case CompressionType.RLE_Vertical :
					arr = RLECompressionVertical(makeBinaryArray(bmp), bmp.Width, bmp.Height);
					break;
				default : 
					arr = null;
					break;
		}
		return arr;
	}
	

		
	byte[] RLECompressionVertical(byte [] imgArray, int x, int y)
	{
		int xBytes = x/8;
		int cnt = xBytes+1;
		var output=new List<byte>();
		var buf=new byte[255];
		byte a;
		
		while(cnt < imgArray.Length)
		{
			a=0;
			while(imgArray[cnt]==imgArray[cnt-xBytes]) 
			{
				a++;
				cnt++;
			}
			output.Add(a);
			a=0;
			while(imgArray[cnt] != imgArray[cnt-xBytes])
			{
				a++;
				cnt++;
				buf[a]=imgArray[cnt];
			}
			for(int b=0 ; b < a ; b++) output.Add(buf[b]);
			a=0;
		}
		
		return imgArray; 
	}
	
	

		
				
		//make binary picture from Bitmap 
		byte[] makeBinaryArray(Bitmap changedBMP)
		{
			byte pixel=0;
			int w=0,h=0, arrayCounter=0, bitCounter=0;
			int wmax=changedBMP.Width-1; //width in bytes
			int hmax=changedBMP.Height-1;			
			var imgArray=new byte[(wmax+1)*(hmax+1)/8];
			
			while(h<hmax)
			{			
				if(w>wmax)
				{
					w=0;
					h++;
				}				
				
				pixel = (byte) ((changedBMP.GetPixel(w,h).R > 128) ? 0 : 1);
				imgArray[arrayCounter]=Convert.ToByte((imgArray[arrayCounter]<<1) + pixel);	
				w++;
				
				if(bitCounter++ == 7)
				{
					bitCounter=0;
					imgArray[++arrayCounter]=0;
				}

			}		
			return imgArray;
		}
		
		
		
		
		
		byte[] RLECompressionHorisontal(byte [] imgArray)
		{ 
			var buf=new byte[255];
			byte cnt=0;
			int arrayCounter=0;
			var output=new List<byte>();
			
			buf[0]=imgArray[0];
			while(arrayCounter<imgArray.Length-1)
			{
				cnt=0;
				do		//repeated bytes
				{
					buf[++cnt]=imgArray[++arrayCounter];
				}while(buf[cnt]!=buf[cnt-1] && arrayCounter<imgArray.Length-1 && cnt <254); 
				cnt--;
				output.Add(cnt);
				for(int a=0;a<cnt;a++) output.Add(buf[a]);
				
				buf[0]=buf[1]=buf[cnt+1];
				cnt=0;
				while(buf[0]==buf[1] &&  arrayCounter<imgArray.Length-1 && cnt++ <254) //not repeated bytes
					buf[0]=imgArray[++arrayCounter];
				output.Add(cnt);
				output.Add(buf[1]);
			}
			return output.ToArray();
		}
		
		
				
		
		

		
		
	}