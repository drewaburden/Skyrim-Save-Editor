using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveManager {
		protected void loadPlayerLocation(BinaryReader binaryReader) {
			PlayerLocation playerLocation = loadedSave.playerLocation; // For code cleanliness

			// playerLocationType
			binaryReader.ReadUInt32();

			// playerLocationLength
			binaryReader.ReadUInt32();

			// unknown
			playerLocation.unknown = binaryReader.ReadUInt32();

			// worldSpace1
			playerLocation.worldSpace1 = readRefID(binaryReader);

			// coorX
			playerLocation.coorX = binaryReader.ReadInt32();

			// coorY
			playerLocation.coorY = binaryReader.ReadInt32();

			// worldSpace2
			playerLocation.worldSpace2 = readRefID(binaryReader);

			// posX
			playerLocation.posX = binaryReader.ReadSingle();

			// posY
			playerLocation.posY = binaryReader.ReadSingle();

			// posZ
			playerLocation.posZ = binaryReader.ReadSingle();

			// unk
			playerLocation.unk = binaryReader.ReadByte();
		}
	}
}