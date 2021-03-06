﻿using System;
using LarrysList.Auth;
using LarrysList.Models;
using LarrysList.Services.Messaging;

namespace LarrysList.Controllers.Admin
{
    public class FeederController : BaseController
    {
        [AuthClient]
        public string create(Feeder feeder)
        {
            try
            {
                result = orm.execObject<Result>(feeder, "api.admin_feeder_email_signup");
                if (result.dbMessage == null)
                {
                    result.Feeder.sendWelcomeEmail();
                }
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string login(Feeder feeder)
        {
            try
            {
                result = orm.execObject<Result>(feeder, "api.admin_feeder_login");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }
        [AuthClient]
        public string updatePwd(Feeder feeder)
        {
            try
            {
                result = orm.execObject<Result>(feeder, "api.admin_feeder_update_pwd");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }


        [AuthClient]
        public string forgotPwd(Feeder feeder)
        {
            try
            {
                feeder.activationToken = Guid.NewGuid().ToString();
                result = orm.execObject<Result>(feeder, "api.admin_feeder_pwd_forgot");
                if (result.dbMessage == null)
                {
                    result.Feeder.sendPwdForgot();
                }
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }



        [AuthClient]
        public string resendForgotPwd(Feeder feeder)
        {
            try
            {
                feeder.activationToken = Guid.NewGuid().ToString();
                result = orm.execObject<Result>(feeder, "api.admin_feeder_resend_pwd_forgot");
                if (result.dbMessage == null)
                {
                    result.Feeder.sendPwdForgot();
                }
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string token(LoginLink loginLink)
        {
            try
            {
                result = orm.execObject<Result>(loginLink, "api.admin_feeder_login_link");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);

        }


        [AuthClient]
        public string emailAvailable(Feeder feeder)
        {
            try
            {
                result = orm.execObject<Result>(feeder, "api.admin_feeder_email_available");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }
        [AuthClient]
        public string list()
        {
            try
            {
                result = orm.execObject<Result>(null, "api.admin_feeder_list");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string collectors(Feeder feeder)
        {
            try
            {
                result = orm.execObject<Result>(feeder, "api.admin_feeder_collectors");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string submitted()
        {
            try
            {
                result = orm.execObject<Result>(null, "api.admin_feeder_pending_collectors");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string newsfeedset(NewsFeeds newsfeeds)
        {
            try
            {
                result = orm.execObject<Result>(newsfeeds, "api.admin_newsfeed_set");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string newsfeed()
        {
            try
            {
                result = orm.execObject<Result>(null, "api.admin_newsfeed_get");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }


        public string freeCredit(User user)
        {
            try
            {
                result = orm.execObject<Result>(user, "api.admin_free_credit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

    }
}
