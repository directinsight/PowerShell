// -----------------------------------------------------------------------
//  <copyright file="ExpanderButton.Generated.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
//
//  <auto-generated>
//      This code was generated by a tool. DO NOT EDIT
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// -----------------------------------------------------------------------

#region StyleCop Suppression - generated code
using System;
using System.ComponentModel;
using System.Windows;

namespace Microsoft.Management.UI.Internal
{

    /// <summary>
    /// Represents a toggle button used to expand or collapse elements.
    /// </summary>
    [Localizability(LocalizationCategory.None)]
    partial class ExpanderButton
    {
        //
        // CreateAutomationPeer
        //
        /// <summary>
        /// Create an instance of the AutomationPeer.
        /// </summary>
        /// <returns>
        /// An instance of the AutomationPeer.
        /// </returns>
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
        {
            return new ExpanderButtonAutomationPeer(this);
        }

    }
}
#endregion
