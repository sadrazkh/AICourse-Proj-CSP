namespace AICourse_Proj_CSP.Input
{
    public static class NodeName
    {
        private static int i = 0;
        private static readonly string[] names = new string[]
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z"
        };

        public static string GetNodeName() => names[i++];
        public static string GetNodeName(int y) => names[y];
    }
}