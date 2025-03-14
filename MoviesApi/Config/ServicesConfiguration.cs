﻿using MoviesApi.Data;
using MoviesApi.Services;
using MoviesApi.Services.Interfaces;

namespace MoviesApi.Config
{
    public static class ServicesConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieManipulationService, MovieManipulationService>();
            services.AddScoped<AppDbContext>();
            services.AddSingleton<IUserService, UserService>();
        }
    }
}
