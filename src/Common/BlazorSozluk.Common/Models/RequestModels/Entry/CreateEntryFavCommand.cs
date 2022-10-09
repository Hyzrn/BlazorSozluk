﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Models.RequestModels.Entry
{
    public class CreateEntryFavCommand : IRequest<bool>
    {
        public Guid? EntryId { get; set; }

        public Guid? UserId { get; set; }

        public CreateEntryFavCommand(Guid? entryId, Guid? userId)
        {
            EntryId = entryId;
            UserId = userId;
        }
    }
}
