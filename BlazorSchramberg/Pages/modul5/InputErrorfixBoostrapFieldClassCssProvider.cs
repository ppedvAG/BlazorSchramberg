using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchramberg.Pages.modul5
{
    public class InputErrorfixBoostrapFieldClassCssProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, 
            in FieldIdentifier fieldIdentifier)
        {
            var isvalid=!editContext.GetValidationMessages(fieldIdentifier).Any();
            return isvalid ? "is-valid" : "is-invalid";
        }
    }
}
