using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality.Editor;

namespace content.Editor
{
	/// <summary>
	/// Defines a Duality editor plugin.
	/// </summary>
    public class contentEditorPlugin : EditorPlugin
	{
		public override string Id
		{
			get { return "contentEditorPlugin"; }
		}
	}
}
