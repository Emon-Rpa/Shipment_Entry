using ShipmentEntry.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace ShipmentEntry
{
    public class ProcessInfo
    {
        public bool Contract { get; set; }
        public bool BBLC { get; set; }
        public string Status { get; set; }

        public ProcessInfo()
        {
            Contract = false;
            BBLC = false;
            Status = "";
        }
    }
}