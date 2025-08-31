using Core.BusinessLogicServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Views.Operations
{
    public interface IBaseOperation<TService>:IOperation
        where TService :class
    {
        //public int OperationId { get; set; }
        void Execute(TService serviceBl);
    }
}
