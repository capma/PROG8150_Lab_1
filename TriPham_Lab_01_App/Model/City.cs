using System;

namespace TriPham_Lab_01_App
{
    class City
    {
        #region Properties

        public string Info { get; private set; }
        public Common.CityName CityName { get; private set; }
        public int Top { get; private set; }
        public int Left { get; private set; }
        public int Right { get; private set; }
        public int Bottom { get; private set; }
        #endregion

        #region Constructor

        public City(Common.CityName CityName)
        {
            this.CityName = CityName;
            SetCityInfo();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="cityName"></param>
        public City(Common.CityName CityName, int Top, int Left, int Right, int Bottom)
        {
            this.CityName = CityName;
            this.Top = Top;
            this.Left = Left;
            this.Right = Right;
            this.Bottom = Bottom;

            SetCityInfo();
        }

        #endregion

        #region Methods

        /// <summary>
        /// SetCityInfo
        /// </summary>
        protected void SetCityInfo()
        {
            switch (this.CityName)
            {
                case Common.CityName.London:
                    this.Info += "Area" + Environment.NewLine;
                    this.Info += " • Greater London	1,572 km2 (607 sq mi)" + Environment.NewLine;
                    this.Info += " • Urban		1,737.9 km2 (671.0 sq mi)" + Environment.NewLine;
                    this.Info += " • Metro		8,382 km2 (3,236 sq mi)" + Environment.NewLine;
                    this.Info += "" + Environment.NewLine;
                    this.Info += "Population (2016)" + Environment.NewLine;
                    this.Info += " • Greater London	8,787,892" + Environment.NewLine;
                    this.Info += " • Density		5,590/km2 (14,500/sq mi)" + Environment.NewLine;
                    this.Info += " • Urban		9,787,426" + Environment.NewLine;
                    this.Info += " • Metro		14,040,163" + Environment.NewLine;
                    break;

                case Common.CityName.Paris:
                    this.Info += "Area" + Environment.NewLine;
                    this.Info += " • City	                105.4 km2 (40.7 sq mi)" + Environment.NewLine;
                    this.Info += " • Urban		2,845 km2 (1,098 sq mi)" + Environment.NewLine;
                    this.Info += " • Metro		17,174.4 km2 (6,631.1 sq mi)" + Environment.NewLine;
                    this.Info += "" + Environment.NewLine;
                    this.Info += "Population (2015)" + Environment.NewLine;
                    this.Info += " • City                       2,206,488" + Environment.NewLine;
                    this.Info += " • Rank	                1st in France" + Environment.NewLine;
                    this.Info += " • Density		21,000/km2 (54,000/sq mi)" + Environment.NewLine;
                    this.Info += " • Urban		10,601,122" + Environment.NewLine;
                    this.Info += " • Urban density	3,700/km2 (9,700/sq mi)" + Environment.NewLine;
                    this.Info += " • Metro		12,405,426" + Environment.NewLine;
                    this.Info += " • Metro density	720/km2 (1,900/sq mi)" + Environment.NewLine;
                    break;

                case Common.CityName.Prague:
                    this.Info += "Area" + Environment.NewLine;
                    this.Info += " • Urban		496 km2 (192 sq mi)" + Environment.NewLine;
                    this.Info += "Highest elevation	399 m (1,309 ft)" + Environment.NewLine;
                    this.Info += "Lowest elevation	177 m (581 ft)" + Environment.NewLine;
                    this.Info += "" + Environment.NewLine;
                    this.Info += "Population (2017)" + Environment.NewLine;
                    this.Info += " • Capital city           1,280,508" + Environment.NewLine;
                    this.Info += " • Metro		2,156,097" + Environment.NewLine;
                    break;

                case Common.CityName.St_Petersbug:
                    this.Info += "Area " + Environment.NewLine;
                    this.Info += " • Total		1,439 km2 (556 sq mi)" + Environment.NewLine;
                    this.Info += "Area rank		82nd" + Environment.NewLine;
                    this.Info += "" + Environment.NewLine;
                    this.Info += "Population (2017 est.)" + Environment.NewLine;
                    this.Info += " • Total		5,323,300 " + Environment.NewLine;
                    break;
            }
        }

        #endregion

    }
}
