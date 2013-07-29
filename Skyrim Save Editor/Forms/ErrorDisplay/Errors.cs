using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor {
	public static class Errors {
		public static Dictionary<int, Error> ErrorNumbers;

		static Errors() {
			// Interpreting error codes (from right to left):
			// The first (rightmost) digit represents whether or not the error was fatal. (0 = non-fatal, 1 = fatal)
			// The second digit represents whether or not the error is documented or expected. (0 = undocumented, 1 = documented)
			// The two digits before the last digit uniquely identifies each error in its category of errors.
			// The last (leftmost) digit represents the category the error is in:
			//		1 = General
			//		2 = Data loading

			ErrorNumbers = new Dictionary<int, Error>();
			ErrorNumbers.Add(10000, new Error("An undocumented error has occurred.", false));
			ErrorNumbers.Add(10101, new Error("An undocumented error has occurred.", true));
			ErrorNumbers.Add(10201, new Error("An error has occurred, but the error code given was not found in the error dictionary.", true));

			ErrorNumbers.Add(20000, new Error("An undocumented error has occurred while trying to open a file.", false));
			ErrorNumbers.Add(20110, new Error("An error has occurred while trying to access internal resources.", false));
			ErrorNumbers.Add(20210, new Error("An error has occurred while trying to load the specified save file.", false));
		}
	}
	public class Error {
		public String Text { get; set; }
		public bool Fatal { get; set; }
		public String Details { get; set; }

		public Error(String text, bool fatal) {
			Text = text;
			Fatal = fatal;
		}
	}
}
