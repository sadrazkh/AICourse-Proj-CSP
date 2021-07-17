using System.Collections.Generic;

namespace AICourse_Proj_CSP.Input
{
    public class InputNode
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public List<InputNode> RelationNodes { get; set; }
    }
}