using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using CinemaTicket.Views.Helper;
using System.Data;

namespace CinemaTicket.Views.UserOperations
{
    public class ShowUsersStrategy:IUserOperation
    {
        public int OperationId => 7;

        public void Execute(UserServices userBl)
        {
            ShowInfo(userBl.GetAll());
        }
        /// <summary>
        /// Show all of user store in list
        /// </summary>
        /// <param name="users"></param>
        public static void ShowInfo(ICollection<UserResponse> users)
        {
            DataTable table = new DataTable("People");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("FullName", typeof(string));
            table.Columns.Add("Email", typeof(string));

            foreach (var item in users)
            {
                table.Rows.Add(item.Id, item.FullName, item.Email);
            }
            Print.PrintTable(table);
        }
    }
}
