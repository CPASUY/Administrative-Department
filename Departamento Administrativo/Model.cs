namespace Departamento_Administrativo
{
    internal class Model
    {
        private Municipio[] municipios;
        private int i;
        public Model(int mcps)
        {
            municipios = new Municipio[mcps];
            i = 0;
        }
        public void addMunicipio(string[] atts)
        {
            if (i < municipios.Length)
            {
                Municipio newm = new Municipio(atts);
                municipios[i] = newm;
                i++;
            }
        }
        public string[] municipiosCon(char c)
        {
            int k = 0;
            string[] info = new string[municipios.Length];
            for (int j = 0; j < municipios.Length; j++)
            {
                if (municipios[j].empiezaPor(c))
                {
                    info[k] = municipios[j].toString();
                    k++;
                }
            }
            string[] result = new string[k];

            for(int l=0; l<k;l++)
            {
                result[l] = info[l];
            }
            return info;
        }
    }
}