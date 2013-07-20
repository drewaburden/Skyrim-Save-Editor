using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves.Loaders {
	class PlayerLocationLoader : Loader<PlayerLocation> {
		public static PlayerLocation load(SaveReader saveReader) {
			PlayerLocation playerLocation = new PlayerLocation();

			playerLocation.blockName = "Player Location";

			playerLocation.type.Value = saveReader.ReadUInt32();
			playerLocation.length.Value = saveReader.ReadUInt32();
			playerLocation.unknown.Value = saveReader.ReadUInt32();
			playerLocation.worldSpace1 = saveReader.ReadRefID("worldSpace1");
			playerLocation.coorX.Value = saveReader.ReadInt32();
			playerLocation.coorY.Value = saveReader.ReadInt32();
			playerLocation.worldSpace2 = saveReader.ReadRefID("worldSpace2");
			playerLocation.posX.Value = saveReader.ReadSingle();
			playerLocation.posY.Value = saveReader.ReadSingle();
			playerLocation.posZ.Value = saveReader.ReadSingle();
			playerLocation.unk.Value = saveReader.ReadByte();

			return playerLocation;
		}
	}
}
