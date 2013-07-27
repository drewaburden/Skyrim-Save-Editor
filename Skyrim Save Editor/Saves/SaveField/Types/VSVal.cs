using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves.SaveFields {
    public class VSVal : SaveField<UInt32> {
		public String ValueType { get; set; }

        public VSVal(String key) : base(key) {
            Type = "VSVal";
        }
    }
}
