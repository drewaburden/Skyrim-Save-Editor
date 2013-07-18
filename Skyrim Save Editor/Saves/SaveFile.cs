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
	public enum Race {
		AltmerRace, ArgonianRace, BosmerRace, BretonRace, DunmerRace, ImperialRace, KhajiitRace, NordRace, OrcRace, RedguardRace
	};

	public partial class SaveFile {
		public Header header;
		public PluginInfo pluginInfo;
		public FileLocationTable fileLocationTable;
		public MiscStats miscStats;
		public PlayerLocation playerLocation;
		public TES tes;

		public SaveFile() {
			header = new Header();
			pluginInfo = new PluginInfo();
			fileLocationTable = new FileLocationTable();
			miscStats = new MiscStats();
			playerLocation = new PlayerLocation();
			//tes = new TES();
		}
		public SaveFile create() {
			return load(null);
		}
		public SaveFile load(String filename) {
			FileStream file = null;
			try {
				ResourceManager resourceManager;
				SaveReader saveReader;
				Byte[] resource;

				if (filename == null) {
					resourceManager = new ResourceManager("Skyrim_Save_Editor.Resources.Resource", Assembly.GetExecutingAssembly());
					resource = (Byte[]) resourceManager.GetObject("DefaultSave");
					saveReader = new SaveReader(new MemoryStream(resource));
				}
				else {
					file = new FileStream(filename, FileMode.Open);
					saveReader = new SaveReader(file);
				}

				header.loadFields(saveReader);
				fileLocationTable.loadFields(saveReader);
				miscStats.loadFields(saveReader);
				playerLocation.loadFields(saveReader);

				/*loadTES(saveReader);
				loadGlobalVariables(binaryReader);
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
			catch (Exception exception) {
				/* todo: write custom error dialog */
				if (filename == null) {
					MessageBox.Show("Error accessing resources:\n" + exception.Message + "\n\n" + exception.StackTrace);
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

			return this;
		}
	};
}
