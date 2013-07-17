using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Diagnostics;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveManager {
		public SaveManager() { }
		~SaveManager() { }

		public SaveFile createSave() {
			return load(null);
		}
		public SaveFile load(String filename) {
			loadedSave = new SaveFile();
			FileStream file = null;
			try {
				ResourceManager resourceManager;
				BinaryReader binaryReader;
				Byte[] resource;

				if (filename == null) {
					resourceManager = new ResourceManager("Skyrim_Save_Editor.Resources.Resource", Assembly.GetExecutingAssembly());
					resource = (Byte[]) resourceManager.GetObject("DefaultSave");
					binaryReader = new BinaryReader(new MemoryStream(resource));
				}
				else {
					file = new FileStream(filename, FileMode.Open);
					binaryReader = new BinaryReader(file);
				}

				loadHeader(binaryReader);
				loadPluginInfo(binaryReader);
				loadFileLocationTable(binaryReader);
				loadMiscStats(binaryReader);
				loadPlayerLocation(binaryReader);

				loadTES(binaryReader);
				/*loadGlobalVariables(binaryReader);
				loadCreatedObjects(binaryReader);
				loadEffects(binaryReader);
				loadWeather(binaryReader);
				loadAudio(binaryReader);
				loadSkyCells(binaryReader);
				loadProcessLists(binaryReader);
				loadCombat(binaryReader);
				loadInterface(binaryReader);
				loadActorCauses(binaryReader);
				loadUnknown104(binaryReader);
				loadDetectionManager(binaryReader);
				loadLocationMetaData(binaryReader);
				loadQuestStatic (binaryReader);
				loadStoryTeller(binaryReader);
				loadMagicFavorites(binaryReader);
				loadPlayerControls(binaryReader);
				loadStoryEvent (binaryReader);
				loadIngredientShared(binaryReader);
				loadMenuControls(binaryReader);
				loadMenuTopicManager(binaryReader);
				loadTempEffects(binaryReader);
				loadPapyrus(binaryReader);
				loadAnimObjects(binaryReader);
				loadTimer(binaryReader);
				loadSynchronizedAnimations(binaryReader);
				loadMain(binaryReader);*/
			}
			catch(Exception exception) {
				if (filename == null) {
					MessageBox.Show("Error accessing resources:\n" + exception.ToString() + " at " + exception.TargetSite + "\n\n" + exception.Message + "\n\n" + exception.StackTrace);
				}
				else {
					MessageBox.Show("Error loading save file:\n" + exception.Message + "\n\n" + exception.StackTrace);
				}
				return default(SaveFile);
			}
			finally {
				if (file != null) {
					file.Close();
				}
			}

			return loadedSave;
		}

		//protected	BinaryReader binaryReader;
		protected SaveFile loadedSave { get; set; }

		protected RefID readRefID(BinaryReader binaryReader) {
			RefID refID = new RefID();
			refID.formID = new Byte[3];

			binaryReader.BaseStream.Read(refID.formID, 0, 3); // Read only 3 bytes

			refID.type = (Byte) (refID.formID[0] >> 6); // Get the upper 2 bits, which represent the formID type
			refID.formID[0] <<= 2; // Get the remaining lower 6 bits to form the completed "22-bit" byte array

			refID.hexFormID = "0x" +
				BitConverter.ToString(refID.formID, 0)
				.Replace("-", String.Empty).PadLeft(8, '0'); // Convert the "22-bit" byte array to a readable hex string for easy lookup in the Creation Kit*/

			return refID;
		}
	}
}
