using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Forms;

namespace UIA.Extensions.AutomationProviders
{
    public class ControlProvider : AutomationProvider
    {
        public readonly Control Control;

        public ControlProvider(Control control)
        {
            Control = control;
        }

        public override string Id
        {
            get { return Control.Name; }
        }

        public  override IRawElementProviderSimple HostRawElementProvider
        {
            get { return AutomationInteropProvider.HostProviderFromHandle(Control.Handle); }
        }
    }
}
