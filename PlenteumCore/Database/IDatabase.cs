﻿//
// Copyright (c) 2018-2019 Canti, The TurtleCoin Developers
// 
// Please see the included LICENSE file for more information.

using Plenteum.CryptoNote.Blockchain;
using Plenteum.Database;
using System.Collections.Generic;

namespace Plenteum
{
    /// <summary>
    /// An enumerator representing allowed database types
    /// </summary>
    public enum DatabaseType
    {
        SQLITE = 0,
        IBOXDB = 1
    }

    /// <summary>
    /// Interface for a database handler
    /// </summary>
    public interface IDatabase
    {
        #region Properties and Fields

        /// <summary>
        /// This database's type
        /// </summary>
        DatabaseType Type { get; }

        /// <summary>
        /// Whether or not this database has been started
        /// </summary>
        bool Started { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Starts this database
        /// </summary>
        void Start();

        /// <summary>
        /// Stops this database
        /// </summary>
        void Stop();

        BlockRepository BlockRepository { get; set; }
        TransactionRepository TransactionRepository { get; set; }

        #endregion
    }
}
