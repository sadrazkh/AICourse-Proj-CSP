using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AICourse_Proj_CSP.Input
{
    public class InputHandler
    {
        private readonly string _rootPhat;
        private readonly string _fileName;

        public InputHandler(string rootPhat, string fileName)
        {
            _rootPhat = rootPhat;
            _fileName = fileName;
        }
        public InputHandler(string rootPhat)
        {
            _rootPhat = rootPhat;
            _fileName = "input.txt";
        }

        public Task<InputNode> CreateNode()
        {
            throw new NotImplementedException();
            try
            {
                if (File.Exists(_rootPhat + _fileName))
                {
                    var res = new InputModel();
                    List<string> inputs = File.ReadAllLines(_rootPhat + _fileName).ToList();
                    res.Colors = inputs[0].Split(",").ToList();
                    var lineCount = inputs.Count - 1;

                    var nodes = new List<InputNode>();
                    for (int i = 1; i < lineCount; i++)
                    {
                        nodes.Add(new InputNode() {Name = NodeName.GetNodeName()});
                    }

                    for (int i = 0; i < lineCount-1; i++)
                    {
                        var relation = inputs[i + 1].HaveRelations();

                    }


                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
