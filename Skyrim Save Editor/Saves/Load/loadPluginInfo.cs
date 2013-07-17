using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveManager {
		protected void loadPluginInfo(BinaryReader binaryReader) {
			PluginInfo pluginInfo = loadedSave.pluginInfo; // For code cleanliness

			// pluginInfoSize
			pluginInfo.pluginInfoSize = binaryReader.ReadUInt32();

			// pluginCount
			pluginInfo.pluginCount = binaryReader.ReadByte();

			// plugins
			pluginInfo.plugins = new String[pluginInfo.pluginCount];
			for (int pluginIndex = 0; pluginIndex < pluginInfo.plugins.Length; ++ pluginIndex) {
				pluginInfo.plugins[pluginIndex] = new String(binaryReader.ReadChars(binaryReader.ReadInt16()));
			}
		}
	}
}