using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public class PlayerLocation {
			public SaveField<UInt32> type;
			public SaveField<UInt32> length;
			public SaveField<UInt32> unknown;
			public SaveField<RefID> worldSpace1;
			public SaveField<Int32> coorX;
			public SaveField<Int32> coorY;
			public SaveField<RefID> worldSpace2;
			public SaveField<Single> posX;
			public SaveField<Single> posY;
			public SaveField<Single> posZ;
			public SaveField<Byte> unk;

			public PlayerLocation() {
				type = new SaveField<UInt32>("type");
				length = new SaveField<UInt32>("length");
				unknown = new SaveField<UInt32>("unknown");
				worldSpace1 = new SaveField<RefID>("worldSpace1");
				coorX = new SaveField<Int32>("coorX");
				coorY = new SaveField<Int32>("coorY");
				worldSpace2 = new SaveField<RefID>("worldSpace2");
				posX = new SaveField<Single>("posX");
				posY = new SaveField<Single>("posY");
				posZ = new SaveField<Single>("posZ");
				unk = new SaveField<Byte>("unk");
			}

			public void loadFields(SaveReader saveReader) {
				type.Value = saveReader.ReadUInt32();
				length.Value = saveReader.ReadUInt32();
				unknown.Value = saveReader.ReadUInt32();
				worldSpace1.Value = saveReader.ReadRefID();
				coorX.Value = saveReader.ReadInt32();
				coorY.Value = saveReader.ReadInt32();
				worldSpace2.Value = saveReader.ReadRefID();
				posX.Value = saveReader.ReadSingle();
				posY.Value = saveReader.ReadSingle();
				posZ.Value = saveReader.ReadSingle();
				unk.Value = saveReader.ReadByte();
			}
		}
	}
}
