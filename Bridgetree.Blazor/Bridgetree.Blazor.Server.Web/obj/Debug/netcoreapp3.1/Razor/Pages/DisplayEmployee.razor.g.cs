#pragma checksum "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b6d9fb9d83d5ac9c9c7c549ed42623ef53ed88"
// <auto-generated/>
#pragma warning disable 1591
namespace Bridgetree.Blazor.Server.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Server.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Server.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Models;

#line default
#line hidden
#nullable disable
    public partial class DisplayEmployee : DisplayEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-deck");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group m-3");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "class", "btn btn-secondary");
            __builder.AddAttribute(8, "href", "/editemployee");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                                                                    HandleClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Match", "NavLinkMatch.All");
            __builder.AddMarkupContent(11, "\r\n            Create Employee\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                                                  OnChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
#nullable restore
#line 11 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
     if (Employees != null)
    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "table");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<thead>\r\n                <tr>\r\n                    <th>Name</th>\r\n                    <th>Gender</th>\r\n                    <th>Department</th>\r\n                    <th>Email</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 24 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                 foreach (var emp in Employees)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                    ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 27 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                             emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 28 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                             emp.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 29 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                             emp.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 30 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                             emp.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "/editemployee/" + (
#nullable restore
#line 32 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                                                    emp.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "  |\r\n                            ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "href", "javascript:(0)");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                                                               (() => Delete(emp.EmployeeId,emp.FirstName)) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, " Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 36 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 40 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenComponent<Bridgetree.Blazor.Server.Web.Pages.Confirm>(58);
            __builder.AddAttribute(59, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 42 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                                                        ConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(60, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
                               $"Are you sure you want to delete \"{FirstName}\""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(61, (__value) => {
#nullable restore
#line 42 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"
               DeleteConfirmation = (Bridgetree.Blazor.Server.Web.Pages.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\DisplayEmployee.razor"

    private void HandleClick()
    {
        NavigationManager.NavigateTo("editemployee", true);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
