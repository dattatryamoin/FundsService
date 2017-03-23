using BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FundsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFundsService
    {

        [OperationContract]
        List<FundInfo> GetFundsBySchemeCodeList(List<int> list);

        [OperationContract]
        List<FundInfo> GetFundsByFundHouse(string fundHouse);

        [OperationContract]
        List<FundInfo> GetFundsBySchemeType(string schemeType);

        [OperationContract]
        List<FundInfo> GetFundsBySchemeTypeAndFundHouse(string schemeType, string fundHouse);

        [OperationContract]
        List<string> GetAllFundHouses();

        [OperationContract]
        List<string> GetAllSchemeTypes();

        [OperationContract]
        string ReadStringFile();

        [OperationContract]
        List<FundInfo> GetAllFundsData();

    }





































    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
