//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by NHibernate.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;

namespace MyFramework.Common.NHibernate.Domain
{
	/// <summary>
	/// a class mapping for the table: product
	/// </summary>
	public  partial class Product 
	{

	#region private fields
		Guid _id;	
		String _name;	
		String _category;	
		Decimal? _price;	
	#endregion
		
	#region getter/setters		
		/// <summary>
		///		
		/// </summary>
		public virtual Guid Id
		{
			get{ return _id; }
			set{ _id = value; }
		}
		/// <summary>
		///		
		/// </summary>
		public virtual String Name
		{
			get{ return _name; }
			set{ _name = value; }
		}
		/// <summary>
		///		
		/// </summary>
		public virtual String Category
		{
			get{ return _category; }
			set{ _category = value; }
		}
		/// <summary>
		///		
		/// </summary>
		public virtual Decimal? Price
		{
			get{ return _price; }
			set{ _price = value; }
		}
	#endregion
	}
}