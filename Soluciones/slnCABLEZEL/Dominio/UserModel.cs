using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess;
using Common.Cache;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);

        }
        //ME SIRVE EMAIL
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }
        public void AnyMethod()
        {

            if (UserLoginCache.Rol == Roles.Administrador) {
                //Codes
            }
            if (UserLoginCache.Rol == Roles.Facturador)
            {
                //codes
            }
        }
    


    }
}
