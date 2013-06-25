﻿#region Header

// ===================================================================================
// Copyright 2010 HexaSystems Corporation
// ===================================================================================
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// ===================================================================================
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// See the License for the specific language governing permissions and
// ===================================================================================

#endregion Header

namespace Hexa.Core.Domain
{
    using System;
    using System.Collections.Generic;

    public static class DatabaseQuery
    {
        #region Fields

        public static Func<IDatabaseQueryProvider> DatabaseQueryProvider;

        #endregion Fields

        #region Methods

        public static IList<TEntity> ExecuteQuery<TEntity>(string queryName, IDictionary<string, object> parameters)
        {
            return DatabaseQueryProvider().ExecuteQuery<TEntity>(queryName, parameters);
        }

        #endregion Methods
    }
}