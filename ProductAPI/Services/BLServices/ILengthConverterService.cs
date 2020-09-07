using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.BLServices
{
    public interface ILengthConverterService
    {
        double ConvertCmToInch(double cm);
    }
}
