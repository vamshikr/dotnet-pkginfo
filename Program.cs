using System;
using Microsoft.Build.Evaluation;
//using Microsoft.DotNet.Cli.Sln;

namespace CsProjReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string csproj_file = args[0];
            Console.WriteLine(csproj_file);
            var proj = new Project(csproj_file);
            Console.WriteLine(proj.Properties.Count);

            foreach (ProjectProperty item in proj.Properties)
            {
                Console.WriteLine("{0} = {1}", item.Name, item.EvaluatedValue);
            }
        }
    }
}
