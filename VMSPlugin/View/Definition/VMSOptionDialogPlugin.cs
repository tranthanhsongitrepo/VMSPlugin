using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAPlugin;
using VideoOS.Platform;
using VideoOS.Platform.Client;
using VideoOS.Platform.Messaging;

namespace VMSPlugin.View.Definition
{
    class VMSOptionDialogPlugin : OptionsDialogPlugin
    {
        public override Guid Id => VMSPluginDefinition.VMSOptionDialogPluginId;

        public override string Name => "Senturian";

        public override void Close()
        {
            EnvironmentManager.Instance.Log(false, "VAOptionDialogPlugin", "Closed");
        }

        public override OptionsDialogUserControl GenerateUserControl()
        {
            return new VMSPluginView();
        }

        public override void Init()
        {
            EnvironmentManager.Instance.Log(false, "VAOptionDialogPlugin", "Init");
            LoadProperties(true);
            EnvironmentManager.Instance.EnableConfigurationChangedService = true;
        }

        public override bool SaveChanges()
        {
            return SaveProperties(true);
        }
    }
}
