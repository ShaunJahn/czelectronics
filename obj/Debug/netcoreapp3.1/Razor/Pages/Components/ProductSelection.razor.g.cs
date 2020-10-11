#pragma checksum "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e1c50840b7e8205faa50a81b690321ef840fb0f"
// <auto-generated/>
#pragma warning disable 1591
namespace czelectronics.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics.Repository.StoreCodes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics.Repository.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics.Data.Models.MainForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics.Repository.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mrjsh\source\repos\czelectronics\_Imports.razor"
using czelectronics.Repository.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
using czelectronics.Data.Models;

#line default
#line hidden
#nullable disable
    public partial class ProductSelection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<label>\r\n    Product Type\r\n</label>\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control selectpicker");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                                                 ProductInput.ProductTypeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductInput.ProductTypeId = __value, ProductInput.ProductTypeId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "option");
            __builder.AddContent(7, "--select--");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 8 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
     foreach (var item in ProductTypes)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 10 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                        item.ProductTypeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                                             item.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 11 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.AddMarkupContent(15, "<label>\r\n    Model Number\r\n</label>\r\n<br>\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatTextField_0(__builder, 16, 17, 
#nullable restore
#line 17 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                           ProductInput.ModelNumber

#line default
#line hidden
#nullable disable
            , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.ModelNumber = __value, ProductInput.ModelNumber)), 19, () => ProductInput.ModelNumber);
            __builder.AddMarkupContent(20, "\r\n<br>\r\n");
            __builder.AddMarkupContent(21, "<label>\r\n    Serial Number\r\n</label>\r\n<br>\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatTextField_1(__builder, 22, 23, 
#nullable restore
#line 23 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                           ProductInput.SerialNumber

#line default
#line hidden
#nullable disable
            , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.SerialNumber = __value, ProductInput.SerialNumber)), 25, () => ProductInput.SerialNumber);
            __builder.AddMarkupContent(26, "\r\n<br>\r\n");
            __builder.AddMarkupContent(27, "<label>\r\n    Fault Insp. by Store\r\n</label>\r\n<br>\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatTextField_2(__builder, 28, 29, 
#nullable restore
#line 29 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                           ProductInput.FaultInspection

#line default
#line hidden
#nullable disable
            , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.FaultInspection = __value, ProductInput.FaultInspection)), 31, () => ProductInput.FaultInspection);
            __builder.AddMarkupContent(32, "\r\n<br>\r\n");
            __builder.AddMarkupContent(33, "<label>\r\n    Explain Fault\r\n</label>\r\n<br>\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatTextField_3(__builder, 34, 35, 
#nullable restore
#line 35 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                           ProductInput.FaultDescription

#line default
#line hidden
#nullable disable
            , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.FaultDescription = __value, ProductInput.FaultDescription)), 37, () => ProductInput.FaultDescription);
            __builder.AddMarkupContent(38, "\r\n<br>\r\n");
            __builder.AddMarkupContent(39, "<label>\r\n    Article Number\r\n</label>\r\n<br>\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatTextField_4(__builder, 40, 41, 
#nullable restore
#line 41 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                           ProductInput.ArticleNumber

#line default
#line hidden
#nullable disable
            , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.ArticleNumber = __value, ProductInput.ArticleNumber)), 43, () => ProductInput.ArticleNumber);
            __builder.AddMarkupContent(44, "\r\n<br>\r\n\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatSlideToggle_5(__builder, 45, 46, "Accessories", 47, 
#nullable restore
#line 44 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                              ProductInput.Accessories

#line default
#line hidden
#nullable disable
            , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.Accessories = __value, ProductInput.Accessories)), 49, () => ProductInput.Accessories);
            __builder.AddMarkupContent(50, "\r\n<br>\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatSlideToggle_6(__builder, 51, 52, "Box", 53, 
#nullable restore
#line 46 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                              ProductInput.Box

#line default
#line hidden
#nullable disable
            , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.Box = __value, ProductInput.Box)), 55, () => ProductInput.Box);
            __builder.AddMarkupContent(56, "\r\n<br>\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatSlideToggle_7(__builder, 57, 58, "Remote", 59, 
#nullable restore
#line 48 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                              ProductInput.Remote

#line default
#line hidden
#nullable disable
            , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.Remote = __value, ProductInput.Remote)), 61, () => ProductInput.Remote);
            __builder.AddMarkupContent(62, "\r\n<br>\r\n");
            __Blazor.czelectronics.Pages.Components.ProductSelection.TypeInference.CreateMatSlideToggle_8(__builder, 63, 64, "Manual", 65, 
#nullable restore
#line 50 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                              ProductInput.Manual

#line default
#line hidden
#nullable disable
            , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductInput.Manual = __value, ProductInput.Manual)), 67, () => ProductInput.Manual);
            __builder.AddMarkupContent(68, "\r\n<br>\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(69);
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                     UpdateList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(73, "Validate");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\mrjsh\source\repos\czelectronics\Pages\Components\ProductSelection.razor"
 
    [Parameter]
    public int ProductTypeId { get; set; }
    [Parameter]
    public List<Product> Products { get; set; }
    [Parameter]
    public EventCallback<List<Product>> ProductsChanged { get; set; }


    public Product ProductInput { get; set; } = new Product();
    public List<ProductType> ProductTypes { get; set; } = new List<ProductType>();

    protected override void OnInitialized()
    {
        ProductTypes = ProductsTypesService.GetProductsTypes();
        StateHasChanged();
    }

    async Task UpdateList()
    {
        Products.Add(ProductInput);
        await ProductsChanged.InvokeAsync(Products);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsTypes ProductsTypesService { get; set; }
    }
}
namespace __Blazor.czelectronics.Pages.Components.ProductSelection
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMatSlideToggle_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatSlideToggle<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatSlideToggle_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatSlideToggle<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatSlideToggle_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatSlideToggle<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatSlideToggle_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatSlideToggle<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591