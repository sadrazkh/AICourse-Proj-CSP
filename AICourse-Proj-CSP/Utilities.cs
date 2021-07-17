using System;
using System.Collections.Generic;
using System.Linq;
using AICourse_Proj_CSP.Input;

namespace AICourse_Proj_CSP
{
    public static class Utilities
    {
        public static List<bool> HaveRelations(this string values)
        {
            var res = new List<bool>();
            foreach (var value in values)
            {
                res.Add(value switch
                {
                    '0' => false,
                    '1' => true,
                    _ => throw new ArgumentException(),
                });
            }

            return res;
        }

        public static bool ValidateColor(this InputNode node, string color)
            => node.RelationNodes.All(c => c.Color != color);

        public static bool ValidateColor2(this InputNode node, string color)
            => !node.CantHaveTheseColor.Contains(color);

        public static void UpdateNodes(this List<InputNode> nodes, InputNode updatedNode)
        {
            foreach (var node in nodes)
            {
                if (node.RelationNodes.FirstOrDefault(c => c.Name == updatedNode.Name) != null)
                {
                    node.RelationNodes.First(c => c.Name == updatedNode.Name).Color = updatedNode.Color;
                }
            }
        }

        public static void UpdateNodes2(this List<InputNode> nodes, InputNode updatedNode)
        {
            foreach (var node in nodes)
            {
                if (node.RelationNodes.FirstOrDefault(c => c.Name == updatedNode.Name) != null)
                {
                    node.CantHaveTheseColor.Add(updatedNode.Color);
                }
            }
        }
    }
}