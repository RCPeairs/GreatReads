using System;
using Entities;
using Constant;
using System.Data;
using System.Data.SqlClient;

namespace DataService
{
    public partial class DataServices
    {
        public int AddUser(User auser)
        {
            int vreturnCode = Constants.failCode;
            try
            {
                using (var sqlConnection = new SqlConnection(Constants.sqlConnectionString))
                {
                    using (var sqlCommand = new SqlCommand("[dbo].[AddUser]", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add("@Id", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        sqlCommand.Parameters.AddWithValue("@FirstName", auser.FirstName);
                        sqlCommand.Parameters.AddWithValue("@LastName", auser.LastName);
                        sqlCommand.Parameters.AddWithValue("@Email", auser.Email);
                        sqlCommand.Parameters.AddWithValue("@UserName", auser.UserName);
                        sqlCommand.Parameters.AddWithValue("@Password", auser.Password);
                        sqlCommand.Parameters.AddWithValue("@StreetAddress", auser.StreetAddress);
                        sqlCommand.Parameters.AddWithValue("@City", auser.City);
                        sqlCommand.Parameters.AddWithValue("@State", auser.State);
                        sqlCommand.Parameters.AddWithValue("@Zip", auser.Zip);
                        sqlCommand.Parameters.AddWithValue("@Phone", auser.Phone);
                        sqlCommand.Parameters.AddWithValue("@Avatar", auser.Avatar);
                        sqlCommand.Parameters.AddWithValue("@AdminNotes", auser.AdminNotes);
                        sqlCommand.Parameters.AddWithValue("@Administrator", auser.Administrator);
                        sqlCommand.Parameters.AddWithValue("@Member", auser.Member);
                        sqlCommand.Parameters.AddWithValue("@PendingMember", auser.PendingMember);
                        sqlCommand.Parameters.AddWithValue("@TextNewMember", auser.TextNewMember);
                        sqlCommand.Parameters.AddWithValue("@TextNewActivity", auser.TextNewActivity);
                        sqlCommand.Parameters.AddWithValue("@TextChangeMyActivity", auser.TextChangeMyActivity);
                        sqlCommand.Parameters.AddWithValue("@TextNewBook", auser.TextNewBook);
                        sqlCommand.Parameters.AddWithValue("@TextNewBBPost", auser.TextNewBBPost);
                        sqlCommand.Parameters.AddWithValue("@EmailNewMember", auser.EmailNewMember);
                        sqlCommand.Parameters.AddWithValue("@EmailNewActivity", auser.EmailNewActivity);
                        sqlCommand.Parameters.AddWithValue("@EmailChangeMyActivity", auser.EmailChangeMyActivity);
                        sqlCommand.Parameters.AddWithValue("@EmailNewBook", auser.EmailNewBook);
                        sqlCommand.Parameters.AddWithValue("@EmailNewBBPost", auser.EmailNewBBPost);

                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        int vnewRecordId = (int) sqlCommand.Parameters["@Id"].Value;
                        sqlConnection.Close();
                        if (vnewRecordId >= 0)
                        {
                            auser.Id = vnewRecordId;
                            vreturnCode = Constants.successCode;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return vreturnCode;
        }


    }
}

