using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public class ScreenshotData {
			public UInt32 shotWidth { get; set; }
			public UInt32 shotHeight { get; set; }
			public Byte[] R { get; set; }
			public Byte[] G { get; set; }
			public Byte[] B { get; set; }

			public Image generateImage() {
				uint xpixelInArray = 0;
				Bitmap bitmap = new Bitmap((int) shotWidth, (int) shotHeight);
				for (int ypixel = 0; ypixel < shotHeight; ++ypixel) {
					for (int xpixel = 0; xpixel < shotWidth; ++xpixel) {
						Color color;
						color = Color.FromArgb(
							(int) R[xpixelInArray],
							(int) G[xpixelInArray],
							(int) B[xpixelInArray]);
						bitmap.SetPixel(xpixel, ypixel, color);
						++xpixelInArray;
					}
				}
				return bitmap;
			}
		}
	}
}
