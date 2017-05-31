﻿// Copied from http://www.zagstudio.com/blog/378 license MS-PL (Microsoft Public License)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swordfish.NET.Collections
{
    /// <summary>
    /// Represents a provider of collection details.
    /// </summary>
    /// <typeparam name="T">The type of items in the collection.</typeparam>
    public interface IVirtualizingCollectionItemsProvider<T>
    {
        /// <summary>
        /// Fetches the total number of items available.
        /// </summary>
        /// <returns></returns>
        int FetchCount();

        /// <summary>
        /// Fetches a range of items.
        /// </summary>
        /// <param name="startIndex">The start index.</param>
        /// <param name="count">The number of items to fetch.</param>
        /// <returns></returns>
        IList<T> FetchRange(int startIndex, int pageCount, out int overallCount);

        event EventHandler CountChanged;
    }
}
