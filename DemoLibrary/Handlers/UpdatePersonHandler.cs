using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoLibrary.Handlers
{
    internal class UpdatePersonHandler : IRequestHandler<UpdatePersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;
        public UpdatePersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.UpdatePerson(request.data)); 
        }
    }
}
