using System;
using Microsoft.Extensions.DependencyInjection;

namespace Adyen.Core.Client
{
    /// <summary>
    /// The factory interface for creating the services that can communicate with the Adyen APIs.
    /// </summary>
    public interface IApiFactory
    {
        /// <summary>
        /// A method to create an IApi of type IResult
        /// </summary>
        /// <typeparam name="IResult"></typeparam>
        /// <returns></returns>
        IResult Create<IResult>() where IResult : IAdyenApiService;
    }

    /// <summary>
    /// The implementation of <see cref="IApiFactory"/>.
    /// </summary>
    public class ApiFactory : IApiFactory
    {
        /// <summary>
        /// The service provider
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiFactory"/> class.
        /// </summary>
        /// <param name="services"></param>
        public ApiFactory(IServiceProvider services)
        {
            Services = services;
        }

        /// <summary>
        /// A method to create an IApi of type IResult
        /// </summary>
        /// <typeparam name="IResult"></typeparam>
        /// <returns></returns>
        public IResult Create<IResult>() where IResult : IAdyenApiService
        {
            return Services.GetRequiredService<IResult>();
        }
    }
}