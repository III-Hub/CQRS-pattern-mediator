using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{
    public record UpdatePersonCommand(PersonModel data) : IRequest<PersonModel>;
    
    //internal class UpdatePersonCommand
    //{
    //}
}
