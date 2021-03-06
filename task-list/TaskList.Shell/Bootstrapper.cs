﻿using Prism.Mef;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using TaskList.Projects;
using TaskList.Tasks;

namespace TaskList.Shell
{
    class Bootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }

        protected override void ConfigureAggregateCatalog()
        {
            //this needs to be replaced with a directory module, to allow weak coupled modules
            base.ConfigureAggregateCatalog();
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(GetType().Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ProjectsModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(TasksModule).Assembly));
        }

        protected override void InitializeShell()
        {            
            Application.Current.MainWindow.Show();
        }
    }
}
