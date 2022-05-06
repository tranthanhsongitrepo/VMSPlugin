using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoOS.Platform;
using VideoOS.Platform.Admin;

namespace VAPlugin
{
    class VMSItemManager : ItemManager
    {
		#region Constructors

		public VMSItemManager()
			: base()
		{
			InitVAEngineItem();
		}

		private void InitVAEngineItem()
		{
			List<Item> checkCurrent = GetItems();
			if (checkCurrent.Count == 0)
			{
				if (EnvironmentManager.Instance.EnvironmentType == EnvironmentType.Service)
				{
					FQID fqid = new FQID(EnvironmentManager.Instance.MasterSite.ServerId);
					fqid.ObjectId = Guid.NewGuid();
					fqid.Kind = VMSPluginDefinition.VAEngineKind;

					CurrentItem = new Item(fqid, "VAEgnine Plugin State");
				}
				else
					CurrentItem = null;
			}
			else
			{
				CurrentItem = checkCurrent[0];
			}
		}

		#endregion

		#region Configuration Access Methods

		/// <summary>
		/// Returns a list of all Items from a specific server.
		/// </summary>
		/// <param name="serverId">The server managing the Items</param>
		/// <returns>A list of items.  Allowed to return null if no Items found.</returns>
		public override List<Item> GetItems(Item parentItem)
		{
			//All items in this sample are stored with the Video, therefor no ServerIs is used.
			List<Item> items = Configuration.Instance.GetItemConfigurations(VMSPluginDefinition.VAPluginId, parentItem, VMSPluginDefinition.VAEngineKind);
			return items;
		}

		/// <summary>
		/// Returns the Item defined by the FQID. Will return null if not found.
		/// </summary>
		/// <param name="fqid">Fully Qualified ID of an Item</param>
		/// <returns>An Item</returns>
		public override Item GetItem(FQID fqid)
		{
			Item item = Configuration.Instance.GetItemConfiguration(VMSPluginDefinition.VAPluginId, fqid.Kind, fqid.ObjectId);
			return item;
		}

		public override List<Item> GetItems()
		{
			//All items in this sample are stored with the Video, therefor no ServerIs is used.
			List<Item> items = Configuration.Instance.GetItemConfigurations(VMSPluginDefinition.VAPluginId, null, VMSPluginDefinition.VAEngineKind);
			return items;
		}

		public bool VAPluginStarted()
        {
			if (CurrentItem == null)
				return false;
			if (!(CurrentItem.Properties.ContainsKey("VAPlugin") &&
				CurrentItem.Properties.ContainsKey("DB") &&
				CurrentItem.Properties.ContainsKey("License") &&
				CurrentItem.Properties.ContainsKey("VAPlugin.Bbx.AddToMS")))
				return false;
			
			return false;
		}

		#endregion
	}
}
