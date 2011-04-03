using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mongoClient
{
	static class InvokeExtensions
	{
		/// <summary>
		/// Executes the specified delegate on the thread that owns the control's handle if invoke is needed. Executes delegate else way.
		/// </summary>
		/// <param name="control">Control's handle that is owned by the thread.</param>
		/// <param name="action">Delegate to execute.</param>
		public static void InvokeIfRequired<T>(this T control, Action<T> action) where T: Control
		{
			if(control.InvokeRequired)
			{
				control.Invoke(new Action(() => action(control)));
			}
			else
			{
				action(control);
			}
		}

		/// <summary>
		/// Executes the specified delegate asynchronously on the thread that owns the control's handle if invoke is needed. Executes delegate else way.
		/// </summary>
		/// <param name="control">Control's handle that is owned by the thread.</param>
		/// <param name="action">Delegate to execute.</param>
		public static void BeginInvokeIfRequired<T>(this T control, Action<T> action) where T: Control
		{
			if(control.InvokeRequired)
			{
				control.BeginInvoke(new Action(() => action(control)));
			}
			else
			{
				action(control);
			}
		}
	}
}
