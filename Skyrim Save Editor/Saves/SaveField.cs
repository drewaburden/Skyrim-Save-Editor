using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public interface SaveFieldType {
			String Type { get; set; }
		}
		public class SaveField<T> : SaveFieldType {
			public String Type { get; set; }
			public String Key { get; set; }
			public T Value { get; set; }
			public String Description { get; set; }

			public SaveField(String key) {
				Type = typeof(T).Name;
				Key = key;
			}
		}
	}
}
