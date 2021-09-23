using System;
using FunctionalSharp.DiscriminatedUnions;

namespace CommonPorts
{
    public delegate TDestination MapDelegate<TSource, TDestination>(
        TSource source);

    /// <summary>
    /// Class associated with a result or an error.
    /// </summary>
    public class Result<T> : DiscriminatedUnion<T, Exception>
    {
        /// <summary>
        /// Constructor for the result.
        /// </summary>
        /// <param name="value">Value of the result.</param>
        public Result(T value) : base(value)
        {
        }

        /// <summary>
        /// Constructor for the error.
        /// </summary>
        /// <param name="error">Value of the error.</param>
        public Result(Exception error) : base(error)
        {
        }

        /// <summary>
        /// Maps the success value if result has one.
        /// </summary>
        /// <param name="mapping">Mapping for the success value.</param>
        public Result<TDestination> Map<TDestination>(
            MapDelegate<T, TDestination> mapping)
        {
            switch (tag)
            {
                case 0: return new Result<TDestination>(mapping(Item1));
                case 1: return new Result<TDestination>(Item2);
                default: throw new InvalidOperationException();
            };
        }
    }
}
