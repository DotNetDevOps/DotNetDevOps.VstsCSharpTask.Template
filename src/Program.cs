using CommandLine;
using SInnovations.VSTeamServices.TaskBuilder.Attributes;
using SInnovations.VSTeamServices.TaskBuilder.ConsoleUtils;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: Guid("00000000-0000-0000-0000-000000000000")]
[assembly: AssemblyDescription("Generate Visual Studio Team Services Tasks using S-Innovations Task Library")]

namespace DotNetDevOps.VstsCSharpTask.Template
{

    [EntryPoint("MyHelloWorldFromCSharp")]
    public class ProgramOptions
    {

        [Option("Echo", Default = "Hello World")]
        public string Echo { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var options = ConsoleHelper.ParseAndHandleArguments<ProgramOptions>("Running Echo", args);

            Console.WriteLine(options.Echo);
        }
    }
}
