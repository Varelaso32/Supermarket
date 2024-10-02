using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Model;

namespace Supermarket.Business //Samuel Varela Morales
{
    internal class PayModeDAO
    {

        private readonly Dictionary<int, PayMode> PayModeList;
        private static int payModeSecuencial;

        public PayModeDAO()
        {
            PayModeList = new Dictionary<int, PayMode>();
            payModeSecuencial = 0;

        }//Final de clase

        public bool AddPayMode(PayMode payMode)
        {
            try
            {
                payMode.Id = ++payModeSecuencial;
                PayModeList.Add((int)payMode.Id, payMode);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;

        }//Final de clase

        public bool RemovePayMode(int id)
        {
            bool idExist = PayModeList.ContainsKey(id);
            if (idExist)
            {
                PayModeList.Remove(id);
                return true;
            }
            return false;

        }//Final de clase

        public PayMode GetPayMode(int id)
        {
            bool idExist = PayModeList.ContainsKey(id);
            if (idExist)
            {
                PayMode payMode = PayModeList[id];
                return payMode;
            }
            return null;

        }//Final de clase

        public bool UpdatePayMode(int id, PayMode payMode)
        {
            bool idExist = PayModeList.ContainsKey(id);
            if (idExist)
            {
                try
                {
                    PayModeList[id] = payMode;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;

        }//Final de clase

        public Dictionary<int, PayMode> GetPayModeList()
        {
            return PayModeList;

        }//Final de clase


    }//Final de clase

}
