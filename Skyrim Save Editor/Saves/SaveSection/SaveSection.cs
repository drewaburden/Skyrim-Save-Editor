using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public abstract class SaveSection {
		public String blockName;
		public abstract SaveField[] GetValues();
		public abstract SaveSection[] GetSections();
		public abstract void Load(SaveReader saveReader);
	}
}
