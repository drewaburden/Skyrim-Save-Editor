using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves.SaveFields {
    public interface VSVal : SaveField { }
    public class VSVal<T> : SaveField<T>, VSVal {
        public String ValueType { get; set; }
        public new T Value { get; set; }

        public VSVal(String key) : base(key) {
            Type = "VSVal";
            ValueType = typeof(T).Name;
        }
    }
}
