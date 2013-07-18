using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public interface SaveBlock {
			void loadFields(SaveReader binaryReader);
		}
	}
}
