using System;
using System.Threading.Tasks;

namespace ExplicitArchitecture
{
    /// <summary> 
    /// A Service executes business logic for a use case.
    /// </summary>
    public interface IService<in TInDTO, TOutDTO>
    {
        /// <summary>
        /// Executes the use case.
        /// </summary>
        /// <param name="inDTO">Encapsulated inDTO parameters.</param>
        /// <param name="successHandler">The action to use for a successful result.</param>
        /// <param name="errorHandler">The action to use for an unsuccessful result.</param>
        Task Execute(TInDTO inDTO, Action<TOutDTO> successHandler,
            Action<Exception> errorHandler);
    }
}
