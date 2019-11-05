using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TCPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TCPService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TCPService.svc or TCPService.svc.cs at the Solution Explorer and start debugging.
    public class TCPService : ITCP
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        public string TodayProgram(string name)
        {
            DateTime ClockInfoFromSystem = DateTime.Now;
            int day = (int)ClockInfoFromSystem.DayOfWeek;
            string todayProgram = string.Empty;
            if (day >= 1 && day <= 5)
            {
                todayProgram = string.Concat(name, " Enjoy Working day");
            }
            else if (day >= 6 && day <= 7)
            {
                todayProgram = string.Concat(name, " Happy weekend ");
            }

            return todayProgram;
        }

    }
}
