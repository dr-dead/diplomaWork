﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mongoClient
{
	static class ControlExtensions
	{
		#region DateTimePicker extensions
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
				dateTimePicker.Checked = true;
				dateTimePicker.Value = (DateTime)dateTime;				
			}
		}

		/// <summary>
		/// Returns null or DateTime instance depending on the state of the checkbox of the DateTimePicker control.
		/// </summary>
		/// <param name="dateTimePicker">DateTimePicker control to execute method for.</param>
		/// <returns>Null or DateTime instance.</returns>
		public static DateTime? GetNullOrValue(this DateTimePicker dateTimePicker)
		{
			if(dateTimePicker.Checked)
			{
				return dateTimePicker.Value.Date;
			}
			return null;
		}
		#endregion
	}
}