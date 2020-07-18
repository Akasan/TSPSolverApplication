using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace TSPUtility
{
    class ConfigurationLoaderBase
    {
        public IEnumerable<XElement> xmlData;

        public ConfigurationLoaderBase(string configurationFileName)
        {
            XElement xmlDataLoader = XElement.Load(configurationFileName);
            xmlData = from item in xmlDataLoader.Elements("configuration") select item;
        }
    }

    class AcoConfigurationLoader: ConfigurationLoaderBase
    {
        public double alpha, beta, rho;
        public double initPheromone;

        public AcoConfigurationLoader(string configurationFileName): base(configurationFileName) { }

        private void setAttribute()
        {
            foreach(XElement data in xmlData.Elements("parameter"))
            {

            }
        }
    }
}
