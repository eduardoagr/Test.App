using System;

namespace Com.Opencsv.Bean {

	[global::Android.Runtime.Annotation ("com.opencsv.bean.CsvBind")]
	public partial class CsvBindAttribute : Attribute
	{
		[global::Android.Runtime.Register ("required")]
		public bool Required { get; set; }

	}
}
