using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class PluginInfo : SaveSection {
		public SaveField<UInt32> pluginInfoSize;
		public SaveField<Byte> pluginCount;
		public SaveField<String[]> plugins;

		public PluginInfo() {
			blockName = "Plugin Info";
			pluginInfoSize = new SaveField<UInt32>("pluginInfoSize");
			pluginCount = new SaveField<Byte>("pluginCount");
			plugins = new SaveField<String[]>("plugins");
		}

		public override void Load(SaveReader saveReader) {
			pluginInfoSize.Value = saveReader.ReadUInt32();
			pluginCount.Value = saveReader.ReadByte();
			plugins.Value = saveReader.ReadPlugin(pluginCount.Value);
		}

		public override SaveField[] GetFields() {
			return new SaveField[3] {
				pluginInfoSize, pluginCount, plugins
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
