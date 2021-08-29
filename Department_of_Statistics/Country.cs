using System;
using System.Collections.Generic;
using System.Linq;

namespace Department_of_Statistics
{
    public class Country
    {
        List<Department> departments;
        public Country()
        {
            departments  = new List<Department>();
        }
        public void addMunicipality(string[] atts)
        {
            string dpt = atts[0];
            bool  exists   =   false;
            int k  =  0;
            for(int i=0; i < departments.Count; i++)
            {
                if (departments[i].getCode().Equals(dpt))
                {
                    exists   =   true;
                    departments[i].addMunicipality(atts);
                    break;
                }
            }
            if (!exists)
            {
                departments.Add(new Department(atts[0], atts[2]));
                departments[departments.Count-1].addMunicipality(atts);
            }
        }

        public List<Municipality> getAllMunicipalities()
        {
            List<Municipality> result = new List<Municipality>();
            for(int i=0; i < departments.Count; i++)
            {
                Department dpt  = departments[i];
                for (int j = 0; j < dpt.getMunicipalities().Count; j++)
                {
                    result.Add(dpt.getMunicipalities()[j]);
                }
            }
            return result;
        }
        public List<Municipality> beginsWith(string str)
        {
            List<Municipality> result = new List<Municipality>();
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].getName().StartsWith(str))
                {
                    Department dpt = departments[i];
                    for (int j = 0; j < dpt.getMunicipalities().Count; j++)
                    {
                        result.Add(dpt.getMunicipalities()[j]);
                    }
                }
            }
            return result;
        }


    }
}