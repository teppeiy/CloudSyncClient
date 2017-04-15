﻿//-------------------------------------------------------------------------------------------------
// <copyright file="IDirectoryChangeManager.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//
// <summary>
//     Differential Query sample application.
// 
//     This source is subject to the Sample Client End User License Agreement
//     included in this project.
// </summary>
//
// <remarks />
//
// <disclaimer>
//     THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
//     EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
//     WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </disclaimer>
//-------------------------------------------------------------------------------------------------

namespace CloudSyncClient
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Defines methods to call the Differential Query service and process the results.
    /// </summary>
    public interface IDirectoryChangeManager
    {
        /// <summary>
        /// Calls the Differential Query service and processes the result.
        /// </summary>
        void DifferentialQuery(string aadDomain, string appPrincipalId, string appPrincipalPassword);

        /// <summary>
        /// Retrieves company name for a set of credentials.
        /// </summary>
        string GetCompanyName(string aadDomain, string appPrincipalId, string appPrincipalPassword, ref string displayName);

        /// <summary>
        /// Processes the specified AAD object.
        /// </summary>
        /// <param name="change">Directory change representing an AAD object.</param>
        /// <exception cref="ArgumentNullException"><paramref name="change"/> is <see langref="null"/>.</exception>
        /// <exception cref="ArgumentException">Invalid directory change.</exception>
        void HandleChange(Dictionary<string, object> change, string aadDomain, string appPrincipalId, string appPrincipalPassword);
    }
}
