using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using ShipmentEntry;

[assembly: WorkflowRunnerServiceAttribute(typeof(ShipmentEntry.WorkflowRunnerService))]
namespace ShipmentEntry
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the BBLC Module.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void BBLC_Module(ShipmentEntry.ProcessInfo StatusDic, string BBLC_NO, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"BBLC Module.xaml", new Dictionary<string, object> { { "StatusDic", StatusDic }, { "BBLC_NO", BBLC_NO } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Create-Shipment-Entry.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Create_Shipment_Entry(string Invoice_Number, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Create-Shipment-Entry.xaml", new Dictionary<string, object> { { "Invoice_Number", Invoice_Number } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Lines_LandCostManagement.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Lines_LandCostManagement(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Lines_LandCostManagement.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Navigate-All_LCM-Shipments.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Navigate_All_LCM_Shipments(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Navigate-All_LCM-Shipments.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Navigate-BBLC.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Navigate_BBLC(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Navigate-BBLC.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the PartyName.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void PartyName(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"PartyName.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Shipment-Lines_Landed-Cost-Management.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Shipment_Lines_Landed_Cost_Management(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Shipment-Lines_Landed-Cost-Management.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Shipments.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Shipments(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Shipments.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}