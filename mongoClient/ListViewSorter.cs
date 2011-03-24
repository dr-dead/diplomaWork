using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mongoClient
{
	/// <summary>
	/// Provides sorting for ListView using logical comparer.
	/// </summary>
	class ListViewSorter : System.Collections.IComparer
	{
		private int columnToSortBy;

		public ListViewSorter()
		{
			columnToSortBy = 1;
		}

		public ListViewSorter(int column)
		{
			columnToSortBy = column;
		}

		/// <summary>
		/// Function from Windows Explorer Shell that provides logical comparer for two objects.
		/// </summary>
		/// <param name="strA">The first object to compare.</param>
		/// <param name="strB">The second object to compare.</param>
		/// <returns>int value that represents the difference between two objects.</returns>
		[System.Runtime.InteropServices.DllImport("shlwapi.dll", CharSet=System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling=true)]
		private static extern int StrCmpLogicalW(string strA, string strB);

		public int Compare(object x, object y)
		{
			string textX = ((System.Windows.Forms.ListViewItem)x).SubItems[columnToSortBy].Text as string;
			if(textX != null)
			{
				string textY = ((System.Windows.Forms.ListViewItem)y).SubItems[columnToSortBy].Text as string;
				if(textY != null)
				{
					return StrCmpLogicalW(textX, textY);
				}
			}
			return System.Collections.Comparer.Default.Compare(x, y);			
		}
	}
}
