using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mongoClient
{
	static class ControlExtensions
	{
		/// <summary>
		/// A method to try to assign the value of the nullable DateTime instance. If the value is null, check off DateTimePicker control. Assign the value to DateTimePicker.Value property otherwise.
		/// </summary>
		/// <param name="dateTimePicker">DateTimePicker control to execute method for.</param>
		/// <param name="dateTime">Nullable DateTime instance to check for the value.</param>
		public static void TryToAssignValue(this DateTimePicker dateTimePicker, DateTime? dateTime)
		{
			if(dateTime.GetValueOrDefault() < dateTimePicker.MinDate || dateTime.GetValueOrDefault() > dateTimePicker.MaxDate)
			{
				dateTime = null;
			}
			if(dateTime == null)
			{
				dateTimePicker.Value = DateTime.Now;
				dateTimePicker.Checked = false;
			}
			else
			{
				dateTimePicker.Value = (DateTime)dateTime;
			}
		}
	}
}
