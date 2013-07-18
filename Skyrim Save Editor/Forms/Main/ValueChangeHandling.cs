using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves;

namespace Skyrim_Save_Editor.Forms.Main {
	partial class MainForm {
		void playerExperience_ValueChanged(Object sender, EventArgs e) {
			playerExperienceBar.Value = Convert.ToInt32(playerExperienceBox.Value);
			activeSave.header.playerCurExp.Value = (float) Convert.ToDouble(playerExperienceBox.Value);
		}
		void playerName_TextChanged(Object sender, EventArgs e) {
			if (activeSave.header.playerName.Value != playerName.Text) {
				saveDiff.header.playerName.Value = playerName.Text;
			}
		}
		void playerLevel_ValueChanged(Object sender, EventArgs e) {
			if (activeSave.header.playerLevel.Value != playerLevel.Value) {
				saveDiff.header.playerLevel.Value = Convert.ToUInt32(playerLevel.Value);
			}
		}
		void playerRace_SelectedIndexChanged(Object sender, EventArgs e) {
			/*String selectedRace = static_cast<Race>(playerRace.SelectedIndex).ToString("g");
			if (activeSave.header.playerRace != selectedRace) {
				saveDiff.header.playerRace = selectedRace;
			}*/
		}
	}
}
