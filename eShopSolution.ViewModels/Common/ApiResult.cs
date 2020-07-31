using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Common
{
    public class ApiResult<T>
    {
        
        public bool IsSuccessed { get; set; }
        public String Message { get; set; }
        public T ResultObj { get; set; }
    }
}
