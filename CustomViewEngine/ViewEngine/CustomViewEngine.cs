using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomViewEngine.ViewEngine
{
    public class CustomViewEngine : VirtualPathProviderViewEngine
    {


        public CustomViewEngine() {

            /*En la siguiente ruta encontrara las vistas asociadas con metodos de accion*/
            ViewLocationFormats = new string[] {
                "~/Views/{1}{0}.html",
                "~/Views/{0}.html"
        };

        }

        /*Crear instancia de vista personalizada*/
        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            var View = new ViewEngine.CustomView();

            View.ViewFilePath =
                controllerContext.HttpContext.Server.MapPath(viewPath);
            return View;
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            var View = new ViewEngine.CustomView();

            View.ViewFilePath =
                controllerContext.HttpContext.Server.MapPath(partialPath);
            return View;
        }


    }
}