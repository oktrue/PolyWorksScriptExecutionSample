using System;
using IMInspectLib;

namespace PolyWorksScriptExecutionSample
{
    class PolyWorks
    {
        private IIMCommandCenter _imCommandCenter;
        private IMInspect _imInspect;
        private IIMInspectProject _imInspectProject;

        public PolyWorks()
        {
            _imInspect = new IMInspect();
            if (_imInspect == null) throw new Exception("Unable to connect to PolyWorks instance.");
            _imInspect.ProjectGetCurrent(out _imInspectProject);
            if (_imInspectProject == null) throw new Exception("Unable to get PolyWorks current project.");
        }

        public void ScriptExecuteFromFile(string script, string args = "")
        {
            _imCommandCenter = null;
            _imInspectProject.CommandCenterCreate(out _imCommandCenter);
            if (_imCommandCenter == null) throw new Exception("Unable to initialize PolyWorks command center.");
            _imCommandCenter.ScriptExecuteFromFile(script, args);
        }
    }
}
