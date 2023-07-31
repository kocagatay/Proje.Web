﻿using Microsoft.AspNetCore.Identity;

namespace Proje.Web.Localization
{
    public class LocalizationIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName)
        {
            return new() { Code = "DuplicateUserName", Description = $"{userName} daha önce başka bir kullanıcı tarafından alınmıştır" };
            //return base.DuplicateUserName(userName);
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new() { Code = "DuplicateEmail", Description = $"{email} daha önce başka bir kullanıcı tarafından alınmıştır" };
            //return base.DuplicateEmail(email);
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new() { Code = "PasswordTooShort", Description = $"Şifre en az 6 karakterli olmalıdır" };
            //return base.PasswordTooShort(length);
        }


    }
}
