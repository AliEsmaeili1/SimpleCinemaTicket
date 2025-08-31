using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using Core.DTO.Update;

namespace CinemaTicket.Views.CinemaOperation
{
    public class UpdateCinemaStrategy : ICinemaOperation
    {
        public int OperationId => 4;

        public void Execute(CinemaViewModel cinemaViewModel)
        {
            Console.WriteLine("Insert user id to update?");
            int id = int.Parse(Console.ReadLine());

            var updateRequest = GetInfoTUpdate(cinemaViewModel.cinemaBL, id);
            cinemaViewModel.cinemaBL.Update(updateRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------Cinema Updated---------");
            Console.WriteLine("============================");
        }

        public static CinemUpdateRequest GetInfoTUpdate(CinemaService cinmaBL, int id_to_update)
        {
            CinemaResponse? oldCinema = cinmaBL.GetById(id_to_update);
            CinemUpdateRequest newCinema = new CinemUpdateRequest();
            newCinema.Id = oldCinema.Id;
            Console.WriteLine("Old Name: " + oldCinema.Name);
            Console.WriteLine("New Name");
            newCinema.Name = Console.ReadLine();
            Console.WriteLine("Old Address: " + oldCinema.Address);
            Console.WriteLine("Address");
            newCinema.Address = Console.ReadLine();
            return newCinema;
        }
    }
}
