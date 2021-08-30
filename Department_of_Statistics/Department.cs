using System.Collections.Generic;

namespace Department_of_Statistics
{
 
    internal class Department
    {
        //Atributes
        public string name { get; set; }
        public string id { get; set; }

        public int numMunicipalities;
        public List<Municipality> municipalities { get; set; }

        public Department(string id, string name)
        {
            municipalities = new List<Municipality>();
            this.name = name;
            this.id = id;
            numMunicipalities = 0;
        }
        public void addMunicipality(string [] atributes)
        {
            Municipality newMunicipality = new Municipality(atributes);
            municipalities.Add(newMunicipality);
        }
        public string getCode()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public List<Municipality> getMunicipalities()
        {
            return municipalities;
        }
        public int getNUm()
        {
            return municipalities.Count;
        }
    }
}