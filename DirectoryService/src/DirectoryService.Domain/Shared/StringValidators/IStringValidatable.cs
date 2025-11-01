using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal interface IStringValidatable
    {
        bool IsValid(string str);
    }
}
