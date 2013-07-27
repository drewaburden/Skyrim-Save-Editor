using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves.SaveFields {
	public class MiscStat : SaveField<Int32> {
		public Byte Category { get; set; }

		public MiscStat(String key) : base(key) {
            Type = "MiscStat";
        }
	}
}
