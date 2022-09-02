using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Data
{
    public class TrainingProductManager
    {
        public List<TrainingProduct> Get(TrainingProduct entity) 
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret = CreateMockData();

            if (!string.IsNullOrEmpty(entity.ProductName)) 
            {
                ret = ret.FindAll(p => p.ProductName.ToLower().StartsWith(entity.ProductName, StringComparison.CurrentCultureIgnoreCase));
            }

            return ret;
        }

        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret.Add(new TrainingProduct {
                ProductId = 1,
                ProductName = "Extending Bootstrap with Css, Javascript and jQuery",
                IntroductionDate = Convert.ToDateTime("03/11/2022"),
                Url = "www.google.pt",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct
            {
                ProductId = 2,
                ProductName = "hello word",
                IntroductionDate = Convert.ToDateTime("03/11/2022"),
                Url = "www.google.pt",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct
            {
                ProductId = 3,
                ProductName = "MVC",
                IntroductionDate = Convert.ToDateTime("03/11/2022"),
                Url = "www.google.pt",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct
            {
                ProductId = 4,
                ProductName = "java",
                IntroductionDate = Convert.ToDateTime("03/11/2022"),
                Url = "www.google.pt",
                Price = Convert.ToDecimal(29.00)
            });
            return ret;
        }
    }
}
