using System;
using System.IO;
using System.Reflection;

namespace PolyWorksScriptExecutionSample
{
    class Program
    {
        static void Main()
        {
            var path = Assembly.GetExecutingAssembly().Location;
            var directory = Path.GetDirectoryName(path);
            PolyWorks pw = new PolyWorks();
            pw.ScriptExecuteFromFile(Path.Combine(directory, "PolyWorksScriptSample.pwmacro"));
        }
    }
}
