using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves.Loaders {
	class PluginInfoLoader {
		public static PluginInfo load(SaveReader saveReader) {
			PluginInfo pluginInfo = new PluginInfo();

			pluginInfo.blockName = "Plugin Info";

			pluginInfo.pluginInfoSize.Value = saveReader.ReadUInt32();
			pluginInfo.pluginCount.Value = saveReader.ReadByte();
			pluginInfo.plugins.Value = saveReader.ReadPlugin(pluginInfo.pluginCount.Value);

			return pluginInfo;
		}
	}
}
