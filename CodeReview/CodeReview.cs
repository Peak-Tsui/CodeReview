//------------------------------------------------------------------------------
// <copyright file="CodeReview.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Globalization;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using EnvDTE;
using EnvDTE80;

namespace CodeReview
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class CodeReview
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x1001;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("462737cc-1d6c-4947-833c-a0c0a806dbe1");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeReview"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private CodeReview(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                //var menuCommandID = new CommandID(CommandSet, CommandId);
                //var menuItem = new MenuCommand(this.MenuItemCallback, menuCommandID);
                //commandService.AddCommand(menuItem);
                var toolBarCommandId = new CommandID(CommandSet, CommandId);
                OleMenuCommand btnRecordToolBtn = new OleMenuCommand(new EventHandler(this.ToolBarCallback), toolBarCommandId);
                commandService.AddCommand(btnRecordToolBtn);

            }
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static CodeReview Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package)
        {
            Instance = new CodeReview(package);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void ToolBarCallback(object sender, EventArgs e)
        {
            RecordForm form = new RecordForm(DTE2AppObject);

            if (form.InitSuccess)
                form.ShowDialog();
        }

        /***********************************/
        static DTE2 _applicationObject;
        private DTE2 DTE2AppObject {
            get
            {
                if (_applicationObject == null)
                {
                    _applicationObject = ServiceProvider.GetService(typeof(DTE)) as DTE2;
                }
                return _applicationObject;
            }
        }
    }
}
