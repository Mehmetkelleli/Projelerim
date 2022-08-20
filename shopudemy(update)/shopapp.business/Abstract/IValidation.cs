using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface IValidation<T>
    {
        string ErrorMesage { get; set; }
        bool Validation(T Entity); 
    }
}
