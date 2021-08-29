namespace Department_of_Statistics
{
    public class Municipality
    {
        public string dptCode { get; set; }
        public string mcpCode { get; set; }
        public  string dptName { get; set; }
        public string mcpName { get; set; }
        public string type { get; set; }
        public Municipality(string[] atts)
        {
            dptCode = atts[0];
            mcpCode = atts[1];
            dptName = atts[2];
            mcpName = atts[3];
            type = atts[4];
        }

        public string toString()
        {
            string info = dptCode + "," + mcpCode + "," + dptName + "," + mcpName + "," + type;
            return info;
        }
        public string[] toStringArray()
        {
            string[] info = new string[]  {  dptCode,  mcpCode, dptName, mcpName, type  };
            return info;
        }
    }
}