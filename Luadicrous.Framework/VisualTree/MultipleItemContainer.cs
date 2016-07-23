﻿namespace Luadicrous.Framework
{
	public abstract class MultipleItemContainer : VisualTreeElement
	{
		public new VisualTreeElement AddChildren(params VisualTreeElement[] children)
		{
			foreach (var child in children)
				((Gtk.Container)Widget).Add(child.Widget);
			return base.AddChildren(children);
		}

		public new VisualTreeElement RemoveChildren(params VisualTreeElement[] children)
		{
			foreach (var child in children)
				((Gtk.Container)Widget).Remove(child.Widget);
			return base.RemoveChildren(children);
		}
	}
}
