using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FundsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class FundsService : IFundsService
    {

        BL.FundsReader fundsReader = new BL.FundsReader();

        public List<FundInfo> GetFundsBySchemeCodeList(List<int> list)
        {
            return fundsReader.GetFundsBySchemeCodeList(list);
        }

        public List<FundInfo> GetFundsByFundHouse(string fundHouse)
        {
            return fundsReader.GetFundsByFundHouse(fundHouse);
        }

        public List<FundInfo> GetFundsBySchemeType(string schemeType)
        {
            return fundsReader.GetFundsBySchemeType(schemeType);
        }

        public List<FundInfo> GetFundsBySchemeTypeAndFundHouse(string schemeType, string fundHouse)
        {
            return fundsReader.GetFundsBySchemeTypeAndFundHouse(schemeType, fundHouse);
        }

        public List<string> GetAllFundHouses()
        {
            return fundsReader.GetAllFundHouses();
        }

        public List<string> GetAllSchemeTypes()
        {
            return fundsReader.GetAllSchemeTypes();
        }

        public string ReadStringFile()
        {
            return fundsReader.ReadStringFile();
        }

        public List<FundInfo> GetAllFundsData()
        {
            return fundsReader.GetAllFundsData();
        }
        
        
    }
}
