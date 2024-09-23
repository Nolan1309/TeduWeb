using System;
using System.Collections.Generic;
using System.Text;
using TeduWeb.Data.Enums;

namespace TeduWeb.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
