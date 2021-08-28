using System;

namespace Departamento_Administrativo
{
    internal class Municipio
	{
		private String dptCode;
		private String mcpCode;
		private String dptName;
		private String mcpName;
		private String type;
		public Municipio(String[] atts)
		{
			dptCode=atts[0];
			mcpCode = atts[1];
			dptName = atts[2]; 
			mcpName = atts[3];
			type = atts[4];
		}
		public Boolean empiezaPor(char c)
        {
			return (dptName.StartsWith(c.ToString()));
        }

        public string toString()
        {
			string info = dptCode+","+mcpCode + "," +dptName + "," +mcpName + "," +type;
			return info;
        }
    }
}