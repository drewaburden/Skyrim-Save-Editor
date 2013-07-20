﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves.SaveFields {
	using Hex = String;
	public class RefID : SaveField<Hex> {
		public Byte type { get; set; }
		public Byte[] formID; // 22-bit value. Not displayed in UI, so not a property.

		public RefID(String name) : base(name) { }
	}
}
