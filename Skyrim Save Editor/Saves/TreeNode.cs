using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public abstract class TreeNode : IEnumerable {
			public String blockName;
			public abstract IEnumerator GetEnumerator();
			public abstract TreeNode[] GetNodes();
		}
	}
}
