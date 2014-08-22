using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Web;
using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using SelectedHotelsModel;

namespace Cowrie.BoatDetails.Components
{
    public class BoatDetailsController : ISearchable
	{
		#region ISearchable Members

		/// <summary>
		/// Implements the search interface required to allow DNN to index/search the content of your
		/// module
		/// </summary>
		/// <param name="modInfo"></param>
		/// <returns></returns>
		public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(ModuleInfo modInfo)
		{
			SearchItemInfoCollection searchItems = new SearchItemInfoCollection();
		    using (SelectedHotelsEntities db = new SelectedHotelsEntities())
		    {
				// TODO: implement!
            }

			return searchItems;
		}

		#endregion
	}
}
