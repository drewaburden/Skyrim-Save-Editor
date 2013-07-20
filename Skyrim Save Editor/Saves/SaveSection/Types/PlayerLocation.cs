using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public class PlayerLocation : SaveSection {
		public SaveField<UInt32> type;
		public SaveField<UInt32> length;
		public SaveField<UInt32> unknown;
		public RefID worldSpace1; // RefID
		public SaveField<Int32> coorX;
		public SaveField<Int32> coorY;
		public RefID worldSpace2; // RefID
		public SaveField<Single> posX;
		public SaveField<Single> posY;
		public SaveField<Single> posZ;
		public SaveField<Byte> unk;

		public PlayerLocation() {
			blockName = "Player Location";
			type = new SaveField<UInt32>("type");
			length = new SaveField<UInt32>("length");
			unknown = new SaveField<UInt32>("unknown");
			coorX = new SaveField<Int32>("coorX");
			coorY = new SaveField<Int32>("coorY");
			posX = new SaveField<Single>("posX");
			posY = new SaveField<Single>("posY");
			posZ = new SaveField<Single>("posZ");
			unk = new SaveField<Byte>("unk");
		}

		public override void Load(SaveReader saveReader) {
			type.Value = saveReader.ReadUInt32();
			length.Value = saveReader.ReadUInt32();
			unknown.Value = saveReader.ReadUInt32();
			worldSpace1 = saveReader.ReadRefID("worldSpace1");
			coorX.Value = saveReader.ReadInt32();
			coorY.Value = saveReader.ReadInt32();
			worldSpace2 = saveReader.ReadRefID("worldSpace2");
			posX.Value = saveReader.ReadSingle();
			posY.Value = saveReader.ReadSingle();
			posZ.Value = saveReader.ReadSingle();
			unk.Value = saveReader.ReadByte();
		}

		public override SaveField[] GetValues() {
			return new SaveField[11] {
				type, length, unknown, worldSpace1, coorX,
				coorY, worldSpace2, posX, posY, posZ, unk
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
