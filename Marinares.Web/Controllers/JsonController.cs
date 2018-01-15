using System;
using System.Web.Mvc;
using Marinares.Data;
using Marinares.Data.Enums;
using Resources;
using Marinares.Data.Shared;

namespace Marinares.Web.Controllers
{
    public class JsonController : Controller
    {
        protected JsonResult CreateJsonGet<TResponse>(TResponse response)
        {
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        protected JsonResult InvalidData()
        {
            return Warning(Messages.InvalidData);
        }

        protected JsonResult CreateJson<TResponse>(TResponse response)
        {
            return Json(response);
        }

        protected JsonResult Ok<TContent>(TContent content)
        {
            return Create(new Response<string, TContent>(StatusResponse.success.ToString(), content));
        }

        protected JsonResult Info<TContent>(TContent content)
        {
            return Create(new Response<string, TContent>(StatusResponse.info.ToString(), content));
        }

        protected JsonResult Warning<TContent>(TContent content)
        {
            return Create(new Response<string, TContent>(StatusResponse.warning.ToString(), content));
        }

        protected JsonResult Error<TContent>(TContent content, Exception exception)
        {
            return Create(new Response<string, TContent>(StatusResponse.error.ToString(), content));
        }

        protected JsonResult GenericError(Exception exception)
        {
            return Error(Messages.GenericError, exception);
        }

        protected JsonResult Create<TStatus, TContent>(Response<TStatus, TContent> response)
        {
            return Json(response);
        }
    }
}