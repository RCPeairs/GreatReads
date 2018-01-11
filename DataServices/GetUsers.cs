using System;
using System.Collections.Generic;
using Entities;
using Constant;
using System.Data;
using System.Data.SqlClient;

namespace DataService
{
    public partial class DataServices
    {
        public IList<User> GetAllUsers()
        {
            var result = new List<User>();
            try
            {
                using (var sqlConnection = new SqlConnection(Constants.sqlConnectionString))
                {
                    using (var sqlCommand = new SqlCommand("[dbo].[GetAllUsers]", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        //sqlCommand.Parameters.AddWithValue("@Id", id);
                        sqlConnection.Open();

                        using (var sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.HasRows && sqlDataReader.Read())
                            {
                                var user = new User
                                {
                                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                                    FirstName = sqlDataReader["FirstName"].ToString(),
                                    LastName = sqlDataReader["LastName"].ToString(),
                                    Email = sqlDataReader["Email"].ToString(),
                                    UserName = sqlDataReader["UserName"].ToString(),
                                    StreetAddress = sqlDataReader["StreetAddress"].ToString(),
                                    City = sqlDataReader["City"].ToString(),
                                    State = sqlDataReader["State"].ToString(),
                                    Phone = sqlDataReader["Phone"].ToString(),
                                    Avatar = sqlDataReader["Avatar"].ToString(),
                                    Administrator = Convert.ToBoolean(sqlDataReader["Administrator"]),
                                    Member = Convert.ToBoolean(sqlDataReader["Member"]),
                                    PendingMember = Convert.ToBoolean(sqlDataReader["PendingMember"]),
                                    TextNewMember = Convert.ToBoolean(sqlDataReader["TextNewMember"]),
                                    TextNewActivity = Convert.ToBoolean(sqlDataReader["TextNewActivity"]),
                                    TextChangeMyActivity = Convert.ToBoolean(sqlDataReader["TextChangeMyActivity"]),
                                    TextNewBook = Convert.ToBoolean(sqlDataReader["TextNewBook"]),
                                    TextNewBBPost = Convert.ToBoolean(sqlDataReader["TextNewBBPost"]),
                                    EmailNewMember = Convert.ToBoolean(sqlDataReader["EmailNewMember"]),
                                    EmailNewActivity = Convert.ToBoolean(sqlDataReader["EmailNewActivity"]),
                                    EmailChangeMyActivity = Convert.ToBoolean(sqlDataReader["EmailChangeMyActivity"]),
                                    EmailNewBook = Convert.ToBoolean(sqlDataReader["EmailNewBook"]),
                                    EmailNewBBPost = Convert.ToBoolean(sqlDataReader["EmailNewBBPost"])
                                };

                                result.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }


    }
}
