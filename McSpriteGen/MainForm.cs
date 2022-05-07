using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SpriteGen
{	
	[Serializable]
	public partial class MainForm : Form
	{
		 
		List<ImageData> imageList = new List<ImageData>();
		
		int selectedItemIndex = 0;	
			
				
		public MainForm()
		{
			InitializeComponent();			
		}
		
		
					
				
		void UpdatePreviewList()
		{
			previewList.Items.Clear();
			previewImageList.Images.Clear();
			
			foreach(ImageData img in imageList)
				{
					previewImageList.Images.Add(img.name, img.originalImage);
					var z = previewList.Items.Add(img.name);
					z.ImageKey = img.name;
				}
		}
				
					
	
		void PreviewListMouseClick(object sender, MouseEventArgs e)
		{				
			if (e.Button == MouseButtons.Right)
   			 {
				var focusedItem = previewList.GetItemAt(e.Location.X, e.Location.Y);				
				var contextMenu = (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) ? previewImgCtxtMenu : previewBlankCtxtMenu;
				contextMenu.Show(Cursor.Position);
			}					
		}
				

				

		void RemovePicPreviewMenuClick(object sender, EventArgs e)
		{
			imageList.RemoveAt(selectedItemIndex);
			UpdatePreviewList();
			pictureBox.Refresh();
		}
		
		
		
		void InsertPicPreviewMenuItemClick(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				foreach (String fName in openFileDialog1.FileNames)
				{
					var img = new Bitmap(new Bitmap(fName), 320,240); //resize pic
					imageList.Add(new ImageData(Path.GetFileNameWithoutExtension(fName), img));
				}				
				UpdatePreviewList();
			}
		}
		
		
		
		void PictureBoxPaint(object sender, PaintEventArgs e)
		{
			if(previewList.FocusedItem == null) return;
			
				var img = imageList[selectedItemIndex].changedImage;
				int x=(pictureBox.Width-img.Width)/2;
				int y=(pictureBox.Height-img.Height)/2;
				e.Graphics.DrawImage(img,x,y);
			
		}
		
		
	
		void PreviewListItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if(e.IsSelected)
			{
			selectedItemIndex = e.ItemIndex;
			ImageSettingsLoad();
			pictureBox.Refresh();
			} 
			
		}
		
		
		Boolean loadingFlag;
		
		void ImageSettingsLoad()
		{
			loadingFlag = true;
			
			var pic = imageList[selectedItemIndex];
			checkBoxR.Checked = pic.R;
			checkBoxG.Checked = pic.G;
			checkBoxB.Checked = pic.B;
			trackBarBrightness.Value = pic.brightness;
			numericUpDownX.Value = pic.size.Width;
			numericUpDownY.Value = pic.size.Height;
			
			switch (pic.compressionType)
			{
				case CompressionType.None: compression_None.Checked = true;
				break;
				case CompressionType.RLE_Horisontal: compression_RLE_H.Checked = true;
				break;
		//		case CompressionType.RLE_Vertical: compression_RLE_V.Checked = true;
		//		break;
			}
			
			loadingFlag = false;
			ShowImageSize();			
		}
		
		
		void ShowImageSize()
		{
			int sz=0;
			foreach(var img in imageList) sz += img.exportArr.Length;
			
			imageSize.Text = "Picture size: " + imageList[selectedItemIndex].exportArr.Length.ToString();
			allImagesSize.Text = "All pictures size: " + sz.ToString();
		}
		
		
		

		//when brightness, channel, compression.. was changed
		void ImageSettingsChange(object sender, EventArgs e)
		{
			if (loadingFlag || imageList.Count == 0) return;
			
			var pic = imageList[selectedItemIndex];
			
			pic.R = checkBoxR.Checked;
			pic.G = checkBoxG.Checked;
			pic.B = checkBoxB.Checked;
			pic.brightness = trackBarBrightness.Value;
			pic.size.Width = (int)numericUpDownX.Value;
			pic.size.Height = (int)numericUpDownY.Value;
			
			pic.compressionType = compression_None.Checked ? CompressionType.None : compression_RLE_H.Checked ? CompressionType.RLE_Horisontal : CompressionType.RLE_Vertical;
			
			pic.UpdatePicture();
			pictureBox.Refresh();
			
			ShowImageSize();
		}
	
		
		
		


		ImagesSaver isvr = new ImagesSaver();
		

		void SaveButtonClick(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog()==DialogResult.OK && imageList.Count !=0)
				if(saveFileDialog1.FileName!="")
			{				
					switch(saveFileDialog1.FilterIndex)
					{
						case 1: 
							isvr.SaveAsCPPHeader(saveFileDialog1.FileName, imageList);
							break;															
						case 2:	 
							//TODO: will save as picture set
							break;
					}
					
			}
		}
		
		
		
		void OpenProjectMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "McSpriteGen Files|*.mcsg";
			if(ofd.ShowDialog() == DialogResult.OK)
			{
			IFormatter formatter = new BinaryFormatter();  
			Stream stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.None);  
			imageList = (List<ImageData>) formatter.Deserialize(stream);
			stream.Close();
			}
			UpdatePreviewList();
			
		}
		
		
		void SaveProjectMenuItemClick(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "McSpriteGen Files|*.mcsg";
			if(sfd.ShowDialog() == DialogResult.OK)
			{
			IFormatter formatter = new BinaryFormatter();  
			Stream stream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None);  
			formatter.Serialize(stream, imageList);  
			stream.Close();
			}
		}
		
	}
	
}



