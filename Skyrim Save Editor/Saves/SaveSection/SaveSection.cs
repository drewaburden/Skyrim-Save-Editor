using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public abstract class SaveSection {
		public String blockName;
		public abstract SaveField[] GetValues();
		public abstract SaveSection[] GetSections();
		public abstract void Load(SaveReader saveReader);
	}
}
