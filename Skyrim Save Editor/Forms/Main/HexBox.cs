using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.Main {
	public partial class HexBox : UpDownBase {
		const String MAX_VALUE = "FFFFFFFF";
		const String MIN_VALUE = "00000000";
		String LastText;

		public HexBox() {
			Text = "00000000";
			LastText = (String) Text.Clone();
			this.InterceptArrowKeys = true;
			KeyDown += delegate(Object sender, KeyEventArgs e) {
				// If the key wasn't a valid key, supress the key
				if ((!Char.IsControl(((char)e.KeyValue)) &&	(e.Modifiers != Keys.Control))
					&&
					((e.KeyCode > Keys.F && e.KeyCode <= Keys.Z) ||
					(e.KeyCode > Keys.Multiply && e.KeyCode > Keys.Divide)) ||
					(e.Modifiers == Keys.Shift && e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)) {
					e.SuppressKeyPress = true;
				}
			};
			TextChanged += delegate(Object sender, EventArgs e) {
				Text = Text.ToUpper();
				this.Select(8, 0);
			};
		}

		protected override void UpdateEditText() { }

		public override void UpButton() {
			Increment();
		}
		public override void DownButton() {
			Decrement();
		}

		public void Increment() {
			Increment(Text.Length-1);
		}
		public void Increment(int atPosition) {
			Text = Text.ToUpper();
			int characterPosition = atPosition;
			if (Text[characterPosition] == 'F' && Text != MAX_VALUE) {
				Text = Text.Remove(characterPosition, 1);
				Text = Text.Insert(characterPosition, "0");
				Increment(characterPosition-1);
			}
			else if (Text[characterPosition] >= '0' && Text[characterPosition] <= '8') {
				Text = Text.Insert(characterPosition, ((Char) (Text[characterPosition] + 1)).ToString());
				Text = Text.Remove(characterPosition + 1, 1);
			}
			else if (Text[characterPosition] == '9') {
				Text = Text.Remove(characterPosition, 1);
				Text = Text.Insert(characterPosition, "A");
			}
			else if (Text[characterPosition] >= 'A' && Text[characterPosition] <= 'E') {
				Text = Text.Insert(characterPosition, ((Char) (Text[characterPosition] + 1)).ToString());
				Text = Text.Remove(characterPosition + 1, 1);
			}
		}
		public void Decrement() {
			Decrement(Text.Length - 1);
		}
		public void Decrement(int atPosition) {
			Text = Text.ToUpper();
			int characterPosition = atPosition;
			if (Text[characterPosition] == '0' && Text != MIN_VALUE) {
				Text = Text.Remove(characterPosition, 1);
				Text = Text.Insert(characterPosition, "F");
				Decrement(characterPosition - 1);
			}
			else if (Text[characterPosition] >= '1' && Text[characterPosition] <= '9') {
				Text = Text.Insert(characterPosition, ((Char) (Text[characterPosition] - 1)).ToString());
				Text = Text.Remove(characterPosition + 1, 1);
			}
			else if (Text[characterPosition] == 'A') {
				Text = Text.Remove(characterPosition, 1);
				Text = Text.Insert(characterPosition, "9");
			}
			else if (Text[characterPosition] >= 'B' && Text[characterPosition] <= 'F') {
				Text = Text.Insert(characterPosition, ((Char) (Text[characterPosition] - 1)).ToString());
				Text = Text.Remove(characterPosition + 1, 1);
			}
		}
	}
}
