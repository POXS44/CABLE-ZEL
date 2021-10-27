using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao:ConnectionToSql
     {

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where Usuario=@user and Contraseña=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Usuario = reader.GetString(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.Apellido = reader.GetString(2);
                            UserLoginCache.Rol = reader.GetString(4);
                            //UserLoginCache.Email = reader.GetString(5);


                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        //Obtener datos 
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuarios where Usuario=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(1) + ", " + reader.GetString(2);
                        string userMail = reader.GetString(5);
                        string accountPassword = reader.GetString(3);
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                          subject: "Solicitud para recuperación la contraseña ",
                          body: "Hola, " + userName + "\nSolicitastes Recuperar tu contraseña.\n" +
                          "Tu contraseña es : " + accountPassword +
                          "\nSe recomienda solicitar un cambio de contraseña con el administrador del sistema",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\nSolicitastes Recuperar tu contraseña.\n" +
                          "Porfavor revise su correo : " + userMail +
                          "\nSe recomienda solicitar un cambio de contraseña con el administrador del sistema";
                    }
                    else
                        return "Lo sentimos wey no sea mula ingrese un correo o usuario que realmente exista ATT: EL BICHO ";
                }
            }
        }



        //Roles de usuario
        public void AnyMethod()
        {

            if (UserLoginCache.Rol == Roles.Administrador)
            { }

            if (UserLoginCache.Rol == Roles.Facturador)
            { }


        }

    }
    
  

}

