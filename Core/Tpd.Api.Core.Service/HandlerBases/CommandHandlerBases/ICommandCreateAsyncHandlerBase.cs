﻿using Tpd.Api.Core.DataTransferObject;
using Tpd.Api.Core.Service.RequestBases.CommandBases;

namespace Tpd.Api.Core.Service.HandlerBases.CommandHandlerBases
{
    public  interface ICommandCreateAsyncHandlerBase<TCommand, TDto> : ICommandAsyncHandlerBase<TCommand>
        where TDto : DtoBase
        where TCommand : ICommandCreateBase<TDto>
    {

    }
}