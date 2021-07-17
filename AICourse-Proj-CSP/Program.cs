using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AICourse_Proj_CSP.Input;

namespace AICourse_Proj_CSP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello Please type File Path!");
            //var path = Console.ReadLine()?.ToString();
            //Console.WriteLine("Hello Please type File Name!");
            //var name = Console.ReadLine()?.ToString();

            var inputObj = new InputHandler("");
            var input = inputObj.CreateNode();
            var lines = new List<string>();
            var color = input.Colors;
            var nodes = input.InputNodes;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Normal
            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < color.Count; j++)
                {
                    if (nodes[i].ValidateColor(color[j]))
                    {
                        nodes[i].Color = color[j];
                        nodes.UpdateNodes(nodes[i]);
                        break;
                    }
                }
            }

            // With DataStructures
            //for (int i = 0; i < nodes.Count; i++)
            //{
            //    for (int j = 0; j < color.Count; j++)
            //    {
            //        if (nodes[i].ValidateColor(color[j]))
            //        {
            //            nodes[i].Color = color[j];
            //            nodes.UpdateNodes(nodes[i]);
            //            break;
            //        }
            //    }
            //}

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            

            if (nodes.Any(c => c.Color == null))
            {
                Console.WriteLine("NO");
                lines.Add("NO");
            }
            else
            {
                Console.WriteLine($"YES , RunTime {ts}");
                lines.Add($"YES , RunTime {ts}");
            }

            foreach (var node in nodes)
            {
                Console.WriteLine($"{node.Name} : {node.Color}");
                lines.Add($"{node.Name} : {node.Color}");
            }
            await File.WriteAllLinesAsync("output.txt", lines);
            Console.ReadKey();
        }

    }

}
