using System;
using System.Collections.Generic;

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
                    _ => throw new ArgumentException();
                });
            }

            return res;
        }
    }
}