using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodatnaNaloga.Services
{
    public class ConfirmBaseService : ComponentBase
    {
        protected bool ShowConfirm { get; set; }

        public void Show()
        {
            ShowConfirm = true;
        }

        [Parameter]
        public EventCallback<bool> ConfirChanged { get; set; }
    }
}
