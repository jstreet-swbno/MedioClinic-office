using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public enum FormFileResultState
    {
        FileOk,
        FileEmpty,
        FileTooBig,
        ForbiddenFileType
    }
}
