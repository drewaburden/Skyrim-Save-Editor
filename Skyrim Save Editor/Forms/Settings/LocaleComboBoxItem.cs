using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Skyrim_Save_Editor.Forms.Settings {
	class LocaleComboBoxItem {
		public LocaleComboBoxItem(object data, Image image) {
			this.Data = data;
			this.Image = image;
		}

		public object Data { get; set; }
		public Image Image { get; set; }
	}
}
