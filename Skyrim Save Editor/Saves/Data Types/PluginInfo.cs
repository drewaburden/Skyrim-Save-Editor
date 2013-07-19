using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public class PluginInfo : TreeNode {
			public String blockName = "Plugin Info";
			public SaveField<UInt32> pluginInfoSize;
			public SaveField<Byte> pluginCount;
			public SaveField<String[]> plugins;

			public PluginInfo() {
				pluginInfoSize = new SaveField<UInt32>("pluginInfoSize");
				pluginCount = new SaveField<Byte>("pluginCount");
				plugins = new SaveField<String[]>("plugins");
			}

			public void loadFields(SaveReader saveReader) {
				pluginInfoSize.Value = saveReader.ReadUInt32();
				pluginCount.Value = saveReader.ReadByte();
				plugins.Value = saveReader.ReadPlugin(pluginCount.Value);
			}

			public override IEnumerator GetEnumerator() {
				return (new Object[3] {
					pluginInfoSize, pluginCount, plugins
				}).GetEnumerator();
			}

			public override TreeNode[] GetNodes() {
				return new TreeNode[0];
			}
		}
	}
}
