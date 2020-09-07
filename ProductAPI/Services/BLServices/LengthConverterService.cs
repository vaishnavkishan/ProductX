using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.BLServices
{
    //Would have used some library.
    public class LengthConverterService : ILengthConverterService
    {
        public double ConvertCmToInch(double cm) => cm / 2.54;
    }
}
