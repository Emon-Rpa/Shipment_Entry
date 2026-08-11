using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace ShipmentEntry
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        private Lazy<global::ShipmentEntry.WorkflowRunnerService> _workflowRunnerServiceLazy;
        private Lazy<ConnectionsManager> _connectionsManagerLazy;
        private Lazy<global::ShipmentEntry.WorkflowRunnerService> _shipmentEntryLazy;
        public CodedWorkflow()
        {
            _ = new System.Type[]
            {
                typeof(UiPath.Core.Activities.API.ISystemService),
                typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)
            };
            _workflowRunnerServiceLazy = new Lazy<global::ShipmentEntry.WorkflowRunnerService>(() => new global::ShipmentEntry.WorkflowRunnerService(this.services));
#pragma warning disable
            _connectionsManagerLazy = new Lazy<ConnectionsManager>(() => new ConnectionsManager(serviceContainer));
#pragma warning restore
            _shipmentEntryLazy = new Lazy<global::ShipmentEntry.WorkflowRunnerService>(() => new global::ShipmentEntry.WorkflowRunnerService(this.services));
        }

        protected global::ShipmentEntry.WorkflowRunnerService workflows => _workflowRunnerServiceLazy.Value;
        protected ConnectionsManager connections => _connectionsManagerLazy.Value;
#pragma warning disable
        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>() ; }
#pragma warning restore
#pragma warning disable
        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>() ; }
#pragma warning restore
        protected global::ShipmentEntry.WorkflowRunnerService shipmentEntry => _shipmentEntryLazy.Value;
    }
}