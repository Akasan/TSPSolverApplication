using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPUtility
{
    class ACOAgent
    {
        public int id;
        public double distance;
        public List<int> route;
        public int rank;

        public ACOAgent(int id, int rank=-1)
        {
            this.id = id;
            this.rank = rank;
            resetAttribute();
        }

        /// <summary>
        /// 距離や経路などの属性を初期化する
        /// </summary>
        public void resetAttribute()
        {
            // インスタンス生成時にのみ実行
            if(route == null)
            {
                route = new List<int>();
            }
            distance = 0.0;
            route.Clear();
        }

        /// <summary>
        /// 次の都市を追加する
        /// </summary>
        /// <param name="cityNo">次の移動先の都市</param>
        public void appendCity(int cityNo)
        {
            route.Add(cityNo);
        }

        /// <summary>
        /// すでに訪問済みの都市かチェックする
        /// </summary>
        /// <param name="cityNo">次の移動先の都市の候補</param>
        /// <returns>未訪問の場合trueを返す</returns>
        public bool isAlreadyRegisteredCity(int cityNo)
        {
            return route.Contains(cityNo);
        }
    }
}
