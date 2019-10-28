﻿using System.Reflection;

namespace PipServices3.Commons.Data.Mapper
{
    internal interface IObjectMapperStrategy
    {
        void Transfer<TS, TT>(IObjectMapper mapper, TS objectSource, TT objectTarget, PropertyInfo propertyInfoSource,
            PropertyInfo propertyInfoTarget)
            where TS : class
            where TT : class;
    }
}
