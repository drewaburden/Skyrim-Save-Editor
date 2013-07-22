using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;
using Skyrim_Save_Editor.Saves.SaveSections;
using Skyrim_Save_Editor.Forms.Main.Advanced;

namespace Skyrim_Save_Editor.Forms.Main {
	public class TreeListViewFilter : IModelFilter {
		public bool IsFiltering { get; set; }
		String FilterText { get; set; }

		public TreeListViewFilter(String filterText) : base() {
			IsFiltering = false;
			FilterText = filterText;
		}

		public bool Filter(object modelObject) {
			if (IsFiltering) {
				Console.WriteLine("WAT");
				return ((SaveSection) ((TreeItem) modelObject).NodeData).blockName.Contains(FilterText);
			}
			else {
				Console.WriteLine("FUK");
				return true;
			}
		}
	}
}
