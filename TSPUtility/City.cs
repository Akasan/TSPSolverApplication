using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPUtility
{
    public class City
    {
        /// <summary>
        /// Pixel値のX座標
        /// </summary>
        public int i;

        /// <summary>
        /// Pixel値Y座標
        /// </summary>
        public int j;

        public City(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        /// <summary>
        /// 二点間の距離を計算する
        /// </summary>
        /// <param name="otherPixel">距離を計算したい点</param>
        /// <returns></returns>
        public double calculateDistance(City otherPixel)
        {
            double distance = Math.Pow(Math.Pow(this.i - otherPixel.i, 2) + Math.Pow(this.j - otherPixel.j, 2), 0.5);
            return distance;
        }
    }

    public class Cities
    {
        /// <summary>
        /// すべての都市情報を保持する
        /// </summary>
        public List<City> cities;
        public double[,] distanceArray;

        public Cities()
        {
            cities = new List<City>();
        }

        public City this[int i]
        {
            get { return cities[i]; }
        }

        public int Count()
        {
            return cities.Count();
        }

        public void Add(City city)
        {
            cities.Add(city);
        }

        /// <summary>
        /// 年を追加する
        /// </summary>
        /// <param name="city">追加する都市</param>
        public void appendCity(City city)
        {
            cities.Add(city);
        }

        public void calculateDistanceArray()
        {
            int i, j;
            int cityNum = cities.Count();
            distanceArray = new double[cityNum, cityNum];

            for (i=0; i< cityNum; i++)
            {
                distanceArray[i, 0] = 0.0;
                distanceArray[0, i] = 0.0;

                for (j=i+1; j< cityNum; j++)
                {
                    distanceArray[i, j] = cities[i].calculateDistance(cities[j]);
                    distanceArray[j, i] = distanceArray[i, j];
                }
            }
        }
    }
}
