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
        /// Invokes the Create Shipment In BBLC And CMLC.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Create_Shipment_In_BBLC_And_CMLC(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Create Shipment In BBLC And CMLC.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
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
        public void Main(string Invoice_No, string Invoice_Date, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { { "Invoice_No", Invoice_No }, { "Invoice_Date", Invoice_Date } }, default, isolated, default, GetAssemblyName());
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

        /// <summary>
        /// Invokes the Shippment_Create_Form.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Shippment_Create_Form(string Invoice_No, string Invoice_Date, string Shipment_Status, string Shipment_Mode, string Shippment_No, string IncoTerm, string Freight_Cost, string Other_Charges, string No_Of_Packages, string UOM, string Port_Of_Landing, string Port_Of_Discharge, string NN_Copy_Rcv_Date, string Endorsement, string M_Vseel_Voyage, string Container_And_Seal_No, string Container_Size, string Container_Status, string Weight, string CBM, string Transport_Doc_No, string Transport_Doc_No_Date, string C_And_F_Agent_Number, string Courier_Name_B2B_Box, string ETD_Origin, string ATD_Origin, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Shippment_Create_Form.xaml", new Dictionary<string, object> { { "Invoice_No", Invoice_No }, { "Invoice_Date", Invoice_Date }, { "Shipment_Status", Shipment_Status }, { "Shipment_Mode", Shipment_Mode }, { "Shippment_No", Shippment_No }, { "IncoTerm", IncoTerm }, { "Freight_Cost", Freight_Cost }, { "Other_Charges", Other_Charges }, { "No_Of_Packages", No_Of_Packages }, { "UOM", UOM }, { "Port_Of_Landing", Port_Of_Landing }, { "Port_Of_Discharge", Port_Of_Discharge }, { "NN_Copy_Rcv_Date", NN_Copy_Rcv_Date }, { "Endorsement", Endorsement }, { "M_Vseel_Voyage", M_Vseel_Voyage }, { "Container_And_Seal_No", Container_And_Seal_No }, { "Container_Size", Container_Size }, { "Container_Status", Container_Status }, { "Weight", Weight }, { "CBM", CBM }, { "Transport_Doc_No", Transport_Doc_No }, { "Transport_Doc_No_Date", Transport_Doc_No_Date }, { "C_And_F_Agent_Number", C_And_F_Agent_Number }, { "Courier_Name_B2B_Box", Courier_Name_B2B_Box }, { "ETD_Origin", ETD_Origin }, { "ATD_Origin", ATD_Origin } }, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}