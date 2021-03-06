// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using System;
using CivOne.Events;

namespace CivOne.UserInterface
{
	public static class MenuItemExtensions
	{
		public static MenuItem<T> Disable<T>(this MenuItem<T> menuItem)
		{
			menuItem.Enabled = false;
			return menuItem;
		}

		public static MenuItem<T> Enable<T>(this MenuItem<T> menuItem)
		{
			menuItem.Enabled = true;
			return menuItem;
		}

		public static MenuItem<T> SetEnabled<T>(this MenuItem<T> menuItem, bool enabled)
		{
			menuItem.Enabled = enabled;
			return menuItem;
		}

		public static MenuItem<T> SetActive<T>(this MenuItem<T> menuItem, Func<bool> selectedCondition)
		{
			menuItem.SelectedCondition = selectedCondition;
			return menuItem;
		}

		public static MenuItem<T> SetActive<T>(this MenuItem<T> menuItem) => menuItem.SetActive(() => true);

		public static MenuItem<T> SetShortcut<T>(this MenuItem<T> menuItem, string shortcut)
		{
			menuItem.Shortcut = shortcut;
			return menuItem;
		}

		public static MenuItem<T> OnSelect<T>(this MenuItem<T> menuItem, MenuItemEventHandler<T> eventMethod)
		{
			menuItem.Selected += eventMethod;
			return menuItem;
		}

		public static MenuItem<T> OnContext<T>(this MenuItem<T> menuItem, MenuItemEventHandler<T> eventMethod)
		{
			menuItem.RightClick += eventMethod;
			return menuItem;
		}

		public static MenuItem<T> OnHelp<T>(this MenuItem<T> menuItem, MenuItemEventHandler<T> eventMethod)
		{
			menuItem.GetHelp += eventMethod;
			return menuItem;
		}
	}
}