using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class GlobalDataTable3 : SaveSection {

		public GlobalDataTable3() {
			blockName = "Global Data Table 3";
		}

		public override void Load(SaveReader saveReader) {
		}

		public override SaveField[] GetFields() {
			return new SaveField[0];
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}