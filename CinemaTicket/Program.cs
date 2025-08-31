using CinemaTicket.Views;
using CinemaTicket.Views.CinemaOperation;
using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Halloperation;
using CinemaTicket.Views.MovieOperation;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.SeatOperation;
using CinemaTicket.Views.ShowTimeOperation;
using CinemaTicket.Views.UserOperations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.Domain.Entities.Mapper;
using Core.Domain.Enums;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using Infrastructure.CinemaTicketDataBase;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Views.UserOperations;
using Spectre.Console;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            //Services
            services.AddScoped<IUserServiceContracts, UserServices>();
            services.AddScoped<ITicketServiceContracts, TicketService>();
            services.AddScoped<IShowTimeContracts, ShowTimeService>();
            services.AddScoped<ISeatServiceContracts, SeatService>();
            services.AddScoped<IMovieServiceContracts, MovieService>();
            services.AddScoped<IHallServiceContracts, HallService>();
            services.AddScoped<ICinemaServiceContracts, CinemaService>();

            //Repository DIP
            services.AddScoped<IBaseRespository<User>, UserRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBaseRespository<Ticket>, TicketRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IBaseRespository<Seat>, SeatRepository>();
            services.AddScoped<ISeatRepository, SeatRepository>();
            services.AddScoped<IBaseRespository<Hall>, HallRepository>();
            services.AddScoped<IHallRepository, HallRepository>();
            services.AddScoped<IBaseRespository<Cinema>, CinemaRepository>();
            services.AddScoped<ICinemaRepository, CinemaRepository>();
            services.AddScoped<IBaseRespository<Movie>, MovieRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IBaseRespository<ShowTime>, ShowTimeRepository>();
            services.AddScoped<IShowtimeRepository, ShowTimeRepository>();

            //
            services.AddScoped<IMapper<User, UserResponse>, UserMapper>();
            services.AddScoped<IMapper<Ticket, TicketResponse>, TicketMapper>();
            services.AddScoped<IMapper<ShowTime, ShowTimeResponse>, ShowTimeMapper>();
            services.AddScoped<IMapper<Seat, SeatResponse>, SeatMapper>();
            services.AddScoped<IMapper<Movie, MovieResponse>, MovieMapper>();
            services.AddScoped<IMapper<Cinema, CinemaResponse>, CinemaMapper>();
            services.AddScoped<IMapper<Hall, HallResponse>, HallMapper>();



            //Database
            services.AddDbContext<CinemaTicketDBcontext>(options =>
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=CinemaTicketDataBase;" +
                "Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;Trust Server Certificate=False;Application Intent=" +
                "ReadWrite;Multi Subnet Failover=False"));

             services.AddScoped<UserServices>();
             services.AddScoped<TicketService>();
             services.AddScoped<ShowTimeService>();
             services.AddScoped<SeatService>();
             services.AddScoped<MovieService>();
             services.AddScoped<HallService>();
             services.AddScoped<CinemaService>();


            services.AddScoped<IUserOperation, AddUserStrategy>();
            services.AddScoped<IUserOperation, UpdateUserStrategy>();
            services.AddScoped<IUserOperation, DeleteUserStrategy>();
            services.AddScoped<IUserOperation, ShowUsersStrategy>();
            services.AddScoped<IUserOperation, BuyTicket>();
            services.AddScoped<IUserOperation, CancleTicket>();
            services.AddScoped<IUserOperation, ShowTicket>();

            services.AddScoped<IShowTimeOperation, AddShowtimeSterategy>();
            services.AddScoped<IShowTimeOperation, ShowHallShowTime>();
            services.AddScoped<IShowTimeOperation, UpdateShowSterategy>();
            services.AddScoped<IShowTimeOperation, DeleteShowTimeSterategy>();
            services.AddScoped<IShowTimeOperation, BoardShowTimeSterategy>();
            services.AddScoped<IShowTimeOperation, MovieOperationSterategy>();


            services.AddScoped<ISeatOperation, AddSeatSterategy>();
            services.AddScoped<ISeatOperation, UpdateSeatSterategy>();
            services.AddScoped<ISeatOperation, DeleteSeatSterategy>();
            services.AddScoped<ISeatOperation, ShowSeatStrategy>();

            services.AddScoped<IMovieOperation, AddMovieSterategy>();
            services.AddScoped<IMovieOperation, UpdateMovieSterategy>();
            services.AddScoped<IMovieOperation, DeleteMovieSterategy>();
            services.AddScoped<IMovieOperation, ShowMovieStrategy>();

            services.AddScoped<IHallOperation, AddHallSterategy>();
            services.AddScoped<IHallOperation, ShowHallStrategy>();
            services.AddScoped<IHallOperation, UpdateHallSterategy>();
            services.AddScoped<IHallOperation, DeleteHallSterategy>();
            services.AddScoped<IHallOperation, SeatOperationSterategy>();

            services.AddScoped<ICinemaOperation, AddCinemaStrategy>();
            services.AddScoped<ICinemaOperation, UpdateCinemaStrategy>();
            services.AddScoped<ICinemaOperation, DeleteCinemaStrategy>();
            services.AddScoped<ICinemaOperation, ShowCinemaStrategy>();
            services.AddScoped<ICinemaOperation, ShowTimeSterategy>();
            services.AddScoped<ICinemaOperation, HallSterategy>();


            // Factories
            services.AddScoped<UserFactory>();
            services.AddScoped<TicketFactory>();
            services.AddScoped<ShowTimeFactory>();
            services.AddScoped<SeatFactory>();
            services.AddScoped<MovieFactory>();
            services.AddScoped<HallFactory>();
            services.AddScoped<CinemaFactory>();



            var serviceProvider = services.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var provider = scope.ServiceProvider;
                var UserBl = provider.GetRequiredService<UserServices>();
                var UserStrategyFactory = provider.GetRequiredService<UserFactory>();

                var TicketBl = provider.GetRequiredService<TicketService>();
                var TicketStrategyFactory = provider.GetRequiredService<TicketFactory>();

                var ShowTimeBl = provider.GetRequiredService<ShowTimeService>();
                var ShowTimeStrategyFactory = provider.GetRequiredService<ShowTimeFactory>();

                var SeatBl = provider.GetRequiredService<SeatService>();
                var SeatStrategyFactory = provider.GetRequiredService<SeatFactory>();

                var MovieBl = provider.GetRequiredService<MovieService>();
                var MovieStrategyFactory = provider.GetRequiredService<MovieFactory>();

                var HallBl = provider.GetRequiredService<HallService>();
                var HallStrategyFactory = provider.GetRequiredService<HallFactory>();

                var CinemaBl = provider.GetRequiredService<CinemaService>();
                var CinemaStrategyFactory = provider.GetRequiredService<CinemaFactory>();


                // ICollection<UserResponse> users = userBl.GetAll();

                // ICollection<string> usersSelect = users.Select(u => Convert.ToString(u.FullName)).ToList();


                int? select = 0;
                do
                {
                    Console.WriteLine("----*----select your operation------*-----");
                    Console.WriteLine("1: Show Users");
                    Console.WriteLine("2: User Operation");
                    Console.WriteLine("3: Cinema Operation");
                    Console.WriteLine("0: Exit");
                    if (!int.TryParse(Console.ReadLine(), out int selectValue))
                        continue;

                    select = selectValue;

                    if (select == 0) break;

                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("\t\t==================== USERS ==================");
                            ShowUsersStrategy.ShowInfo(UserBl.GetAll());
                            break;
                        case 2:
                            UserView.Index(UserBl, UserStrategyFactory);
                            break;
                        case 3:
                            CinemaViewModel cinemaViewModel = new CinemaViewModel()
                            {
                                cinemaBL = CinemaBl,
                                cinemaStrategyFactory = CinemaStrategyFactory,
                                hallBl = HallBl,
                                hallStrategyFactory = HallStrategyFactory,
                                movieBl = MovieBl,
                                movieSterategyFactory = MovieStrategyFactory,
                                seatBl = SeatBl,
                                seatStrategyFactory = SeatStrategyFactory,
                                showTimeBl = ShowTimeBl,
                                showTimeSterategyFactory = ShowTimeStrategyFactory
                            };
                            CinemaView.Index(cinemaViewModel);
                            break;
                        default:
                            break;
                    }
                } while (select != 0);
            }
        }
    }
}
