// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DemoBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\_Imports.razor"
using DemoBlazor;

#line default
#line hidden
#line 7 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\_Imports.razor"
using DemoBlazor.Shared;

#line default
#line hidden
#line 2 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\Pages\Login.razor"
using Blazor.Extensions.Storage;

#line default
#line hidden
#line 3 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\Pages\Login.razor"
using DemoBlazor.Models;

#line default
#line hidden
#line 4 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\Pages\Login.razor"
using DemoBlazor.Services;

#line default
#line hidden
#line 5 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\Pages\Login.razor"
using DemoBlazor.Utilities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 33 "C:\Users\dpurl\OneDrive\Masaüstü\DemoBlazor\DemoBlazor\Pages\Login.razor"
       

    LoginModel loginModel = new LoginModel();

    private async Task HandleLogin()
    {
       await AuthService.Login(loginModel);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalStorage LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591