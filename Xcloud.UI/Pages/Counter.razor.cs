using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xcloud.UI.Pages{
    public partial class Counter : ComponentBase{
        private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
    }
}