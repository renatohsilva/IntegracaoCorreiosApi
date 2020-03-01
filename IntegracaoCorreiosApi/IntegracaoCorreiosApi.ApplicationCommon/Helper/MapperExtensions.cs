﻿using AutoMapper;
using System.Collections.Generic;

namespace IntegracaoCorreiosApi.ApplicationCommon.Helper
{
    public static class MapperExtensions
    {
        public static IEnumerable<TDestination> MapList<TSource, TDestination>(this IMapper mapper, IEnumerable<TSource> source)
        {
            return mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(source);
        }
    }
}
