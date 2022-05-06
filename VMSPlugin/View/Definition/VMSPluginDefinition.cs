using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using VideoOS.Platform;
using VideoOS.Platform.Admin;
using VideoOS.Platform.Background;
using VideoOS.Platform.Client;
using VMSPlugin;
using VMSPlugin.Repository;
using VMSPlugin.View.Definition;

namespace VAPlugin
{
    public class VMSPluginDefinition : PluginDefinition
	{
		internal protected static System.Drawing.Image _treeNodeImage;

		internal static Guid VAPluginId = new Guid("5074616E-4975-696E-796C-64696C636741");
        internal static Guid VMSOptionDialogPluginId = new Guid("6F446F4F-6C61-616C-7369-797067416974");
        internal static Guid OverlayOnROIBackgroundPluginId = new Guid("65646C72-6B79-616E-4F4F-75754F674961");
		internal static Guid VAEngineBackgroundPluginId = new Guid("42676E61-5650-756E-696F-416B676C6569");
		internal static Guid OverlayOnEventBackgroundPluginId = new Guid("726E7661-6942-5065-656E-4F6374756E72");
		internal static Guid CheckStateBackgroundPluginId = new Guid("43686563-6b53-7461-7465-4261636b6772");
		internal static Guid VAEngineKind = new Guid("5641456e-6769-6e65-4b69-6e645641456e");
		public static MySqlConnection Connection;


		#region Private fields

		private List<ItemNode> _itemNodes;
		#endregion

		#region Initialization

		static VMSPluginDefinition()
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			string name = assembly.GetName().Name;

			System.IO.Stream pluginStream = assembly.GetManifestResourceStream(name + ".Resources.AnalyticsOverlay.bmp");
			if (pluginStream != null)
				_treeNodeImage = System.Drawing.Image.FromStream(pluginStream);
		}

		public override void Init()
		{
			Connection = new MySqlConnection("Server=127.0.0.1;Database=ibg;Uid=root;Pwd=1234;SslMode=none");
			_itemNodes = new List<ItemNode>{
										 new ItemNode(VAEngineKind,
													  Guid.Empty,
													  "VAEngine", _treeNodeImage,
													  "VAEngines", _treeNodeImage,
													  Category.Text, false,
													  ItemsAllowed.One,
													  new VMSItemManager(),
													  null,
													  new List<SecurityAction>{
														  new SecurityAction("GENERIC_WRITE", "Manage"), 
														  new SecurityAction("GENERIC_READ", "Read")
													  }
											 )
									 };
		}

		public override void Close()
		{
			_itemNodes = null;
		}


		#endregion

		#region Identification Properties

		/// <summary>
		/// Gets the unique id identifying this plugin component
		/// </summary>
		public override Guid Id
		{
			get
			{
				return VAPluginId;
			}
		}

		/// <summary>
		/// This Guid can be defined on several different IPluginDefinitions with the same value,
		/// and will result in a combination of this top level ProductNode for several plugins.
		/// Set to Guid.Empty if no sharing is enabled.
		/// </summary>
		public override Guid SharedNodeId
		{
			get
			{
				return Guid.Empty;
			}
		}

		/// <summary>
		/// Define name of top level Tree node - e.g. A product name
		/// </summary>
		public override string Name
		{
            get => "Ekois"; 
        }

        /// <summary>
        /// Top level name
        /// </summary>
        public override string SharedNodeName
        {
            get { return ""; }
		}

		/// <summary>
		/// Your company name
		/// </summary>
		public override string Manufacturer
		{
			get
			{
				return "Senturian Solutions";
			}
		}

		/// <summary>
		/// Version of this plugin.
		/// </summary>
		public override string VersionString
		{
			get
			{
				return "2.1.1";
			}
		}

		/// <summary>
		/// Icon to be used on top level - e.g. a product or company logo
		/// </summary>
		public override System.Drawing.Image Icon
		{
			get { return VideoOS.Platform.UI.Util.ImageList.Images[VideoOS.Platform.UI.Util.SDK_VSIx]; }
		}

		#endregion


		#region Administration properties

		/// <summary>
		/// A list of server side configuration items in the administrator
		/// </summary>
		public override List<ItemNode> ItemNodes
		{
			get
			{
				return _itemNodes;
			}
		}

		/// <summary>
		/// A user control to display when the administrator clicks on the top TreeNode
		/// </summary>
		public override UserControl GenerateUserControl()
		{
			return null;
		}

		#endregion

		#region Client related methods and properties

		public override List<ViewItemPlugin> ViewItemPlugins
		{
			get
			{
				return new List<ViewItemPlugin>();
			}
		}

		/// <summary>
		/// An extention plugin running in the Smart Client to add more choices on the Options dialog.
		/// </summary>
		public override List<OptionsDialogPlugin> OptionsDialogPlugins
		{
			get { return new List<OptionsDialogPlugin>() { new VMSOptionDialogPlugin() }; }
		}

		/// <summary>
		/// Create and returns the background task.
		/// </summary>
		public override List<VideoOS.Platform.Background.BackgroundPlugin> BackgroundPlugins
		{
			get
			{
				// Should only create the background class first time this is accessed.
				return new List<BackgroundPlugin>() { };
			}
		}

	
		#endregion

	}
}
