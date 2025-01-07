﻿using MoviesApi.Services;
using MoviesApi.Services.Interfaces;

namespace MoviesApi.Config
{
    public static class ServicesConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieManipulationService, MovieManipulationService>();
        }
    }
}
