/*
 * Создано в SharpDevelop.
 * Пользователь: Archivarius
 * Дата: 26.12.2021
 * Время: 1:10
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace SpriteGen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView previewList;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxB;
		private System.Windows.Forms.CheckBox checkBoxG;
		private System.Windows.Forms.CheckBox checkBoxR;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TrackBar trackBarBrightness;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownY;
		private System.Windows.Forms.NumericUpDown numericUpDownX;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ContextMenuStrip previewImgCtxtMenu;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip previewBlankCtxtMenu;
		private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
		private System.Windows.Forms.ImageList previewImageList;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton compression_RLE_H;
		private System.Windows.Forms.RadioButton compression_None;
		private System.Windows.Forms.Label imageSize;
		private System.Windows.Forms.Label allImagesSize;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveProjectMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem експоортToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьКакCToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.previewList = new System.Windows.Forms.ListView();
			this.previewImageList = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.compression_RLE_H = new System.Windows.Forms.RadioButton();
			this.compression_None = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.trackBarBrightness = new System.Windows.Forms.TrackBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxB = new System.Windows.Forms.CheckBox();
			this.checkBoxR = new System.Windows.Forms.CheckBox();
			this.checkBoxG = new System.Windows.Forms.CheckBox();
			this.allImagesSize = new System.Windows.Forms.Label();
			this.imageSize = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.previewImgCtxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.previewBlankCtxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.експоортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.previewImgCtxtMenu.SuspendLayout();
			this.previewBlankCtxtMenu.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// previewList
			// 
			this.previewList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
			this.previewList.AllowDrop = true;
			this.previewList.FullRowSelect = true;
			this.previewList.HideSelection = false;
			this.previewList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.previewList.LargeImageList = this.previewImageList;
			this.previewList.Location = new System.Drawing.Point(12, 34);
			this.previewList.MultiSelect = false;
			this.previewList.Name = "previewList";
			this.previewList.ShowGroups = false;
			this.previewList.Size = new System.Drawing.Size(148, 316);
			this.previewList.TabIndex = 0;
			this.previewList.TileSize = new System.Drawing.Size(288, 116);
			this.previewList.UseCompatibleStateImageBehavior = false;
			this.previewList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PreviewListItemSelectionChanged);
			this.previewList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PreviewListMouseClick);
			// 
			// previewImageList
			// 
			this.previewImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.previewImageList.ImageSize = new System.Drawing.Size(80, 80);
			this.previewImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(166, 34);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(320, 240);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaint);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(492, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(177, 316);
			this.panel1.TabIndex = 2;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.compression_RLE_H);
			this.groupBox4.Controls.Add(this.compression_None);
			this.groupBox4.Location = new System.Drawing.Point(9, 215);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(165, 84);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Compression";
			// 
			// compression_RLE_H
			// 
			this.compression_RLE_H.Location = new System.Drawing.Point(6, 39);
			this.compression_RLE_H.Name = "compression_RLE_H";
			this.compression_RLE_H.Size = new System.Drawing.Size(153, 24);
			this.compression_RLE_H.TabIndex = 1;
			this.compression_RLE_H.Text = "RLE";
			this.compression_RLE_H.UseVisualStyleBackColor = true;
			this.compression_RLE_H.CheckedChanged += new System.EventHandler(this.ImageSettingsChange);
			// 
			// compression_None
			// 
			this.compression_None.Checked = true;
			this.compression_None.Location = new System.Drawing.Point(6, 19);
			this.compression_None.Name = "compression_None";
			this.compression_None.Size = new System.Drawing.Size(147, 24);
			this.compression_None.TabIndex = 0;
			this.compression_None.TabStop = true;
			this.compression_None.Text = "No";
			this.compression_None.UseVisualStyleBackColor = true;
			this.compression_None.CheckedChanged += new System.EventHandler(this.ImageSettingsChange);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.trackBarBrightness);
			this.groupBox3.Location = new System.Drawing.Point(5, 62);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(167, 68);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Brightness";
			// 
			// trackBarBrightness
			// 
			this.trackBarBrightness.Location = new System.Drawing.Point(6, 19);
			this.trackBarBrightness.Maximum = 255;
			this.trackBarBrightness.Name = "trackBarBrightness";
			this.trackBarBrightness.Size = new System.Drawing.Size(159, 45);
			this.trackBarBrightness.TabIndex = 5;
			this.trackBarBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarBrightness.Value = 128;
			this.trackBarBrightness.ValueChanged += new System.EventHandler(this.ImageSettingsChange);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.numericUpDownY);
			this.groupBox2.Controls.Add(this.numericUpDownX);
			this.groupBox2.Location = new System.Drawing.Point(5, 132);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(167, 77);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Размер";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "Y";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "X";
			// 
			// numericUpDownY
			// 
			this.numericUpDownY.Location = new System.Drawing.Point(53, 45);
			this.numericUpDownY.Maximum = new decimal(new int[] {
			240,
			0,
			0,
			0});
			this.numericUpDownY.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownY.Name = "numericUpDownY";
			this.numericUpDownY.Size = new System.Drawing.Size(104, 20);
			this.numericUpDownY.TabIndex = 1;
			this.numericUpDownY.Value = new decimal(new int[] {
			240,
			0,
			0,
			0});
			this.numericUpDownY.ValueChanged += new System.EventHandler(this.ImageSettingsChange);
			// 
			// numericUpDownX
			// 
			this.numericUpDownX.Increment = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.numericUpDownX.Location = new System.Drawing.Point(53, 19);
			this.numericUpDownX.Maximum = new decimal(new int[] {
			320,
			0,
			0,
			0});
			this.numericUpDownX.Minimum = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.numericUpDownX.Name = "numericUpDownX";
			this.numericUpDownX.Size = new System.Drawing.Size(104, 20);
			this.numericUpDownX.TabIndex = 0;
			this.numericUpDownX.Value = new decimal(new int[] {
			320,
			0,
			0,
			0});
			this.numericUpDownX.ValueChanged += new System.EventHandler(this.ImageSettingsChange);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxB);
			this.groupBox1.Controls.Add(this.checkBoxR);
			this.groupBox1.Controls.Add(this.checkBoxG);
			this.groupBox1.Location = new System.Drawing.Point(1, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(171, 53);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "RGB Channels";
			// 
			// checkBoxB
			// 
			this.checkBoxB.Checked = true;
			this.checkBoxB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxB.Location = new System.Drawing.Point(118, 19);
			this.checkBoxB.Name = "checkBoxB";
			this.checkBoxB.Size = new System.Drawing.Size(35, 24);
			this.checkBoxB.TabIndex = 2;
			this.checkBoxB.Text = "B";
			this.checkBoxB.UseVisualStyleBackColor = true;
			this.checkBoxB.CheckStateChanged += new System.EventHandler(this.ImageSettingsChange);
			// 
			// checkBoxR
			// 
			this.checkBoxR.Checked = true;
			this.checkBoxR.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxR.Location = new System.Drawing.Point(31, 19);
			this.checkBoxR.Name = "checkBoxR";
			this.checkBoxR.Size = new System.Drawing.Size(35, 24);
			this.checkBoxR.TabIndex = 0;
			this.checkBoxR.Text = "R";
			this.checkBoxR.UseVisualStyleBackColor = true;
			this.checkBoxR.CheckStateChanged += new System.EventHandler(this.ImageSettingsChange);
			// 
			// checkBoxG
			// 
			this.checkBoxG.Checked = true;
			this.checkBoxG.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxG.Location = new System.Drawing.Point(77, 19);
			this.checkBoxG.Name = "checkBoxG";
			this.checkBoxG.Size = new System.Drawing.Size(35, 24);
			this.checkBoxG.TabIndex = 1;
			this.checkBoxG.Text = "G";
			this.checkBoxG.UseVisualStyleBackColor = true;
			this.checkBoxG.CheckStateChanged += new System.EventHandler(this.ImageSettingsChange);
			// 
			// allImagesSize
			// 
			this.allImagesSize.Location = new System.Drawing.Point(167, 325);
			this.allImagesSize.Name = "allImagesSize";
			this.allImagesSize.Size = new System.Drawing.Size(168, 18);
			this.allImagesSize.TabIndex = 12;
			// 
			// imageSize
			// 
			this.imageSize.Location = new System.Drawing.Point(166, 299);
			this.imageSize.Name = "imageSize";
			this.imageSize.Size = new System.Drawing.Size(169, 23);
			this.imageSize.TabIndex = 11;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.BMP)|*.BMP|Image Files(*.GIF)|*.GIF|Image " +
	"Files(*.PNG)|*.PNG|All files (*.*)|*.*";
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.RestoreDirectory = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "img";
			this.saveFileDialog1.Filter = "C++ array (*.h)|*.h|Byte array (*.bin)|*.bin";
			this.saveFileDialog1.RestoreDirectory = true;
			// 
			// previewImgCtxtMenu
			// 
			this.previewImgCtxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem1});
			this.previewImgCtxtMenu.Name = "previewImgCtxtMenu";
			this.previewImgCtxtMenu.Size = new System.Drawing.Size(118, 26);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
			this.toolStripMenuItem1.Text = "Remove";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.RemovePicPreviewMenuClick);
			// 
			// previewBlankCtxtMenu
			// 
			this.previewBlankCtxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.добавитьToolStripMenuItem});
			this.previewBlankCtxtMenu.Name = "previewBlankCtxtMenu";
			this.previewBlankCtxtMenu.Size = new System.Drawing.Size(153, 48);
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.добавитьToolStripMenuItem.Text = "Add pictures";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.InsertPicPreviewMenuItemClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.файлToolStripMenuItem,
			this.експоортToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(676, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.OpenProjectToolStripMenuItem,
			this.открытьToolStripMenuItem,
			this.SaveProjectMenuItem,
			this.toolStripMenuItem2,
			this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.файлToolStripMenuItem.Text = "File";
			// 
			// OpenProjectToolStripMenuItem
			// 
			this.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
			this.OpenProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.OpenProjectToolStripMenuItem.Text = "Open project";
			this.OpenProjectToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectMenuItemClick);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.открытьToolStripMenuItem.Text = "Add picture";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.InsertPicPreviewMenuItemClick);
			// 
			// SaveProjectMenuItem
			// 
			this.SaveProjectMenuItem.Name = "SaveProjectMenuItem";
			this.SaveProjectMenuItem.Size = new System.Drawing.Size(143, 22);
			this.SaveProjectMenuItem.Text = "Save project";
			this.SaveProjectMenuItem.Click += new System.EventHandler(this.SaveProjectMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.выходToolStripMenuItem.Text = "Exit program";
			// 
			// експоортToolStripMenuItem
			// 
			this.експоортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.сохранитьКакCToolStripMenuItem});
			this.експоортToolStripMenuItem.Name = "експоортToolStripMenuItem";
			this.експоортToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.експоортToolStripMenuItem.Text = "Export";
			// 
			// сохранитьКакCToolStripMenuItem
			// 
			this.сохранитьКакCToolStripMenuItem.Name = "сохранитьКакCToolStripMenuItem";
			this.сохранитьКакCToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.сохранитьКакCToolStripMenuItem.Text = "Save as C header";
			this.сохранитьКакCToolStripMenuItem.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 359);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.allImagesSize);
			this.Controls.Add(this.imageSize);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.previewList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SpriteGen";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.previewImgCtxtMenu.ResumeLayout(false);
			this.previewBlankCtxtMenu.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
