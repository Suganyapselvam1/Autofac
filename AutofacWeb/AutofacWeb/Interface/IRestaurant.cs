using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacWeb.Interface
{
    public interface IRestaurant
    {
        IEnumerable<string> GetAll();
    }
}
