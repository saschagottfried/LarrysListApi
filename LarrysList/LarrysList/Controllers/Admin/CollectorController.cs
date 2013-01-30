﻿using System;
using LarrysList.Auth;
using LarrysList.Models;

namespace LarrysList.Controllers.Admin
{
    public class CollectorController : BaseController
    {

        [AuthClient]
        public string index(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collector_get");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }


        [AuthClient]
        public string create(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collector_create");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string contactEdit(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collector_contacts_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }


        [AuthClient]
        public string basicEdit(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collector_base_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string businessEdit(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collector_business_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string sourceEdit(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_source_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }
        [AuthClient]
        public string document(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collector_document_assign");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

    }
}
