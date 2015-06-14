using System;
using Android.Views;
using Android.Graphics;

namespace TaskyAndroid
{
	public class Styling
	{


		public void SetBackground(Android.Views.Window win) 
		{
			CustomiseAppearance(win);
		}

		#region private methods
		private void CustomiseAppearance(Android.Views.Window win) 
		{
			View titleView = win.FindViewById(Android.Resource.Id.Title);
			if (titleView != null)
			{
				IViewParent parent = titleView.Parent;
				if (parent != null && parent is View)
				{
					View parentView = (View)parent;
					parentView.SetBackgroundColor(Color.Rgb(0x26,0x75,0xFF));
				}
			}
		}
		#endregion
	}
}

