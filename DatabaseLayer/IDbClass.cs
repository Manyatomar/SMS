using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFormsApp1
{
    public interface IDbClass
    {
        public bool ValidateCredential(string username, string password);
    }
}
