using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Forms.Main.Advanced {
	public class TreeItem : IEnumerable {
		public Object NodeData { get; set; }
		public ArrayList Children = null;

		public TreeItem(Object nodeData) {
			NodeData = nodeData;
		}

		public IEnumerator GetEnumerator() { return Children.GetEnumerator(); }
	}
}
