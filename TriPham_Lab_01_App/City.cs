using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriPham_Lab_01_App
{
    class City
    {
        public string info { get; private set; }

        public City(Common.CityName cityName)
        {
            switch (cityName)
            {
                case Common.CityName.London:
                    this.info += "Area" + Environment.NewLine;
                    this.info += " • Greater London	1,572 km2 (607 sq mi)" + Environment.NewLine;
                    this.info += " • Urban		1,737.9 km2 (671.0 sq mi)" + Environment.NewLine;
                    this.info += " • Metro		8,382 km2 (3,236 sq mi)" + Environment.NewLine;
                    this.info += "" + Environment.NewLine;
                    this.info += "Population (2016)" + Environment.NewLine;
                    this.info += " • Greater London	8,787,892" + Environment.NewLine;
                    this.info += " • Density		5,590/km2 (14,500/sq mi)" + Environment.NewLine;
                    this.info += " • Urban		9,787,426" + Environment.NewLine;
                    this.info += " • Metro		14,040,163" + Environment.NewLine;
                    break;

                case Common.CityName.Paris:
                    this.info += "Area" + Environment.NewLine;
                    this.info += " • City	105.4 km2 	(40.7 sq mi)" + Environment.NewLine;
                    this.info += " • Urban		2,845 km2 (1,098 sq mi)" + Environment.NewLine;
                    this.info += " • Metro		17,174.4 km2 (6,631.1 sq mi)" + Environment.NewLine;
                    this.info += "" + Environment.NewLine;
                    this.info += "Population (2015)" + Environment.NewLine;
                    this.info += " • City			2,206,488" + Environment.NewLine;
                    this.info += " • Rank	1st in France" + Environment.NewLine;
                    this.info += " • Density		21,000/km2 (54,000/sq mi)" + Environment.NewLine;
                    this.info += " • Urban		10,601,122" + Environment.NewLine;
                    this.info += " • Urban density	3,700/km2 (9,700/sq mi)" + Environment.NewLine;
                    this.info += " • Metro		12,405,426" + Environment.NewLine;
                    this.info += " • Metro density	720/km2 (1,900/sq mi)" + Environment.NewLine;
                    break;

                case Common.CityName.Prague:
                    this.info += "Area" + Environment.NewLine;
                    this.info += " • Urban		496 km2 (192 sq mi)" + Environment.NewLine;
                    this.info += "Highest elevation	399 m (1,309 ft)" + Environment.NewLine;
                    this.info += "Lowest elevation	177 m (581 ft)" + Environment.NewLine;
                    this.info += "" + Environment.NewLine;
                    this.info += "Population (2017)" + Environment.NewLine;
                    this.info += " • Capital city		1,280,508" + Environment.NewLine;
                    this.info += " • Metro		2,156,097" + Environment.NewLine;
                    break;

                case Common.CityName.St_Petersbug:
                    this.info += "Area " + Environment.NewLine;
                    this.info += " • Total		1,439 km2 (556 sq mi)" + Environment.NewLine;
                    this.info += "Area rank		82nd" + Environment.NewLine;
                    this.info += "" + Environment.NewLine;
                    this.info += "Population (2017 est.)" + Environment.NewLine;
                    this.info += " • Total		5,323,300 (permanent residents within city limits)[6]" + Environment.NewLine;
                    break;
            }
        }
    }
}
